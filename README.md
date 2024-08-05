# Poker

## Evaluating Poker Hands

### Representing cards

When we would like to optimise a program, we would like to use as many primitive types (`int`, `string`, etc…) as possible. Therefore, it makes sense to model a playing card as an `int`. Now we technically only need to store information about its rank and its suit, which can very easily be encoded into 32 bits. Therefore we can use this encoding method:

```
xxxbbbbb bbbbbbbb cdhsrrrr xxpppppp
```

Here, a bit labeled `b` is activated depending on the rank of the card with the order (from least to most significant bit) being ace, king, …, three, two. One of the four bits labelled `cdhs` is turned on depending on the suit of the card. The bits labelled `rrrr` store the rank of the card, with the lowest rank being 2 with value 0, and the highest rank being ace with value 12. Finally, the bits labelled `pppppp` store the corresponding prime number of the rank, so rank 2 will have the first prime number, and rank ace will have the 12th prime number.

### Evaluating the hand

Let’s begin with the end in mind: there are 7462 distinct poker hands, so we would like our evaluator to take in any 5-card hand as input, and return a number between 1 and 7462 which represents how good it is, with 0 being the best possible hand. That way, to compare two hands, we can simply evaluate the two and compare the number returned. Since we pass in 5 cards, let’s (for convenience) call them `c1`, `c2`, up to `c5` respectively.

First, let’s consider hands whose five cards all have distinct rank. This is a nice property because we can condense these hands into a lookup table of size `7937` where the index is determined by the key:

```csharp
key = (c1 | c2 | c3 | c4 | c5) >> 16
```

The OR operations collect the ranks of the cards, and we right shift it by `16` to keep the key within the range `0` and `7936`, which is the highest possible index (`0b1111100000000`). There are two cases for those whose five cards all have distinct rank: they are flushes (all also have the same suit), or they aren’t.

Let’s start by detecting flushes. We can easily verify if we have a flush by evaluating

```csharp
c1 & c2 & c3 & c4 & c5 & 0xF000
```

where `0xF000` is the mask for the suit of the card (part labelled `cdhs`). By using the AND operation, if the resulting value is non-zero, then all five cards must have the same suit and thus we have a flush. We now have two cases: whether they form a straight or not. If they do, they form a straight flush and are the strongest hand.

We create a lookup table called `FlushLookup`, an array of size `7937`, where the index is determined by the key described above. Now to populate this lookup table, we deal with the straight flushes first. We iterate through the keys all possible straights (there are only ten of them) and populate this lookup table first. Then we can build up the rest of the lookup table from the worst hand to the best hand, decrementing the score value each time. We can do this by finding the next lexicographic bit sequence that also has 5 bits activated with a bit hack found [here](http://www-graphics.stanford.edu/~seander/bithacks.html#NextBitPermutation). For example, the next lexicographic bit sequence of `0b0000110111000` is `0b0000111000011` , the smallest integer bigger than the former that also has 5 bits activated.

We can use the same method to create a lookup table called `UniqueLookup`, an array of size `7937`, for hands with 5 distinct ranks but do not form a flush. We populate this lookup table essentially the same way as we did for `FlushLookup`, except now the straights are just straights so we set the score of the highest straight to a different value, and the non-straights are hands representing nothing, the weakest hands.

With this established, we see that while the same elements of `UniqueLookup` and `FlushLookup` will be populated, they will contain different values. To demonstrate this, `FlushLookup[0b1111100000000]` should contain `1` as it’s the score of the highest straight flush, while `UniqueLookup[0b1111100000000]` should contain `1600`, the score of the highest straight.

All that remains is to create look up tables for hands that have repeating ranks. For this, we have to use a different key for indexing, as we lose information about how many times the rank appears by using the key described above. Here, we can use the uniqueness property of product of primes to create a new key:

```csharp
key2 = (c1 & 0xFF) * (c2 & 0xFF) * ... * (c5 & 0xFF)
```

where the `0xFF` extracts the prime part of our representation of the card. It is no longer feasible to use an array since these keys can get very large: in the event of quad aces with king kicker, we have a key of $41^4 \times 37 = 104553157$ which is too high to justify using an array. Therefore, we use a hashmap `RepeatedLookup`. Populating this hashmap is a little similar to before, we consider each hand and iteratively generate better and better versions of this hand by using for loops and decrement the score each time until we reach the best hand.

With these lookup tables populated, it becomes very easy and efficient to evaluate a hand of five cards. We first check if it’s a flush by checking `c1 & c2 & c3 & c4 & c5 & 0xF000 > 0`. If so, we simply compute the key `k = (c1 | c2 | c3 | c4 | c5) >> 16` and return `FlushLookup[k]`.

If it’s not a flush, we check if all five cards are distinct. If so, we return `UniqueLookup[k]`.

If they’re not distinct either, we calculate the key `q = (c1 & 0xFF) * (c2 & 0xFF) * ... * (c5 & 0xFF)`. We simply return `RepeatedLookup[q]` and we’re done.

In games like Texas Hold’em, if we would like to evaluate a hand of seven cards, we simply iterate through all possible $7 \choose 5$ combinations of five cards and return the best hand value out of these.