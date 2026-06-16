# Chapter 22 — HUD Stats & What They Mean

A **HUD** (Heads-Up Display) overlays statistics on each online opponent, computed from their hand history, so you can quantify the tendencies Chapter 21 described qualitatively. Even if you play live or without tracking software, understanding these stats sharpens your thinking — they're a precise vocabulary for "how often does this player do X?" This chapter explains the core stats, what values mean, how they map to player types, the **sample-size** caveat that makes or breaks their reliability, and how to turn the numbers into exploits at the table.

---

## 22.1 The Foundational Preflop Stats: VPIP, PFR, and the Gap

**VPIP (Voluntarily Put £ In Pot)** — the % of hands a player *voluntarily* puts money in preflop (calling or raising; blinds posted aren't voluntary). This measures **looseness/tightness** — the range-width axis.

**PFR (PreFlop Raise)** — the % of hands a player *raises* preflop. This measures **preflop aggression.**

These two are read **together**, and the **gap between them** is as informative as either alone:

| VPIP / PFR | Profile | Type |
|------------|---------|------|
| ~22/19 (small gap) | Tight, aggressive, raises most hands it plays | **Solid TAG / reg** |
| ~28/22 | Slightly loose-aggressive | **LAG-ish reg** |
| ~45/8 (huge gap) | Plays tons of hands, rarely raises → lots of limping/calling | **Calling station / fish** |
| ~12/9 | Very few hands, mostly raised | **Nit** |
| ~40/35 | Plays and raises a ton | **Maniac / aggressive fish** |

> **The VPIP–PFR gap is the fish detector.** A **small gap** (e.g., 22/19) means almost every hand they play, they raise — a sign of a thinking, aggressive player who doesn't limp/cold-call passively. A **large gap** (e.g., 40/8) means they enter many pots by *calling* rather than raising — the signature of a **passive recreational player (a fish)**. The bigger the gap, the fishier (more loose-passive) the player, and the more you should value-bet and avoid bluffing them. Spotting big gaps is how you find the money at the table.

**Reasonable 6-max reg baselines** to calibrate against: roughly **VPIP 22–26, PFR 18–22**. Numbers well above suggest loose; well below suggest nitty; a big gap suggests passive/recreational.

---

## 22.2 3-Bet % and Fold to 3-Bet

**3-Bet %** — how often a player re-raises preflop. Measures preflop aggression at the re-raise level.
- **~5–9%** = a balanced, solid 3-betting range. **Below ~4%** = nitty (only 3-bets premiums → **fold to their 3-bets**, they have it). **Above ~11–12%** = aggressive/light 3-bettor (their 3-bets are bluff-heavy → **4-bet and call wider**, don't fold your decent hands).

**Fold to 3-Bet** — how often a player folds when 3-bet. One of the most directly exploitable stats:
- **High (>65–70%)** → they over-fold to 3-bets → **3-bet them relentlessly as a bluff** (any two cards becomes profitable against a big over-folder).
- **Low (<45%)** → they call/4-bet too much → **3-bet them for value only**, cut the bluffs.

---

## 22.3 The Core Postflop Stats

**C-Bet % (flop continuation bet)** — how often they c-bet the flop as the preflop raiser.
- **Very high (>75%)** → they c-bet too much (lots of air) → **check-raise and float them more**, and **call/raise wider** — their c-betting range is weak.
- **Low (<50%)** → they c-bet selectively → when they *do* c-bet, respect it more.

**Fold to C-Bet** — how often they fold to a flop c-bet.
- **High (>55–60%)** → over-folders → **c-bet them relentlessly** (especially small on dry boards) — free money.
- **Low** → sticky → **value-bet more, bluff less.**

**AF (Aggression Factor) = (bets + raises) / calls**, and the related **Aggression Frequency %** — measure postflop aggression (the passive/aggressive axis).
- **Low AF (~1 or below)** → **passive / calling station** → value-bet thin and big, don't bluff.
- **High AF (~3+)** → **aggressive / LAG-maniac** → bluff-catch wider, value-own them, don't bluff-fight.

**Fold to Turn/River C-Bet (barrel stats)** — how often they fold to second/third barrels.
- **High fold-to-turn** → **double-barrel them relentlessly** (the classic "calls flop, folds turn" fish) — one of the biggest exploits in 6-max.

---

## 22.4 The Showdown Stats: WTSD and W£SD

**WTSD (Went To ShowDown %)** — how often, having seen the flop, they reach showdown. Measures **stickiness/curiosity**.
- **High (>30%)** → **calling station** — they go to showdown a lot → **value-bet thin, never bluff.**
- **Low (<26%)** → they fold a lot before showdown → **bluff/barrel them more.**

**W£SD (Won £ at ShowDown %)** — when they reach showdown, how often they win. Measures **showdown hand quality**.
- **Low (<48%)** → they show up with too many weak hands at showdown (calling stations who call down light) → confirms "value-bet, don't bluff."
- **High (>54%)** → they only get to showdown with strong hands (nits) → their showdowns are strong, so **respect their calls and bet-bluff their pre-showdown folds.**

> **Reading stats in combination, not isolation.** No single stat defines a player — you read the *constellation*. Example: **VPIP 42 / PFR 9 / AF 1.2 / WTSD 34 / W£SD 46** is unmistakably a **loose-passive calling station** (loose VPIP, big gap, low aggression, high showdown, low showdown wins) → **value-bet relentlessly, never bluff, set-mine, isolate them in position.** Another: **VPIP 24 / PFR 20 / 3-bet 10 / C-bet 80 / Fold-to-3bet 50 / AF 3.5** is an **aggressive reg/LAG** → tighten, bluff-catch wider, 4-bet their light 3-bets, don't get into bluff wars. The stats *triangulate* the type from Chapter 21.

---

## 22.5 Sample Size: The Stat That Governs All Stats

The single biggest mistake with HUDs is **trusting small samples.** A stat computed from 20 hands is noise; from 2,000 hands it's signal. Different stats "stabilize" at different sample sizes:

- **VPIP/PFR** stabilize **fast** (~50–100 hands give a usable read) because they're measured on *every* hand.
- **3-bet %, c-bet %, fold-to-c-bet** need **more** hands (a few hundred+) — they're measured only on the subset of hands where the situation arises.
- **Fold-to-3-bet, barrel stats, WTSD/W£SD** need **even more** (hundreds to thousands) — they're rare situations, so the denominator is small for a long time.

> **The sample-size discipline.** Over a small sample, **lean on VPIP/PFR** (which stabilize quickly) and **showdown observations** (which are direct evidence), and treat low-frequency stats (fold-to-3bet, river aggression) as **weak priors**, not facts. The leak is making a big, costly deviation off a stat with a tiny sample — e.g., "his fold-to-3bet is 80%, 3-bet bluff him!" when that's over 5 instances. **Big deviations require big samples; small samples justify only small deviations** toward population defaults.

When you have **no sample**, fall back to **population tendencies** (Chapter 26): the average player at your stake folds too much to c-bets, under-bluffs rivers, over-folds to 3-bets, etc. These pool-wide defaults are your prior until an opponent's stats accumulate enough to override them.

---

## 22.6 Live Poker: HUD-Free Reads

Without tracking software, you build the same picture manually:
- **Count their VPIP/PFR by eye** — are they in lots of pots? Do they raise or limp/call? A few orbits gives a rough read.
- **Bank every showdown** — the strongest evidence of all (you see exactly what hand took what line).
- **Watch sizing and timing** (Ch. 24) — these substitute for stats and often read faster.
- **Use the population default** more heavily, since you can't accumulate stats quickly. Live low-stakes pools are typically **very loose-passive** — value-bet relentlessly and bluff sparingly as your live baseline.

---

## 22.7 The Exploitative Layer (Stat → Action)

A quick-reference mapping from a notable stat to the adjustment:

| Stat reads | Meaning | Exploit |
|------------|---------|---------|
| High VPIP, big VPIP–PFR gap, low AF | Loose-passive station | Value-bet thin/big, never bluff, set-mine |
| Low VPIP/PFR, small gap | Nit | Steal/bluff relentlessly, fold to their aggression |
| High Fold-to-3bet | Over-folds preflop | 3-bet bluff relentlessly |
| Low Fold-to-3bet | Calls/4-bets too much | 3-bet value only |
| High Fold-to-C-bet | Over-folds flop | C-bet/barrel relentlessly |
| High Fold-to-Turn-C-bet | Calls flop, folds turn | **Double-barrel relentlessly** |
| High C-bet % | Over-c-bets (weak range) | Check-raise / float more |
| High AF, high 3-bet | Aggressive LAG/reg | Bluff-catch wider, value-own, 4-bet light 3-bets |
| High WTSD, low W£SD | Curious station | Value-bet, never bluff |

> **The leak this chapter fixes.** Two HUD leaks: **(1) trusting tiny samples** (making big deviations off a handful of hands) and **(2) reading stats in isolation** (fixating on one number instead of the constellation). The fix: **read the cluster of stats together to triangulate the player type, weight each stat by its sample size, lean on fast-stabilizing VPIP/PFR and showdowns early, and fall back to population defaults when the sample is thin.**

---

## 22.8 Chapter Summary

- **VPIP** (looseness) and **PFR** (preflop aggression) are foundational and **stabilize fast**; the **VPIP–PFR gap is the fish detector** (big gap = loose-passive recreational; small gap = aggressive reg). Reg baseline ≈ **22–26 / 18–22**.
- **3-bet %** and **fold-to-3-bet** govern preflop exploits (3-bet-bluff over-folders, value-only vs. low-folders); **low 3-bet = nit (fold to it)**, **high = light (4-bet/call wider)**.
- Postflop: **C-bet %** and **fold-to-c-bet/turn** drive barreling exploits (**double-barrel high-fold-to-turn players**); **AF** is the aggression axis (low = station, high = LAG).
- **WTSD/W£SD** measure stickiness and showdown quality — **high WTSD + low W£SD = station** (value-bet, never bluff).
- **Read stats in combination** to triangulate the Chapter 21 type, never in isolation.
- **Sample size governs everything:** lean on VPIP/PFR and showdowns early; treat rare-situation stats as weak priors; **big deviations need big samples**; fall back to **population defaults** with no sample.
- **Live/HUD-free:** count pot frequency and aggression by eye, bank every showdown, read sizing/timing, and default to the loose-passive live pool.

**Next:** [Chapter 23 — Interpreting Actions Street-by-Street](23-reading-actions.md), the heart of hand-reading: building villain's exact range from the sequence of actions they take, regardless of whether you have stats.
