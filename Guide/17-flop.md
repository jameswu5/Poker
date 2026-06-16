# Chapter 17 — Flop Play

Part V integrates everything from Parts I–IV into **street-by-street decision-making**. We start with the flop, because the flop is where preflop ranges first collide with real cards and where the structure of the whole hand is set. By now you have all the components — board texture (Ch. 8), c-betting (Ch. 9), the caller's toolkit (Ch. 10), and how each hand class wants to be played (Part IV). This chapter assembles them into a single, repeatable flop process you can run on every hand, from all four seats and in heads-up and multiway pots.

---

## 17.1 The Flop Process (Run This Every Hand)

Before you act on any flop, answer five questions in order. They take seconds once habituated and they generate the correct decision.

1. **What are the two ranges?** Your range and villain's range, given the preflop action (who raised, who called, positions). You're not playing two cards — you're playing your range vs. theirs (Ch. 3).
2. **Static or dynamic? Whose range does the board favor?** The two texture questions from Chapter 8. This tells you who has range advantage and nut advantage.
3. **What's my role and position?** Am I the aggressor (PFR) or the caller? In or out of position? This determines whether I'm c-betting (Ch. 9) or using the caller's toolkit (Ch. 10).
4. **Which bucket is my specific hand in?** Value, strong draw (semi-bluff), medium/showdown, or air (Ch. 9.5 / 16.1). This picks my action *within* the strategy from steps 2–3.
5. **Who is the opponent?** The exploitative overlay — adjust frequencies/sizes based on their tendencies (over-folder, station, aggressor, etc.).

Everything below is an application of these five questions to the common flop situations.

---

## 17.2 As the Preflop Raiser, In Position

The most comfortable spot — you have initiative *and* position. Your default is **aggression calibrated to texture**:

- **Range-favoring dry board (A-7-2, K-9-4):** **range-bet small (25–35%), very high frequency**, often your whole range. You have range advantage and shared nuts; bet everything cheaply, deny free cards, and let villain over-fold (Ch. 9.2).
- **Dynamic board where you hold nut advantage (A-K-5 two-tone as 3-bettor):** **polarized, bigger bets**; bet value and strong semi-bluffs large, **check back your medium hands** for pot control and showdown.
- **Caller-favoring board (low/connected, 7-6-5):** **check back much more** — your range advantage is gone. Bet only strong made hands and your best semi-bluffs; check the rest, planning to realize equity in position and take free cards.

Position lets you **check back medium hands and realize their showdown value cheaply** — a key luxury the OOP raiser doesn't have. Use it: don't bet hands that have no good reason to bet just because you raised preflop.

---

## 17.3 As the Preflop Raiser, Out of Position

