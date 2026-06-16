# Chapter 20 — Bet Sizing Theory

Bet sizing is the dial that's been turning quietly under every chapter — "bet small here," "overbet there," "size up vs. stations." This chapter pulls it all together into a coherent theory. **How much** you bet is as important as **whether** you bet, because size determines how much fold equity you generate, how much value you extract, what range you represent, and what price you lay your opponent. Master sizing and you stop betting "a normalish amount" on autopilot and start choosing each size for a reason. We cover the core principles, the standard sizes and when to use them, overbets, geometric sizing, and the two-way street of sizing as a read and a tell.

---

## 20.1 The Four Things a Bet Size Controls

Every size simultaneously sets four things. Good sizing optimizes them for your goal:

1. **Fold equity / the price you lay.** A bigger bet asks villain to risk more to continue (lower MDF for them → they fold more), generating more fold equity per bluff but risking more. A smaller bet folds out less but risks less (Ch. 2.6).
2. **Value extracted.** A bigger bet wins more *when called* — but gets called *less often*. The value-maximizing size balances "amount × call frequency" against the worse hands that will actually pay.
3. **The range you represent (and credibly hold).** Big bets and overbets represent **polarized** ranges (nuts + bluffs); small bets represent **wide/linear** ranges (Ch. 3.3). Your size tells a story — make sure your actual range can credibly tell it.
4. **Pot growth toward stacks.** Sizing sets up future streets. Bet big on the flop/turn and you're set up to jam the river; bet small and the pot stays controllable. Plan sizing across streets, not one bet at a time.

> **The governing question.** Before sizing, ask: *what am I trying to do, and what range am I representing?* Value from a wide calling range → small. Max value + protection from a polarized nutted range on a dynamic board → big. Deny equity cheaply on a board that crushed villain → small and high-frequency. Set up a river stack-off → size the turn so the river jam is natural. Size follows intention, not habit.

---

## 20.2 Size Maps to Range Shape (Small = Wide, Big = Polar)

The single most important sizing principle, established in Chapter 3.3 and reinforced everywhere since:

- **Small bets (25–40% pot) ↔ wide, linear, merged ranges.** You're betting many hands (often your whole range), so you bet small — you don't need a big size to pressure a range with few strong hands, and a small size lets you bet *everything* cheaply. Used for **range bets** on range-favoring boards and **thin value/merged** river bets.
- **Big bets (66–100%+ pot) ↔ polarized ranges.** You're betting the **nuts and bluffs, not the middle** — so you bet big to maximize value from the nuts and fold equity from the bluffs, while your medium hands check. Used on **dynamic boards with nut advantage**, **turn barrels**, and **polar river bets**.
- **Overbets (>100% pot) ↔ very polarized + strong nut advantage.** The extreme of the above (Section 20.4).

This mapping works in **both directions**: choose your size to match the range you're representing (and holding), *and* read villain's size to infer their range shape (Section 20.5). When your size and your range don't match — e.g., betting small with a polarized range, or overbetting a merged one — you either leave money on the table or become exploitable.

---

## 20.3 The Standard Sizes and When to Use Them

| Size | Name | Primary use | Represents |
|------|------|-------------|------------|
| **25–33% pot** | Small / "range bet" | Dry, range-favoring flops; bet whole range cheaply; deny free cards | Wide / linear |
| **40–50% pot** | Medium-small | Merged value, semi-protection, thin value | Wide-ish / merged |
| **60–75% pot** | Standard / big | Protection on dynamic boards, polarized value+bluffs, turn barrels | Polar-ish |
| **80–100% pot** | Big / pot | Strong polarization, charging draws hard, big turn/river bets | Polarized |
| **125–200%+ pot** | Overbet | Nut advantage on dynamic boards / capped villain; max pressure | Very polarized |

These are reference points, not rigid rules — but they cover the vast majority of spots. Note how size climbs with **board dynamism** and **nut advantage**: static, range-favoring boards → small; dynamic, nut-advantage boards → big/overbet.

---

## 20.4 Overbets: The Power Tool

An **overbet** (betting more than the pot) is the most intimidating and misunderstood size. It's correct in specific, identifiable conditions:

**Overbet when you have BOTH:**
1. A strong **nut advantage** — you hold meaningfully more of the very best hands than villain *can* (Ch. 3.5). Villain's range is **capped** (can't have the nuts) while yours is **uncapped**.
2. A **polarized range** — you're betting nuts and bluffs, not medium hands.

**Why it works:** against a capped range, an overbet puts villain's entire range in a vise — they can never be confident they're good, they lack the nuts to raise, and the math (Ch. 2.6) lets you run a **bluff-heavy** range profitably (an overbet can be >50% bluffs and still be unexploitable). You extract maximum from your nutted hands and apply maximum fold equity with your bluffs.

