# Chapter 7 — Blind Play & The Squeeze

The blinds are where 6-max is won and lost at the margins. You will play more hands from the blinds than from any other single seat (you're in one of them every orbit), you'll play them **out of position**, and you'll play them with **money already forced into the pot**. As established in Chapter 1, the blinds are net-losing seats — *the goal is to lose less*, by defending correctly, punishing steals, and not spewing OOP. This chapter covers small-blind strategy, disciplined big-blind defense, blind-vs-blind battles, and two plays that mostly live here: the **squeeze** and the **cold-call**.

---

## 7.1 The Small Blind: The Hardest Seat

The SB is the worst seat at the table: half a blind already invested, out of position against everyone, and the BB still lurking behind whenever you enter. Your SB strategy splits into two situations.

### A. Folded to you (raise-first-in)
Covered in Chapter 4.4: open a wide range (~40%) to a **larger size (3–3.5bb)** because you'll be OOP, or use the advanced **limp/raise split** (below). Don't open-limp a weak, face-up range that good BBs will attack.

### B. Facing an open (3-bet-or-fold)
When someone opens and it folds to you in the SB, your default is **3-bet or fold** — *not* flat-calling. Why so little flatting?
- You'd be **OOP** for the whole hand (poor equity realization).
- You **don't close the action** — the BB can squeeze or wake up with a hand and overcall, leaving you in a multiway pot OOP with a capped range.
- Flatting builds a pot you'll play badly; 3-betting at least gives you initiative and fold equity, and folding loses only half a blind.

Here is a baseline **SB 3-bet-or-fold vs. a Button open** (BTN opens wide, so we 3-bet a fairly wide polarized range). **Legend: 3 = 3-bet, · = fold.**

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 3 | 3 | 3 | 3 | 3 | · | · | · | · | 3 | 3 | 3 | 3 |
| **K** | 3 | 3 | 3 | 3 | 3 | · | · | · | · | · | · | · | · |
| **Q** | 3 | 3 | 3 | 3 | 3 | · | · | · | · | · | · | · | · |
| **J** | 3 | · | · | 3 | 3 | · | · | · | · | · | · | · | · |
| **T** | · | · | · | · | 3 | 3 | · | · | · | · | · | · | · |
| **9** | · | · | · | · | · | 3 | 3 | · | · | · | · | · | · |
| **8** | · | · | · | · | · | · | 3 | 3 | · | · | · | · | · |
| **7** | · | · | · | · | · | · | · | 3 | 3 | · | · | · | · |
| **6** | · | · | · | · | · | · | · | · | · | 3 | · | · | · |
| **5** | · | · | · | · | · | · | · | · | · | · | 3 | · | · |
| **4** | · | · | · | · | · | · | · | · | · | · | · | · | · |
| **3** | · | · | · | · | · | · | · | · | · | · | · | · | · |
| **2** | · | · | · | · | · | · | · | · | · | · | · | · | · |

**As text (SB vs. BTN open, ~3-bet-or-fold):**
- **Value:** 77+, ATs+, KTs+, QTs+, JTs, AJo+, KQo
- **Bluffs:** A5s–A2s (wheel-ace blockers), T9s, 98s, 87s, 76s, 65s, 54s (suited connectors)
- **Fold:** everything else — including the middling suited aces (A6s–A9s) and small pairs, which flat poorly OOP and aren't ideal 3-bet hands. Against a *tighter* opener (UTG/HJ), 3-bet a tighter, more value-weighted version of this.

> **When flatting in the SB is acceptable.** Against a **small open from a tight player when the BB is passive** (unlikely to squeeze), you can occasionally flat strong-but-not-3-bet hands (e.g., a pair to set-mine, or a hand that dominates their range). But treat flatting OOP as the exception. The more aggressive the BB behind you, the more strictly you should play 3-bet-or-fold.

### C. The advanced limp/raise SB strategy
Solvers, when folded to the SB, often use a **mixed limp + raise** strategy rather than pure raise-first-in: open-*raise* a polarized range (premiums + some bluffs) and open-*limp* a wide set of medium/speculative hands to keep the pot small while OOP. It's theoretically strong and denies the BB easy reads, but it's **hard to play well** (you'll face raises over your limps and play a lot of tricky OOP pots). Recommendation: **master raise-first-in first**; add the limp strategy only once your postflop OOP game is solid and you're facing tough BBs who exploit a pure-raise SB.

---

## 7.2 The Big Blind: Defend Wide, but Skillfully

The BB is unique: you **close the preflop action** and get a **discounted price** (you've already posted a full blind). That combination means the BB **defends wider than any other seat** — and under-defending the BB ("folding too much from the big blind") is one of the most common and expensive leaks in 6-max. The Chapter 5 BB-vs-BTN grid is the model; here are the governing principles.

**Adjust your defense by the opener's position and size:**
- **vs. late opens (CO/BTN/SB):** their range is wide and weak, so **defend very wide** — flat a huge range and 3-bet a polarized one. vs. a min-open or small open, defend even wider (better price).
- **vs. early opens (UTG/HJ):** their range is strong, so **defend tighter** and **3-bet more linearly** (value-leaning). You're getting a price, but their range punishes loose defends.
- **vs. larger open sizes:** defend **tighter** (worse price → you need more equity to continue).

**Defending = flat *or* 3-bet, not just call.** A correct BB strategy mixes a wide flatting range (closing the action lets you see flops cheaply with speculative hands) with a polarized 3-betting range (value + suited-wheel-ace/suited-connector bluffs). Don't *only* flat — that makes you exploitable (the opener c-bets relentlessly into your capped, passive range).

> **Defending wide ≠ playing badly postflop.** The reason to defend wide is the price, but you're still **OOP with a wide, somewhat weak range** against the aggressor. That means: don't overplay marginal made hands, use your range advantage on the boards that favor *you* (low/connected flops that smash your wide defending range — Chapter 3.4), check-raise and check-call appropriately, and be willing to fold when you whiff against continued aggression. Wide *preflop* defense is paired with *disciplined, board-aware* postflop play. We develop OOP postflop play fully in Chapter 10.

---

## 7.3 Blind vs. Blind (SB vs. BB)

When it folds to the SB and the SB enters, it's a **blind-vs-blind (BvB)** battle — its own dynamic:
- The **SB** is the aggressor but **OOP**; the **BB** is the defender but **in position** (BB acts after SB postflop). This is the one spot where the "in/out of position" and "aggressor/defender" roles invert relative to normal.
- **SB strategy:** with position-disadvantage, favor **raising (not limping) a wide range** to a slightly larger size, or the limp-heavy mixed strategy. Avoid bloating pots OOP with marginal hands.
- **BB strategy:** you're **in position** against a wide SB range, so **defend extremely wide** (flat a ton, 3-bet polarized) — the SB's range is weak and you have position, a great combination. BvB is a high-variance, wide-range, aggressive battle; players who are uncomfortable in marginal spots tend to either over-fold (exploitable) or spew. Play it actively but with discipline.

---

## 7.4 The Squeeze Play

A **squeeze** is a 3-bet made *after* an opener **and one or more callers** have already entered the pot. ("Squeeze" because you trap the cold-callers between you and the original raiser.) It's one of the most profitable aggressive plays in 6-max, and it most often comes from the blinds (where the action reaches you last with dead money in the middle).

**Why squeezing is so strong:**
1. **Dead money.** The opener's raise *and* the caller(s)' calls are already in the pot — more reward for a successful steal than a normal 3-bet.
2. **The cold-caller is capped.** A player who merely *flatted* the open has, by definition, **denied themselves the strongest hands** (they'd usually 3-bet AA/KK/AK). Their range is capped and full of medium hands that hate facing a re-raise — they fold a lot.
3. **The opener is squeezed too.** The original raiser must now continue *into a re-raise with a caller still behind them*, which is uncomfortable; they fold much of their opening range.

**Squeeze sizing:** larger than a normal 3-bet, because you're discouraging *multiple* players and there's more dead money to claim. A good rule: **3-bet to ~4× the open IP / ~5× OOP, plus ~1bb for each cold-caller.** Example: CO opens 2.5, BTN calls, you're in the BB → squeeze to roughly **12–14bb** (4–5× plus one caller). Err on the larger side OOP and against sticky players.

**Squeeze range (polarized):** value (QQ+, AK, and strong hands that want a big pot) + **bluffs with blockers** (suited wheel aces A5s–A2s as ever, plus some suited broadways/connectors). Skew **more value-heavy** when the callers are sticky (won't fold), **more bluff-heavy** when they're capped-and-foldy.

**Best squeeze targets:** a **wide late-position open + a loose, capped flat from a recreational player**. That combination maximizes both the dead money and the fold equity. Be more cautious squeezing when the cold-caller could be trapping (e.g., a tricky reg who flats AA/KK) or when stacks are short.

> **Don't over-squeeze, and beware the cold-call trap.** The squeeze's power depends on the caller being *capped*. Against a player who deliberately flats strong hands (AA/KK) to trap, or against opponents who won't fold, squeeze bluffs lose value fast. Use the play against capped, foldy ranges — which, fortunately, is what most cold-callers have.

---

## 7.5 The Cold-Call (Flatting with Players Behind)

A **cold-call** is flatting an open when you are *not* in the blinds and have *not* yet invested — i.e., calling a raise with players still to act behind you. It's the riskier cousin of flatting because of **squeeze exposure**: anyone behind you can re-raise and put you in a bad spot.

**Cold-call only when:**
- You're **in position** on the opener (e.g., BTN flatting a CO open) — position offsets the risk.
- The **players behind are tight/passive** (low squeeze risk). Against squeeze-happy aggressors behind, **3-bet or fold instead**.
- Your hand **plays well as a flat**: pairs that set-mine profitably (deep enough stacks, opponent who pays off), suited broadways and connectors that flop strong and disguise well — hands too good to fold but not ideal to 3-bet for value.

**Avoid cold-calling** out of position, with aggressive players behind, or with dominated offsuit hands (reverse-implied-odds traps — Chapter 2.5). When in doubt with players left to act, the cleaner choice is usually **3-bet (for value or as a polarized bluff) or fold**, reserving flats for position and quiet tables.

---

## 7.6 The Exploitative Layer

- **BB over-folds (high fold-to-steal):** attack their blind relentlessly from the SB/BTN/CO — widen your steals toward *any two cards* against a BB that surrenders too often.
- **BB defends too wide / calls and plays fit-or-fold:** c-bet more and barrel more postflop; they pay off your value and fold the flop too much.
- **SB is a passive limper / weak OOP:** isolate their limps (raise them) and attack their blind; they bleed chips OOP.
- **Opponents don't respect squeezes (fold too much to them):** squeeze wider and more often, especially against the open-then-loose-flat pattern. **Opponents who never fold to squeezes / trap with flats:** squeeze for **value only** and stop bluff-squeezing.
- **Aggressive squeezers behind you:** stop cold-calling; tighten into 3-bet-or-fold so you're not repeatedly squeezed off equity.

> **The leak this chapter fixes most often.** Two big ones: (1) **over-folding the big blind** — surrendering a seat you're being paid to defend; and (2) **flat-calling too much from the small blind** instead of playing 3-bet-or-fold, which creates a stream of awful OOP, capped, multiway pots. Defend the BB wide and disciplined; play the SB as 3-bet-or-fold; and add the squeeze as a weapon against capped cold-callers.

---

## 7.7 Chapter Summary

- The blinds are **net-losing, OOP, forced-investment** seats — the goal is to **lose less** via correct defense and punishing steals.
- **Small blind:** raise-first-in wide to a **larger size** when folded to; play **3-bet-or-fold** when facing an open (don't flat OOP into a live BB). The **limp/raise split** is a strong but advanced alternative.
- **Big blind:** **defend wider than any seat** (you close the action and get a price), mixing a wide flat with a polarized 3-bet — but pair wide *preflop* defense with **disciplined, board-aware** postflop play. Don't over-fold the BB.
- **Blind vs. blind:** roles invert (SB = OOP aggressor, BB = IP defender); BB defends *very* wide with position over a weak SB range.
- **Squeeze** = 3-bet over an open **+ caller(s)**. Powerful because of **dead money**, the **capped cold-caller**, and pressure on the opener. Size **bigger** (~4–5× + ~1bb/caller), keep it **polarized**, and target **capped, foldy** callers — not trappers.
- **Cold-call** (flat with players behind) only **in position, vs. passive tables, with hands that flat well**; otherwise prefer **3-bet or fold** to dodge squeezes.
- **Exploit:** hammer over-folding blinds, barrel fit-or-fold BB defenders, squeeze wider vs. those who don't fight back, and tighten to 3-bet-or-fold when aggressive squeezers sit behind you.

**This completes Part II (Preflop).** You now have a full preflop game: opening (Ch. 4), responding to opens (Ch. 5), the 4-bet/5-bet ladder (Ch. 6), and blind play with squeezes and cold-calls (Ch. 7).

**Next:** [Chapter 8 — Board Texture](08-board-texture.md) begins **Part III (Postflop Fundamentals)**, where preflop ranges meet the flop and we learn to read which boards favor whom — the foundation for all c-betting and postflop decisions.