Harder — you have initiative but not position. The big adjustment from old-school play: **check more, including some strong hands** (build a check-raising range so you're not exploitable).

- **Range-favoring board:** you can still **range-bet small at high frequency** (your range advantage holds regardless of position), but mix in some **checks** — including strong hands — so your check is not purely capped. OOP, a small range bet remains strong on A-high/K-high dry flops.
- **Dynamic / caller-favoring board:** **check a large fraction of your range.** Bet your strongest value and best semi-bluffs (for protection and to start building the pot), and check everything else. Your checks include medium showdown hands (check-call/check-fold) *and* some traps (check-raise candidates), so you're not face-up weak.
- **Avoid the OOP c-bet-and-give-up pattern:** firing a c-bet OOP with a hand that folds to a raise and then check-folding the turn is a leak. If a hand can't continue when raised and won't barrel, **check it on the flop** instead.

> **Why OOP demands more checking.** Out of position, every bet you make can be raised, and you'll face the turn without information. Checking lets you control the pot, realize showdown value, set up check-raises, and avoid bloating pots you'll misnavigate. The PFR's "always c-bet" habit is most punished OOP — that's where disciplined checking earns the most.

---

## 17.4 As the Caller (Facing a C-Bet)

You called preflop; villain c-bets. Run the caller's toolkit (Ch. 10):

- **Anchor on MDF, adjust for the read.** Continue with roughly the defense frequency the bet size demands, then fold more vs. under-bluffers / call wider vs. over-bluffers.
- **Continue with the right hands:** bluff-catchers (showdown value that beats their bluffs), medium made hands (pot control), strong draws (often raise as semi-bluffs), and floats with backup equity (IP).
- **Check-raise** a polarized range (value + semi-bluff bluffs), **especially on boards that favor your range** (the low/connected flops where they over-c-bet) and **vs. high-c-bet-frequency opponents**.
- **Float in position** vs. aggressors who c-bet and give up; **fold the air** that has no equity and no blocker reason to continue.

The caller's flop is mostly about **not being passive** (have a raising range, attack the right boards) while **not over-defending** (fold your true trash, especially OOP).

---

## 17.5 Heads-Up vs. Multiway Flops

**Heads-up** is the assumed case above — one bettor, one caller, full range-vs-range dynamics.

**Multiway (3+ players)** changes the flop sharply (Ch. 9.6, Ch. 27):
- **As the aggressor:** **c-bet much less and mostly for value.** With more opponents, fold equity collapses and someone is more likely to have connected. Bet genuine value (sized to get called by worse from multiple ranges), keep only your strongest semi-bluffs, and **check most marginal hands and air.**
- **As a caller:** ranges are stronger when multiple players are in (the field had more chances to wake up). **Tighten your continuing range**, fold more marginal hands, and respect aggression more — a bet *and* a call ahead of you signals real strength.
- **Bluffing dies multiway.** Pure bluffs need everyone to fold; that's rare. Lean on value and equity, not fold equity.

In 6-max, multiway flops are common enough (limped pots, multiple cold-callers, blind defenses) that having a distinct, tighter multiway flop game is essential.

---

## 17.6 Worked Flop Examples

**Example 1 — PFR, IP, range-favoring board.** You open CO, BTN folds, BB calls. Flop **A♦ 8♣ 3♠**. *Ranges:* your CO range is full of Ax/big pairs; BB's range mostly missed. *Texture:* dry, static, favors you (range + nut advantage). *Role:* PFR, IP. *Action:* **range-bet ~33%** with essentially your whole range — value bets get called by worse Ax/8x, your air has fold equity, and you deny the BB's overcards/backdoors. Exploit: if the BB over-folds A-high flops, this prints with zero risk.

**Example 2 — PFR, OOP, caller-favoring board.** You open from the SB, BB calls. Flop **7♥ 6♥ 4♣**. *Ranges:* your SB range has big cards that whiffed; BB's wide range smashes this (sets, two pair, straights, big draws). *Texture:* wet, dynamic, **favors the BB**. *Role:* PFR, OOP. *Action:* **check most of your range.** Bet only strong made hands (overpairs/sets) and your best semi-bluffs (big draws), and check-call/check-fold the rest. C-betting your whole range here, OOP, into a range that crushes you is a major leak.

**Example 3 — Caller, IP, float spot.** You call a HJ open on the BTN. Flop **K♠ 9♦ 4♥**, HJ c-bets small. *Hand:* you hold **Q♥J♥** (gutshot + backdoor flush + two overcards-ish). *Role:* caller, IP. *Action:* **float (call).** You have backup equity and position; plan to take it away if they check the turn (their small c-bet on a dry board often gives up), or improve to a strong draw/pair. If they barrel big, re-evaluate. This is the caller's toolkit turning a "nothing" hand into a profitable call.

> **The thread through all three.** Each decision falls out of the **five-question process** — ranges, texture, role/position, hand bucket, opponent. You never have to guess; you run the process and the action appears. Memorizing "what to do on every flop" is impossible; running the process makes every flop solvable.

---

## 17.7 Chapter Summary

- Run the **five-question flop process** every hand: **(1)** the two ranges, **(2)** static/dynamic + whose range, **(3)** my role & position, **(4)** my hand's bucket, **(5)** the opponent.
- **PFR, IP:** aggression calibrated to texture — **range-bet small** on range-favoring boards, **polarize big** on dynamic nut-advantage boards, **check back more** on caller-favoring boards; use position to **check back medium hands** for showdown.
- **PFR, OOP:** **check more (including strong hands)** to avoid being run over; bet your strongest value and best semi-bluffs, and don't c-bet-and-give-up.
- **Caller:** anchor on **MDF + read**, continue with the right hands, **check-raise** the boards that favor you and vs. over-c-betters, **float IP**, and fold the true air.
- **Multiway:** **c-bet less and value-weighted, tighten continuing ranges, respect aggression, and abandon most bluffs** — fold equity collapses with more players.
- Decisions **fall out of the process**, not from memorization — ranges + texture + role + bucket + opponent.

**Next:** [Chapter 18 — Turn Play](18-turn.md), where the pot is bigger, ranges are narrower, and the key skill is reading **how each turn card shifts equity** — and choosing which hands to barrel, check, and give up.
