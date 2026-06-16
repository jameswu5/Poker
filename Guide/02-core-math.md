# Chapter 2 — Core Math

Poker is a game of incomplete information played for money, and money decisions are mathematical. You do not need to be a mathematician to win, but you do need to internalize a small set of calculations until they are reflexive. This chapter covers the essential math: **equity, pot odds, expected value (EV), outs, implied and reverse-implied odds**, and the two defense formulas — **MDF and alpha** — that govern how often you must continue and how often a bluff needs to work. Everything in later chapters rests on these numbers.

The goal is not to compute to three decimal places at the table. It is to *estimate quickly and decide correctly*. We'll build the exact formulas, then the shortcuts.

---

## 2.1 Equity

**Equity** is your share of the pot if the hand were checked down to showdown — i.e., the percentage of the time your hand (or range) wins, plus half the ties. If you hold a hand with 60% equity against villain's hand in a £100 pot, your "fair share" of that pot is £60.

Two kinds of equity matter:

- **Hand vs. hand equity:** AKs vs. QQ preflop is about 46% / 54%. A flush draw vs. top pair on the flop is about 35% / 65%.
- **Hand vs. range equity:** your hand against *all* the hands villain could hold, weighted by how likely each is. This is the version that actually matters, because you rarely know villain's exact cards. Range equity is the foundation of real hand-reading (Chapter 3, Chapter 23).

A few benchmark matchups worth memorizing — they recur constantly:

| Matchup (preflop) | Approx. equity |
|-------------------|----------------|
| Pair vs. two overcards (e.g., 88 vs. AKo) | 55% / 45% — the classic "coin flip" (slightly favoring the pair) |
| Pair vs. two undercards (e.g., TT vs. 76s) | 80% / 20% |
| Dominated (e.g., AK vs. AQ) | 70% / 30% |
| Pair vs. lower pair (e.g., JJ vs. 88) | 80% / 20% |
| Two overcards vs. two undercards | 63% / 37% |

> **Why "equity realization" complicates this.** Raw equity assumes the hand goes to showdown with no more betting. It never does. Because of position, betting, and folding, you realize more or less than your raw equity (Chapter 1.2). A hand with 40% raw equity OOP might only *capture* 34% of the pot in practice. Keep raw equity and *realized* equity distinct in your mind.

---

## 2.2 Outs and the Rule of 2 and 4

An **out** is a card that improves you to (probably) the best hand. Counting outs lets you convert "I have a draw" into a probability.

Common draws and their outs:

| Draw | Outs | Reasoning |
|------|------|-----------|
| Flush draw | 9 | 13 cards of a suit − 4 you can see |
| Open-ended straight draw (OESD) | 8 | two ranks complete it × 4 suits |
| Gutshot (inside straight) | 4 | one rank × 4 suits |
| Two overcards | 6 | three of each rank remaining |
| Flush draw + OESD ("combo draw") | 15 | 9 + 8 − 2 shared cards (e.g., a card that makes both) |
| Set to full house/quads (on turn) | 7 | 3 to pair the board + ... (situational) |
| Gutshot + flush draw | 12 | 9 + 4 − 1 overlap |

**The Rule of 2 and 4** converts outs to equity fast:

- **On the flop, with two cards to come:** equity ≈ outs × **4**.
- **On the turn, with one card to come:** equity ≈ outs × **2**.

So a flush draw on the flop (9 outs) ≈ 36% to get there by the river; on the turn (9 outs) ≈ 18% for the river card. These are close enough to the true values (35% and 19.6%) for table use.

> **Caution — discount your outs.** Not all outs are "clean." If you have a flush draw but villain could have a higher flush draw, or if a card that completes your straight also completes a flush for villain, some outs are tainted. Good players *discount* outs they aren't sure are good. The rule of 2 and 4 gives you raw potential; judgment adjusts it down.

---

## 2.3 Pot Odds

**Pot odds** are the price you're being offered to continue: the ratio of what you must call to the total pot you'd be winning. Compare your **equity** to the **pot odds**; if your equity exceeds the price, calling is profitable (ignoring future betting for now).

**The formula (as a break-even percentage):**

$$\text{Break-even equity} = \frac{\text{amount to call}}{\text{amount to call} + \text{total pot after you call}}$$

**Worked example.** Pot is £100. Villain bets £50. The pot is now £150, and it costs you £50 to call.

$$\frac{50}{50 + 150} = \frac{50}{200} = 25\%$$

You need **25% equity** to call profitably. If you hold a flush draw on the flop (~36% by the river — but see the next paragraph), you have more than enough.

**Common bet sizes → required equity** (memorize these):

| Villain bets (fraction of pot) | You need to call |
|--------------------------------|------------------|
| 1/4 pot | 16.7% |
| 1/3 pot | 20% |
| 1/2 pot | 25% |
| 2/3 pot | 28.6% |
| 3/4 pot | 30% |
| Full pot | 33.3% |
| 1.5× pot (overbet) | 37.5% |
| 2× pot (overbet) | 40% |

