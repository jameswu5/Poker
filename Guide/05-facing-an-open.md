# Chapter 5 — Facing an Open

Someone opens before you. Now you have three options: **3-bet** (re-raise), **flat-call** (just call the open), or **fold**. Choosing correctly is where a huge amount of edge lives, because these decisions happen constantly and set up the rest of the hand. This chapter gives you the framework — **why** and **when** to take each action — plus concrete ranges as grids, and the all-important distinction between **linear** and **polarized** 3-betting.

The master variables are always the same: **villain's position** (how wide is their open?), **your position** (are you in or out of position, and is anyone left to act behind you?), and **the player(s) involved** (tendencies). We build the logic, then apply it.

---

## 5.1 The Three Options and What Each Accomplishes

**Fold.** The default for most hands. You're not obligated to play; against a tight UTG open, folding the majority of your range is correct. Don't pay to play marginal hands out of position "just to see a flop."

**Flat-call (cold call).** You match the open and see a flop, keeping villain's range wide and your own range disguised. Flatting is **best in position** (you realize equity well) and with hands that **play well postflop but aren't strong enough to 3-bet for value** (e.g., suited connectors, medium pairs, suited broadways). Flatting has three big downsides to respect:
1. **It invites overcalls and squeezes.** Players behind you get a great price to come along, and aggressive players will *squeeze* (re-raise over the open + your call — Chapter 7). This is why flatting **out of position with players left to act** is dangerous.
2. **It keeps you without initiative.** You're the caller, not the aggressor.
3. **It caps you somewhat** — your strongest hands often 3-bet, so your flatting range can be attacked.

**3-bet (re-raise).** You re-raise the opener. This seizes initiative, builds a pot with your strong hands, generates fold equity (you can win immediately), and isolates the opener heads-up. 3-betting is the engine of aggression in 6-max. The key question is *what kind* of 3-betting range you're using — linear or polarized.

---

## 5.2 Linear vs. Polarized 3-Betting (The Central Concept)

There are two fundamentally different reasons to 3-bet, and they call for different ranges and sizes.

### Linear (a.k.a. "merged" / value 3-betting)
A **linear** 3-bet range is **the top of your range, top-down**: your best hands, all strong, no gaps. You 3-bet these because they're *good* — you want to build a pot and get value, and you're fine getting called.

- **Use it against opponents who don't fold enough** (calling stations, very loose openers) and against **wide opens you can punish with raw equity** — when your 3-bet gets called by worse a lot, you don't need bluffs, you just want value.
- **Composition:** strong pairs, strong broadways, strong aces (e.g., TT+, AQ+, sometimes AJs/KQs). No pure bluffs.

### Polarized ("value + bluffs, nothing in between")
A **polarized** 3-bet range is your **premium value hands paired with deliberate bluffs (semi-bluffs)** — and it *excludes* the medium-strength hands (which you flat or fold instead).

- **Use it against opponents who fold a reasonable amount** and in spots where your medium hands prefer flatting or folding. The bluffs generate fold equity; the value hands get paid; the medium hands stay out of a bloated pot.
- **Composition:** value (QQ+, AK, etc.) + **bluffs chosen for blocker value and playability** — classically **suited wheel aces (A5s–A2s)**, which block AA/AK and make nut flushes/straights, plus some suited connectors and suited gappers.

> **Why suited wheel aces are the canonical 3-bet bluff.** A5s–A2s do three things at once: (1) the ace **blocks** villain's AA and AK, making it less likely they have a hand strong enough to continue; (2) they retain **playability** — they flop nut-flush draws, wheel draws, and can make the nuts; (3) they have **backup equity** when called, so they're semi-bluffs, not pure air. This is the model for good bluff selection everywhere: *block their continues, keep equity.*

