# Chapter 23 — Interpreting Actions Street-by-Street

This is the chapter you asked for most directly: **how to interpret villain's actions** and build their range from the story their bets and checks tell. Hand-reading is not magic or "soul reads" — it's a disciplined, repeatable process of starting with a preflop range and **narrowing it at every decision point** based on what each action implies. You did this implicitly throughout the guide; here we make it explicit and systematic. By the end you'll be able to take any line villain shows — "open, c-bet, check turn, bet river big" — and translate it into a concrete range of hands you can then beat or fold to.

This chapter integrates everything: player types (Ch. 21), HUD stats (Ch. 22), board texture (Ch. 8), and the betting logic of Parts III–V.

---

## 23.1 The Core Method: Start Wide, Narrow at Every Node

Hand-reading is a single loop, repeated at each decision point:

1. **Assign a starting range** from the preflop action and villain's type (Ch. 4–7, 21–22). A tight UTG open is ~16% of hands; a loose fish's call is much wider.
2. **At each subsequent action (bet, check, call, raise), ask: "Which hands in their current range take *this* action *here*?"** Remove the hands that wouldn't; keep the hands that would.
3. **Repeat down the streets.** The range shrinks and sharpens each time, until on the river it's small and concrete enough to make a precise decision against.

The discipline is doing this **honestly and consistently** — not anchoring on the first hand you imagine, not ignoring actions that contradict your read, and updating in *both* directions (some actions widen your estimate of their bluffs, others narrow toward value). Let's build the toolkit for step 2: what each action *means*.

---

## 23.2 What Each Action Implies

### Betting / Raising
A bet or raise generally **polarizes or strengthens** a range, but *how* depends on the spot:
- **A small bet** typically means a **wide, merged, or capped** range — range bets, thin value, weak-ish hands wanting a cheap continue, or "I want to see a showdown cheaply" (Ch. 20.2). Less likely to be the nuts.
- **A big bet / overbet** typically means a **polarized** range — strong value or bluffs, little in between. On the river especially, big bets are "I have it or I'm representing it."
- **A raise** (especially check-raise or river raise) is a **strong action** — most players raise a narrow, value-heavy range, particularly when passive. Against a passive player, a raise is the strongest signal in poker; against a maniac, discount it.

### Checking
A check usually means **"not a clear value bet here"** — but it splits into two very different meanings:
- **A check of weakness / capping** — most often, a check (especially the PFR checking back the flop, or checking the turn after barreling) means the range is **capped** (no nutted hands, which would have bet). This is the **green light to attack** (probe, bet, raise) — capped ranges fold a lot (Ch. 10.5, 18.4).
- **A trap check (check to induce/check-raise)** — occasionally a check hides a monster, especially from tricky players or on boards where checking strong hands is correct. Against **passive/straightforward players, checks are almost always weakness**; against **tricky/aggressive players, checks can be traps** — weight by type.