> **Single card vs. running cards.** When you face a *flop* bet but will likely face *another bet on the turn*, you cannot simply use the two-cards-to-come equity (×4). You're only guaranteed to see *one* card for this price. Either use the one-card equity (×2) against the immediate price, or factor in implied odds and your plan for the turn. A flush draw facing a half-pot flop bet has 25% required equity vs. ~18% one-card equity — so a pure "call to hit" is slightly -EV *without* implied odds. This is why implied odds (2.5) matter so much for draws.

---

## 2.4 Expected Value (EV)

**Expected value** is the average result of a decision if you could repeat it infinitely. Every action — fold, call, raise — has an EV, and the winning play is simply *picking the highest-EV option available*.

**Folding always has EV = 0** (you win and lose nothing further; money already in the pot is no longer yours). So any call or raise is correct only if its EV is **positive**, *or* less negative than the alternatives.

**EV of a call (simplified, one street):**

$$EV = (\text{equity} \times \text{pot you win}) - (\text{1 − equity} \times \text{amount you call})$$

**Worked example.** Pot is £100, villain bets £50, you're getting 25% pot odds, and you have 36% equity with a flush draw (assume you'll see both cards — i.e., you're effectively all-in or will check it down):

$$EV = (0.36 \times 150) - (0.64 \times 50) = 54 - 32 = +\pounds 22$$

A +£22 call. Over many such spots, you print money.

**EV of a bluff** is the formula that underpins all aggression:

$$EV_{\text{bluff}} = (\text{fold frequency} \times \text{pot}) - (\text{1 − fold frequency} \times \text{bluff size})$$

If you bet £50 into a £100 pot as a pure bluff and villain folds 40% of the time:

$$EV = (0.40 \times 100) - (0.60 \times 50) = 40 - 30 = +\pounds 10$$

Profitable. This directly leads to the concept of **alpha** (2.6): how often does a bluff of a given size need to work to break even?

---

## 2.5 Implied Odds and Reverse Implied Odds

Pot odds consider only the *current* pot. But money won on *future* streets changes the calculus.

**Implied odds** = the extra money you expect to win on later streets *when you hit your hand*. They make drawing hands more profitable than raw pot odds suggest. Set-mining is the canonical example.

> **Set-mining example.** You hold 55 and call a raise hoping to flop a set (~1 in 8.5, roughly 11.8%). The immediate pot odds almost never justify the call. But when you *do* flop a set, you often win a large pot — sometimes villain's whole stack. The standard heuristic: to set-mine profitably, you want the implied payoff to be at least **~10–15×** the amount you're calling preflop (the "10-to-1 rule"), which requires deep enough effective stacks and an opponent likely to pay you off. This is why set-mining is great at 100bb+ against a strong hand and poor at 40bb or against a nit who'll fold.