**Where overbets shine:**
- **Rivers** where villain's range is capped (they called, called, and never raised — they don't have the nuts) and a scare card favors *your* range.
- **Turns** on dynamic boards where you hold the nut advantage (e.g., you 3-bet, hold the overpairs/sets/nut draws, and villain's flatting range is capped).
- **Against players who don't fold to overbets** — *value*-overbet them (they call too wide) and skip the overbet bluffs.

**Don't overbet** when you lack nut advantage (villain can have the nuts and snap you off / raise you), with merged ranges (medium hands hate the bloated pot), or against stations as a bluff (they call). The overbet is a scalpel for capped-range spots, not a default.

---

## 20.5 Geometric Sizing (Setting Up the Stacks)

When you have a strong, polarized hand and want to get **stacks in by the river**, you can't always do it with one bet — you plan a **sequence** of bets across streets. **Geometric sizing** means betting the **same fraction of the pot on each remaining street** so that the pot grows smoothly and you're all-in (or have bet your whole stack) by the river, extracting the maximum.

- **The idea:** if you bet, say, ~75% pot on flop, turn, and river, the pot grows geometrically and your three bets total your stack — getting **maximum value** while keeping each individual bet a "reasonable" size villain can call. Cramming it into one or two huge bets would fold villain out; spreading it geometrically keeps them calling each street.
- **Practical use:** with the nuts or near-nuts on a board where you expect multiple streets of calls, think *backwards from the river* — what flop/turn sizes set up a natural river jam? This is how you stack opponents with big hands without an awkward final-street overbet that screams "I have it."
- You don't need to compute exact geometric fractions at the table; the **intuition** — "size my earlier streets so the river bet is a natural all-in, not an awkward shove" — is what matters.

---

## 20.6 Sizing as a Read and as a Tell

Sizing is a **two-way street**:

**Reading villain's sizing (Ch. 24 expands this):**
- **Small bets** → usually **wide/merged/capped** ranges (range bets, thin value, weak-ish hands wanting a cheap continue) — often more bluff-catchable.
- **Big bets / overbets** → usually **polarized** (nutted value or bluffs) — fold your medium hands, bluff-catch only with good blockers and against over-bluffers.
- **Sizing tells** (especially among weaker players): many recreational players **bet big with strong hands and small with weak ones** (or "blocker bet" small with medium hands hoping to see a cheap showdown). Exploit transparent sizing — fold to their big bets, raise/call their small ones, accordingly.

**Disguising your own sizing (balance):**
- Against **observant opponents**, use the **same sizes with value and bluffs** in a given spot so your size doesn't reveal your hand. If you only overbet the nuts and never bluff, good players fold everything to your overbet.
- Against **non-observant opponents (most of the pool)**, **balance barely matters** — size to exploit. Bet big for value when they call too much; bet small to fold them when they over-fold; use whatever size prints, because they're not reading your sizing anyway.

> **The balance-vs-exploit sizing rule.** Versus tough regs, keep your sizes **consistent across value and bluffs** so you don't become readable. Versus everyone else, **let your sizing be an exploit** — there's no reason to disguise your size from someone who isn't watching it. Most of your sizing decisions in 6-max are exploitative, because most of your opponents aren't tracking your sizing tells.

---

## 20.7 The Exploitative Layer

- **vs. stations:** **size up for value** (they call big), and **don't bother with big bluffs** (they don't fold). Value bets and overbets get paid; bluff sizing is irrelevant because you shouldn't bluff.
- **vs. nits / over-folders:** **smaller value sizes** (get crying calls) and **smaller, frequent bluffs** (you don't need big sizes to fold out an over-folder — alpha is met cheaply).
- **vs. players who fold to overbets:** **overbet bluff** more (cheap folds relative to the threat) — but only where you can credibly represent the nuts.
- **vs. players with transparent sizing tells:** exploit directly — fold to their "big = strong," attack their "small = weak," and call/raise their blocker bets.
- **vs. tough regs:** **consistent, balanced sizing**; choose sizes by board (small on range-favoring, big/overbet on dynamic nut-advantage) and keep value and bluffs the same size.

> **The leak this chapter fixes.** The universal sizing leak is **betting the same "normal" size every time regardless of goal, board, or range** — which leaves value uncollected (under-betting the nuts on boards that call for big bets), wastes chips (over-betting merged ranges), and telegraphs your hand (sizing tells). The fix: **size for intention** — small for wide/linear value and denial, big for polarized value/protection, overbet for capped-range nut-advantage spots — and **plan sizing across streets** toward the river.

---

## 20.8 Chapter Summary

- A bet size controls **fold equity/price, value extracted, the range represented, and pot growth toward stacks** — size for your **intention and represented range**, not by habit.
- **Size maps to range shape:** **small (25–40%) = wide/linear** (range bets, thin value); **big (66–100%+) = polarized** (value+bluffs, dynamic/nut-advantage boards); **overbet (>100%) = very polarized + strong nut advantage.** This mapping works both ways — choose your size to match your range, and read villain's size to infer theirs.
- Use the **standard-size table**; size climbs with **board dynamism and nut advantage**.
- **Overbet** only with **nut advantage + polarized range** against a **capped** villain (or for value vs. players who call overbets too wide); never overbet merged ranges or bluff-overbet stations.
- **Geometric sizing:** plan a **sequence** of bets (similar pot fractions each street) so you're naturally all-in by the river with big hands — think backwards from the river.
- **Sizing is a read and a tell:** exploit transparent opponents' sizing; keep your own sizes **consistent (value=bluff)** vs. observant regs, but **size to exploit** vs. everyone else (most of the pool isn't watching).

**This completes Part V (Street-by-Street Postflop).** You now have an integrated process for the flop (Ch. 17), turn (Ch. 18), river (Ch. 19), and the sizing theory (Ch. 20) that runs through all of them.

**Next:** [Chapter 21 — Player Types](21-player-types.md) opens **Part VI (Reading Villains)** — your second priority — starting with how to classify opponents and tailor a game plan to each archetype.