### Calling
A call is the most **range-defining-but-capping** action: it says **"strong enough to continue, not strong enough to raise."** A caller's range is **capped** below the hands that would have raised — they've denied themselves the top of their range. This is why:
- **Cold-callers and flat-callers are capped** (they'd 3-bet/raise the nuts) → attack them with squeezes and barrels (Ch. 7, 9).
- **A call on the flop and turn, then facing a river bet,** means a range of medium-strength made hands and busted draws — often a great spot to **overbet** (their capped range can't profitably continue) or to read for bluff-catching.

> **The "capped vs. uncapped" lens.** The most powerful single question in action-reading: **does this line leave villain's range capped (no nutted hands) or uncapped (the nuts still possible)?** Calls and passive checks usually **cap** a range → you can apply big pressure (overbets, barrels) because they can't have the goods. Raises and big bets keep a range **uncapped/polarized** → proceed with caution and good blockers. Reading cappedness correctly is worth more than any single tell.

---

## 23.3 Reading the Full Line (Putting It Together)

Real reads come from the **sequence** of actions, interpreted against board texture and type. Work through villain's whole story:

**Example 1 — the capped river.** A TAG opens CO, you call BTN. Flop **K♦ 8♠ 3♣**, he c-bets small, you call. Turn **5♥**, he checks, you check. River **2♦**, he bets half pot.
- *Preflop:* CO opening range (~26%).
- *Flop small c-bet on a dry K-high board:* consistent with his whole range (range bet) — doesn't narrow much.
- *Turn check:* **caps him** — with a strong King or better he'd usually bet the turn for value/protection. His turn check says "medium hand or giving up."
- *River bet after checking turn:* a **delayed, capped-range bet** — likely thin value (a weak King, 8x) or a busted-draw bluff. He's very unlikely to have a monster (he'd have bet the turn). → This is a **bluff-catch** spot: call with hands that beat his thin value/bluffs, fold the bottom. His range is capped, so you don't fear the nuts.

**Example 2 — the uncapped barrel.** A nit opens UTG, you call BTN. Flop **Q♥ J♥ 4♠**, he c-bets big, you call. Turn **9♥** (flush completes), he bets big again. River **2♣**, he overbets.
- *Preflop:* nit UTG range (~12%, very strong).
- *Flop big c-bet on a wet board:* strong range — overpairs, sets, big draws.
- *Turn big bet when the flush completes:* his range now includes made flushes (AhKh, etc.), sets, two pair — **uncapped and strong**. A nit barreling a completed flush board is *not* bluffing.
- *River overbet:* from a **nit**, this is the **nuts or near-nuts** almost always. → **Fold everything but a hand that beats his value.** The line screams strength, the type confirms it, and overbets from nits are not bluffs. Don't hero-call.

The contrast between these two examples is the whole skill: **same generic "he bet the river," opposite conclusions**, because the *line* (capping vs. not), the *texture*, and the *type* tell different stories.

---

## 23.4 Combinatorics: Counting the Range (Not Just Naming It)

Naming villain's range ("he has value or bluffs") is step one; **counting the combos** (Ch. 2.7) turns it into a decision. On the river, estimate:
- **How many value combos** does his line credibly contain? (Count them, adjusting for blockers you hold and board cards.)
- **How many bluff combos** does it credibly contain? (Busted draws are countable — how many draws were possible that bricked?)
- **Compare to your pot odds.** If you need to be good 33% (half-pot bet) and his range is ~40% bluffs by combo count, call; if it's ~15% bluffs, fold.

> **Worked count.** River bluff-catch spot: you estimate villain's betting range is **{two-pair+ for value, busted flush draws for bluffs}**. Value: say AQ (you block the A, so fewer combos), sets — count ~8 value combos. Bluffs: the flush draws that bricked — count ~5 combos. That's ~38% bluffs. Facing a half-pot bet (need 33%), it's a **call**. Now suppose you hold a card that **blocks a busted draw** — his bluff combos drop to ~3 (~27% bluffs) → **fold**. Combinatorics + blockers turn "gut feeling" into an actual number you can compare to the price. This is the rigorous core of hand-reading.

---

## 23.5 Common Action-Reading Patterns (Population-Level)

Most opponents follow recognizable, exploitable patterns. Recognize these lines:
- **"Bets flop, gives up turn"** → capped/weak — float and steal the turn (Ch. 10, 18).
- **"Checks back flop, folds turn to a bet"** → capped check-back — **probe-bet** them (Ch. 18.4).
- **"Calls flop, folds turn"** → the one-and-done caller — **double-barrel** relentlessly (Ch. 18, 22).
- **"Limps then calls a raise, check-calls flop"** → weak/capped recreational range — value-bet, don't bluff.
- **"Min-raises the river" (live/low-stakes)** → very often the nuts or near-nuts — most players don't min-raise rivers as bluffs; **fold marginal hands.**
- **"Suddenly bets big after passive line"** → from a passive player, strength; **believe it.**
- **"Donk-bets small into the raiser"** → often a weak/medium hand or a draw wanting to set its own price — read by player type (fish: face-value weak/medium; reg: could be a designed lead).

These patterns are *priors* — strong defaults that the specific opponent's type and stats refine.

---

## 23.6 The Exploitative Layer

- **Weight your reads by player type (Ch. 21).** The *same line* means different things from different types: a turn check is weakness from a nit/passive player but can be a trap from a tricky reg; a river overbet is the nuts from a nit but can be polarized (incl. bluffs) from a LAG. **Always filter the action-read through the type-read.**
- **Against straightforward/recreational players, take actions at face value** — they bet strong with strong hands and check/fold weak with weak hands. Their lines are honest; read them literally and exploit hard.
- **Against tricky/balanced regs, respect deception** — their checks can trap, their small bets can be strong, their lines are designed. Read them by frequencies and balanced ranges, and lean on your baseline.
- **Use blockers in every close read** — the cards you hold change the combo counts and tip bluff-catch/bluff decisions (Ch. 19, 25).
- **Update relentlessly on showdowns** — every revealed hand recalibrates your model of how *this* player bets *this* kind of hand.

> **The leak this chapter fixes.** Two hand-reading leaks: **(1) not narrowing** — playing your own two cards while ignoring the story villain's actions tell, and **(2) reading lines acontextually** — concluding "he bet, he's strong" (or "he might be bluffing") without filtering through cappedness, texture, type, and combo counts. The fix: **start wide, narrow at every node, ask "capped or uncapped?", count the combos against your pot odds, and filter the whole read through the opponent's type.**

---

## 23.7 Chapter Summary

- Hand-reading is a loop: **assign a preflop range, then at every action remove the hands that wouldn't take it and keep those that would** — the range narrows and sharpens down the streets.
- **What actions mean:** **small bet** = wide/merged/capped; **big bet/overbet** = polarized (value or bluffs); **raise** = strong (especially from passive players); **check** = usually weakness/**capped** (attack it) but occasionally a trap from tricky players; **call** = **capped** ("continue but not raise").
- **The master question: capped or uncapped?** Calls and passive checks **cap** a range → apply big pressure (overbets, barrels); raises and big bets keep it **uncapped** → proceed with caution and blockers.
- Read the **whole line** in context of **texture + type**, not single actions — the same "river bet" can be a capped bluff-catch spot or a nutted fold depending on the story.
- **Count combos** (value vs. bluff), adjust for **blockers**, and compare to **pot odds** to convert a named range into an actual call/fold decision.
- Recognize **population line patterns** (bet-flop-give-up-turn, check-back-fold-turn, call-flop-fold-turn, passive-then-big = strength) as exploitable priors.
- **Filter every read through player type:** take recreational players' lines at **face value**; respect **deception** from tricky regs; update on **every showdown**.

**Next:** [Chapter 24 — Tells](24-tells.md), the final reading tool: sizing tells, timing tells, and live physical tells — the extra information layered on top of the action-reading you just learned.