### The position rule for choosing
- **Out of position** (e.g., you're in the SB facing a BTN open, or the blinds facing any open): lean **polarized and 3-bet-or-fold**. Flatting OOP realizes equity poorly and invites squeezes, so you'd rather 3-bet (to take initiative and fold equity) or fold. Your flatting range OOP is thin.
- **In position** (e.g., you're on the BTN facing a CO open): lean toward **flatting a wide range** and 3-betting a **value-heavy linear range plus a few blocker bluffs**. Because flatting in position is so profitable (great equity realization, you close the action), you don't need to 3-bet as many bluffs — you can just call and outplay them postflop.

This single rule — *3-bet-or-fold OOP, flat-wide IP* — resolves most facing-an-open decisions.

---

## 5.3 3-Bet Sizing

| Situation | 3-bet size | Reason |
|-----------|-----------|--------|
| **In position** (e.g., BTN vs CO) | **~3× the open** (open 2.5 → 3-bet ~7.5–8bb) | You have position; you don't need to risk as much to deny equity. |
| **Out of position** (e.g., SB/BB vs any open) | **~4× the open** (open 2.5 → 3-bet ~10–11bb) | Bigger size denies the opener a cheap flat and compensates for your positional disadvantage. |
| **vs. a limper (isolation raise)** | open size **+ ~1bb per limper** on top | Charge limpers; deny them a cheap multiway flop. |

Against very deep stacks or specific opponents you'll adjust, but these are the reliable defaults. Note the principle: **OOP you size up.**

---

## 5.4 In-Position Example: Button vs. Cutoff Open

You're on the Button, the CO opens to 2.5bb, blinds yet to act. This is the **flat-wide, 3-bet linear-plus-blockers** archetype. **Legend: 3 = 3-bet, C = flat-call, · = fold.**

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 3 | 3 | 3 | C | C | C | C | C | C | 3 | 3 | 3 | 3 |
| **K** | 3 | 3 | C | C | C | C | · | · | · | · | · | · | · |
| **Q** | 3 | C | 3 | C | C | C | · | · | · | · | · | · | · |
| **J** | C | C | C | 3 | C | C | · | · | · | · | · | · | · |
| **T** | C | · | · | · | 3 | C | · | · | · | · | · | · | · |
| **9** | · | · | · | · | · | C | C | · | · | · | · | · | · |
| **8** | · | · | · | · | · | · | C | C | · | · | · | · | · |
| **7** | · | · | · | · | · | · | · | C | C | · | · | · | · |
| **6** | · | · | · | · | · | · | · | · | C | C | · | · | · |
| **5** | · | · | · | · | · | · | · | · | · | C | C | · | · |
| **4** | · | · | · | · | · | · | · | · | · | · | C | · | · |
| **3** | · | · | · | · | · | · | · | · | · | · | · | C | · |
| **2** | · | · | · | · | · | · | · | · | · | · | · | · | C |

**As text:**
- **3-bet (value):** TT+, AQs+, AKo, AQo *(KK/AA/AK/QQ/JJ/TT + AQs)*
- **3-bet (bluffs):** A5s, A4s, A3s, A2s *(suited wheel aces — blockers + playability)*
- **Flat:** 22–99, AJs–A6s, KQs–K9s, QJs–Q9s, JTs–J9s, T9s, 98s, 87s, 76s, 65s, 54s, plus AJo, ATo, KQo, KJo, QJo
- **Fold:** the rest

Notice how **wide the flatting region is** and how **few bluff 3-bets** there are — that's the in-position style. You happily call with all those suited and connected hands because position lets you realize their equity; you only 3-bet hands that want a big pot (value) or that make ideal blocker-bluffs.

---

## 5.5 Out-of-Position Example: Big Blind vs. Button Open

You're in the BB; the BTN opens to 2.5bb; SB folds. The BB is special because you **close the action** and get a **great price** (you've already posted 1bb, so you're calling ~1.5bb to win a ~5bb pot). This makes the BB the one OOP seat that **flats extremely wide** — but it still 3-bets a polarized range. **Legend: 3 = 3-bet, C = flat-call (defend), · = fold.**

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 3 | 3 | 3 | C | C | C | C | C | C | 3 | 3 | 3 | 3 |
| **K** | 3 | 3 | C | C | C | C | C | C | C | C | C | C | C |
| **Q** | 3 | C | 3 | C | C | C | C | C | C | C | C | · | · |
| **J** | C | C | C | 3 | C | C | C | C | C | · | · | · | · |
| **T** | C | C | C | C | 3 | C | C | C | C | · | · | · | · |
| **9** | C | C | C | C | C | C | C | C | C | · | · | · | · |
| **8** | C | C | C | C | C | C | C | C | C | C | · | · | · |
| **7** | C | C | · | · | · | C | C | C | 3 | C | C | · | · |
| **6** | C | · | · | · | · | · | · | · | C | 3 | C | · | · |
| **5** | C | · | · | · | · | · | · | · | · | C | C | C | · |
| **4** | C | · | · | · | · | · | · | · | · | · | C | C | · |
| **3** | C | · | · | · | · | · | · | · | · | · | · | C | · |
| **2** | C | · | · | · | · | · | · | · | · | · | · | · | C |

**As text:**
- **3-bet (value):** TT+, AQs+, AKo
- **3-bet (bluffs):** A5s–A2s, plus 76s and 65s *(suited connectors with equity)*
- **Flat (defend very wide):** all pairs 22–99; all suited aces A6s–AJs; all suited kings K2s+; suited queens Q4s+; suited jacks J6s+; suited tens T6s+; suited 9s/8s down low; suited connectors and gappers; and a broad band of offsuit broadways and **all offsuit aces (A2o+)**
- **Fold:** only the genuine trash — weak offsuit hands with no suit/connectedness and the worst suited junk

This is the widest defending range at the table — **the BB should fold far less than any other seat** because the price is so good. Failing to defend the BB adequately ("over-folding the big blind") is one of the most common and costly leaks in 6-max.

> **Why the BB flats so wide but the SB does not.** The BB *closes* the action (no one can squeeze you) and gets a better price (you've already posted a full blind). The SB, by contrast, still has the BB behind to squeeze, posts only half a blind, and is OOP against everyone — so the SB plays **3-bet-or-fold** with a much tighter, more polarized continuing range, rarely flatting. Same "out of position" label, very different strategy, because of *who closes the action* and *the price*.

---

## 5.6 Other Key Matchups (Text Ranges)

You can't memorize a grid for every pairing, so internalize the *adjustments* from the two anchor examples above.

**Facing an early-position (UTG) open — tighten everything.** UTG opens ~16% (strong, condensed). Your 3-bets should be **more linear/value-heavy** (their range has fewer hands to fold and more hands that crush your bluffs), and you flat tighter. Example, **BTN vs UTG open:**
- 3-bet (value): QQ+, AK, AQs (a notch tighter than vs CO)
- 3-bet (light, optional): A5s/A4s as occasional blockers — fewer bluffs than vs a wide opener
- Flat: 99–JJ, AQ, AJs, KQs, and a handful of suited broadways/connectors
- Fold: everything else — UTG's strength means most marginal hands aren't worth contesting

**Facing a late-position (CO/BTN) steal from the blinds — widen and polarize.** Their opening range is wide and weak, so you 3-bet **more bluffs** (they fold a lot, and when called you're often not dominated). The BB vs BTN grid above already reflects this wide defense; from the **SB vs BTN**, play 3-bet-or-fold: 3-bet TT+, AJs+, AQo+, KQs for value and A5s–A2s/suited-gapper bluffs, and fold the rest (don't flat much OOP).

**The general gradient:** the **wider** villain's open, the **more polarized and bluff-heavy** your 3-betting and the wider you defend overall. The **tighter** villain's open, the **more linear (value-only)** your 3-betting and the tighter you continue.

---

## 5.7 The Exploitative Layer

Adjust off the baselines using reads:

- **Villain folds too much to 3-bets** (high "fold to 3-bet" stat — Chapter 22): **add bluff 3-bets**, even hands without great blockers. Their over-folding makes any 3-bet immediately profitable. This is one of the most lucrative exploits in online 6-max.
- **Villain rarely folds to 3-bets / calls everything:** **cut the bluffs, 3-bet linear for value only**, and size up. You're punished for bluffing a station, but rewarded for value-3-betting a wider, thinner range (e.g., add AJs, KQs, TT–99 as value).
- **Villain opens too wide:** their range is weak, so **3-bet more for value** (you're ahead of more of their range) and flat more speculative hands that flop well against junk.
- **Villain 4-bets aggressively:** your light 3-bets get blown off; **drop the worst bluffs** and 3-bet a more value-weighted range (so you can call/jam over their 4-bets — Chapter 6).
- **Players behind you are loose/aggressive (squeeze-happy):** **flat less, 3-bet or fold more**, because flatting invites a squeeze that puts you in a miserable spot. **Tight players behind:** flatting is safer; you can cold-call more.

> **The leak this chapter fixes most often.** Intermediate players (1) **over-fold the big blind**, surrendering equity they're being paid to defend, and (2) **3-bet too linearly/too rarely**, missing the fold-equity profits available against opponents who fold too much. Learn to defend the BB wide, and learn to add polarized 3-bet bluffs (starting with suited wheel aces) against players who fold to them.

---

## 5.8 Chapter Summary

- Facing an open, you **3-bet, flat, or fold.** Flatting is best **in position** with hands that play well postflop but aren't value-3-bet strength; it's dangerous OOP (invites squeezes, no initiative).
- **Linear 3-bet** = top-down value, no bluffs — use vs. stations and to punish wide opens. **Polarized 3-bet** = value + chosen bluffs (classically **suited wheel aces A5s–A2s**: blockers + playability), excluding medium hands.
- **Position rule:** **3-bet-or-fold and polarize OOP**; **flat wide and 3-bet linear-plus-blockers IP.**
- **Sizing:** **~3× IP, ~4× OOP**; add ~1bb per limper when isolating.
- The **BB defends the widest** of any seat (closes action, great price) — don't over-fold it. The **SB plays 3-bet-or-fold** despite also being OOP, because it doesn't close the action and gets a worse price.
- **Gradient:** wider opens → more polarized/bluff-heavy 3-betting and wider defense; tighter opens → more linear/value-only and tighter defense.
- **Exploit:** more bluff 3-bets vs. over-folders; value-only and size up vs. stations; flat less / 3-bet-or-fold more when squeeze-happy players lurk behind.

**Next:** [Chapter 6 — 4-Bet / 5-Bet & Stacking Off Preflop](06-4bet-5bet.md). When your 3-bet gets re-raised — or when you're the opener facing a 3-bet — the stakes escalate fast. We cover value 4-bets, 4-bet bluffs, the all-in thresholds, and how to avoid spewing stacks preflop.