Implied odds are larger when:
- Effective stacks are deep (more to win).
- Your draw is well-disguised (villain can't see it coming).
- Villain is a calling station / has a strong made hand.

**Reverse implied odds** = the extra money you expect to *lose* on later streets when you make a hand that *looks* good but is *second-best*. These make some hands traps.

> **Reverse-implied example.** You call a raise with KJo and flop top pair (K). It looks strong, but against a tight raiser, when the money goes in big, you're often dominated by AK, KQ, or a set. You win small pots and lose big ones — the signature of poor reverse-implied odds. Dominated hands (weak kickers, weak aces like A7o) suffer most. This is why "hands that make second-best hands" are dangerous, and why we discount them OOP and against tight ranges.

The general principle: **implied odds reward drawing hands that make the nuts or near-nuts (sets, flushes, straights, nut draws); reverse-implied odds punish hands that make marginal top pairs with weak kickers.**

---

## 2.6 The Defense Math: MDF and Alpha

These two formulas are the backbone of modern, balance-aware poker. They answer two mirror-image questions:

1. **Alpha** — *As the bettor:* how often does my bluff need to work?
2. **MDF** — *As the defender:* how often must I continue so I'm not exploitably over-folding?

### Alpha (bluff break-even frequency)

$$\alpha = \frac{\text{bet size}}{\text{bet size} + \text{pot}}$$

This is the fraction of the time a *pure bluff* must succeed (get a fold) to break even. Note it's the same as the pot-odds formula from the bettor's side.

| Bet size | α (bluff must work) |
|----------|---------------------|
| 1/3 pot | 25% |
| 1/2 pot | 33% |
| 2/3 pot | 40% |
| Full pot | 50% |
| 2× pot overbet | 67% |

Bigger bluffs need to work more often. A pot-sized bluff must succeed half the time to break even; if villain folds more than half, it prints.

### Minimum Defense Frequency (MDF)

$$\text{MDF} = \frac{\text{pot}}{\text{pot} + \text{bet size}} = 1 - \alpha$$

MDF is the **minimum fraction of your range you must continue with** (call or raise) to prevent villain from profitably bluffing *any two cards*. If you fold more than (1 − MDF), a bet of any size with any cards shows an immediate profit, and you are being exploited.

| Bet size villain makes | MDF (you must defend) | Max you can fold |
|------------------------|------------------------|------------------|
| 1/3 pot | 75% | 25% |
| 1/2 pot | 67% | 33% |
| 2/3 pot | 60% | 40% |
| Full pot | 50% | 50% |
| 2× pot overbet | 33% | 67% |

**Reading the table:** the *bigger* villain bets, the *less* of your range you're required to defend — because they're risking more, you can fold more and they still aren't auto-printing. This is the theoretical engine behind overbets: they let the bettor apply maximum pressure while the defender is mathematically permitted to fold a lot, so the bettor's bluffs need fewer folds *per bluff*... but each fold is worth more.

> **Critical caveat — MDF is a defensive ceiling, not a law.** MDF tells you how much to defend *to stop a bluff-everything strategy*. But real opponents are not bluffing every river with the right frequency. Against a player who **under-bluffs** (most low-stakes players, most nits), you should fold *far more* than MDF demands — defending to MDF against someone who only value-bets is lighting money on fire. Against a **maniac** who over-bluffs, you defend *beyond* MDF. **MDF is the GTO baseline; the read tells you which way to deviate.** This GTO-baseline-then-exploit pattern is the spine of the entire guide.

### Putting alpha and MDF together (the bluff-to-value ratio)

The same math dictates how many bluffs to pair with your value bets so a thinking opponent can't profitably call *or* fold. At a given bet size, the bettor's **value-to-bluff ratio** that makes the caller indifferent is:

| Bet size | Value : Bluff (on the river) |
|----------|------------------------------|
| 1/2 pot | 2 : 1 (≈33% bluffs) |
| 2/3 pot | 1.7 : 1 (≈37% bluffs) |
| Full pot | 1 : 1 (≈50% bluffs) |
| 2× pot overbet | 0.5 : 1 (≈67% bluffs) |

Bigger bets are allowed (and required) to contain *more* bluffs. We return to balanced bet construction in Chapters 19–20 and 25.

---

## 2.7 Combinatorics (Counting Combos)

Hand-reading requires counting how many *combinations* of each hand villain can hold. The basics:

- **Any specific unpaired hand** (e.g., AK): **16 combos** (4 suits × 4 suits). Of these, **4 are suited** (AKs) and **12 are offsuit** (AKo).
- **Any specific pocket pair** (e.g., QQ): **6 combos** (4 cards choose 2).
- **A pair when one card is on the board:** if a Q is on the flop, QQ drops from 6 combos to **3**.
- **A specific suited hand** (e.g., AKs): **4 combos**.

> **Why this matters — blockers.** If you hold the A♠ and the board is three spades, you *block* the nut flush: villain cannot have the A♠-high flush because you have the A♠. Holding key cards reduces the combos of strong hands villain can have, which informs both your bluffs (bluff when you block their value) and your calls (call more when you block their value, fold more when you block their bluffs). Blockers are a recurring advanced theme (Chapters 19, 25).

A quick worked count: on a Q-7-2 rainbow flop, how many value combos can a tight villain have? Sets: QQ (3), 77 (3), 22 (3) = 9 sets. Top pair: AQ (4 suited + ... actually count combos with one Q gone), etc. Learning to do this fast is what separates "I have a feeling he's strong" from "he has roughly 9 value combos and 4 plausible bluffs, so I'm getting the right price to call." We drill this in Part VI.

---

## 2.8 Chapter Summary

- **Equity** is your share of the pot at showdown; **range equity** (vs. all of villain's hands) is what matters. Memorize the benchmark matchups.
- **Outs → equity** via the **Rule of 2 and 4** (flop ×4, turn ×2). **Discount tainted outs.**
- **Pot odds** = price to continue. Compare equity to the required %; memorize the bet-size → equity table.
- **EV** drives every decision; folding is EV 0, so call/raise only when EV is higher. Learn the **bluff EV** formula.
- **Implied odds** reward nut-making draws (set-mining, flush draws) on deep stacks; **reverse implied odds** punish dominated top-pair hands.
- **Alpha** = how often your bluff must work = bet / (bet + pot). **MDF** = 1 − alpha = how much you must defend to stop auto-profit bluffs. **MDF is a GTO baseline — deviate based on whether villain over- or under-bluffs.**
- **Combinatorics:** 16 combos per unpaired hand (4 suited / 12 offsuit), 6 per pair. **Blockers** reduce villain's strong combos and guide bluffing and calling.

**Next:** [Chapter 3 — Ranges, Not Hands](03-ranges-not-hands.md), where we stop thinking about single holdings and start thinking the way winning players do: in entire ranges, with range and nut advantage as the lens.
