# Chapter 10 — Playing as the Caller

Half the time you reach a flop, you're *not* the preflop raiser — you called an open or a 3-bet, and now you're the **caller** facing a bettor with initiative. This is the harder role: you're usually out of position, your range is a bit weaker, and the aggressor gets to apply pressure. But "caller" does not mean "passive victim." Good callers have a full toolkit — **defending, floating, raising, donking, and probing** — that turns a reactive seat into an aggressive, profitable one. This chapter teaches that toolkit and the defense math behind it.

We'll mostly assume you're the **BB or a cold-caller who flatted** an open, facing a flop c-bet. The same principles apply, mirrored, when you're in position as the caller.

---

## 10.1 The Defender's Mindset: MDF, but with Judgment

Recall **MDF** (Chapter 2.6): to stop the bettor from auto-profiting with any-two-cards bluffs, you must continue (call or raise) with at least `pot / (pot + bet)` of your range. Against a half-pot c-bet, that's ~67% of the hands you reach the flop with; against a small 33% range bet, ~75%.

But MDF is the **GTO baseline, not gospel**:
- Against **under-bluffers** (most players, who c-bet too much for value and not enough as bluffs), you should **fold more than MDF** — defending to MDF against someone who only value-bets just donates chips.
- Against **over-bluffers** (maniacs, relentless auto-c-betters), you **defend beyond MDF** — call and raise wider because their betting range is full of air.

So the defender's process is: **(1)** start from MDF as an anchor, **(2)** read the bettor's bluff-to-value tendency, **(3)** deviate. And crucially — *defend with the right hands*, not just the right quantity. Which hands continue, and how (call vs. raise), is the rest of this chapter.

---

## 10.2 Defending by Calling: What to Continue With

When you call a c-bet (rather than raise or fold), you want hands that:

1. **Have showdown value worth protecting** — pairs (even middling), ace-high that beats bluffs, hands that can win unimproved.
2. **Have equity to improve** — draws and overcards that can hit a strong hand on later streets (these often prefer raising, but calling keeps your range robust and your flatting range protected).
3. **Realize equity reasonably** — in position, you can call wider (you'll see free cards and control the pot); out of position, calling is harder and you fold more / raise more of your continues.

**Prefer calling (over raising) with:**
- **Medium-strength made hands** that want to get to showdown but don't want to bloat the pot (second pair, weak top pair) — these are **bluff-catchers**.
- **Marginal draws** you don't want to commit big with, when the price is good.
- Hands that **block the bettor's value** and beat their bluffs — ideal bluff-catchers.

**A note on bluff-catching:** a bluff-catcher is a hand that **beats the bettor's bluffs but loses to their value**. Whether to call with one is purely a function of the bettor's bluff frequency vs. the pot odds — *not* the absolute strength of your hand. Calling K-high or second pair as a bluff-catcher is correct against someone who over-bluffs and wrong against someone who never does. Hold-em is full of "I have a weak hand but it's the right call" and "I have a decent hand but it's the right fold" — bluff-catcher math, not hand-pride, decides.

---

## 10.3 Defending by Raising: The Check-Raise and Float-Raise

Raising the c-bet (a **check-raise** when OOP, or a raise IP) is the aggressive defense. It does three things: builds a pot with your value, generates fold equity with your bluffs, and **denies the bettor the cheap initiative** of a small c-bet.

**Raise (check-raise) with a polarized range:**
- **Value:** strong made hands that want to build a pot and charge draws — sets, two pair, strong top pairs, sometimes overpairs. Especially on **caller-favoring boards** (low/connected) where *you* have the nut advantage, check-raising for value is premium.
- **Bluffs / semi-bluffs:** your strong draws (flush draws, open-enders, combo draws) and hands with backdoor equity + blockers. These raise as **semi-bluffs** — fold equity now, equity when called.

**When check-raising shines:**
- On **boards that favor your range** (the low/connected flops where the PFR over-c-bets out of habit). They're betting into a range that crushes them; punish it.
- Against **players who c-bet too often** (high c-bet %) — their wide, weak betting range can't withstand a raise, so your check-raises (value *and* bluff) print.
- To **deny the equity** of the bettor's overcards/draws and seize initiative.

> **Don't only check-call.** A defender who *only* calls c-bets (never check-raises) is exploitable: the bettor can c-bet relentlessly, barrel turns into a capped, passive range, and never fear a raise. You must have a **check-raising range** — value + semi-bluff bluffs — to keep the aggressor honest. Even a modest check-raise frequency forces them to bet more cautiously.

---

## 10.4 Floating

A **float** is calling a bet with a weak or marginal hand — *not* primarily for its current showdown value, but with the **plan to take the pot away on a later street** when the aggressor gives up. Floating is fundamentally an **in-position** play (you need position to apply the pressure later and to control the pot).

**Float when:**
- You're **in position** against an aggressor who **c-bets a lot but gives up on turns** (the classic "c-bet and surrender" pattern).
- You have a hand with **some equity/backup** (a backdoor draw, an overcard, a gutshot) so you're not drawing dead if your steal gets called — a pure air float is riskier.
- The board and your hand let you **credibly represent strength** on likely turn cards.

**The float plan:** call the flop → when the aggressor checks the turn (showing weakness), **bet** and take it down; if they barrel again, re-evaluate (you usually fold the pure floats, continue with the ones that picked up equity). Floating is how position-savvy players punish the over-c-bet/under-barrel tendency that's extremely common at low and mid stakes.

> **Float vs. raise.** Both attack the aggressor, but: **raise** when you want to commit now (strong value or strong semi-bluff, or vs. someone who folds to raises), and **float** when you'd rather keep the pot small, keep their bluffs in, and let them barrel off or give up — taking it away later in position. Floating keeps your calling range robust and disguises your strong hands too.

---

## 10.5 Donk-Betting and Probe-Betting (Leading Out)

Normally the preflop raiser bets and the caller responds. **Leading** (betting into the aggressor when you're the caller) reverses that — and there are two distinct versions.

### Donk-bet (leading into the flop c-bet)
A **donk bet** is leading the *flop* into the preflop raiser (betting before they get to c-bet). It's named after the play many *bad* players make, but it has legitimate, narrow uses:
- On boards that **sharply favor the caller's range** (very low/connected flops that smash a wide BB range — e.g., you defended BB and the flop is 6-5-4), a small donk lead can be correct because *you* now have the range/nut advantage and want to start building the pot or denying the PFR a free check-back.
- Use it **rarely and with a plan** — most of the time, check to the raiser is still correct because they'll c-bet and you keep your range protected. An unbalanced, frequent donk-bettor is easy to read and exploit. Reserve donking for the specific caller-favoring textures where it's justified.

### Probe-bet (leading the turn after the PFR checks back the flop)
A **probe bet** is leading the *turn* after the aggressor **checked back the flop**. When the PFR checks the flop, they've shown weakness and **capped their range** (strong hands usually bet). The turn probe attacks that capped range:
- Bet the turn with **value** (you can get called by their medium hands) and **bluffs** (their capped range folds a lot).
- Probing is a high-value play because the flop check-back is such a strong tell of weakness. Many players check back flop and then over-fold turns to a lead — exactly the spot a probe exploits.

> **The unifying idea behind leading.** You lead (donk or probe) when **you have a range advantage that the normal "check to the aggressor" flow wouldn't let you exploit** — either because the board crushed your range (donk) or because the aggressor's flop check capped them (probe). Don't lead just to "do something"; lead when the range math says *you're* now the favorite and want to drive the pot.

---

## 10.6 Out-of-Position Play: The Hardest Part

Most of your calling happens OOP (defending the blinds). OOP, you can't float as freely (no positional pressure) and you'll face tough turn/river spots. Principles:

- **Check-call and check-raise more; bet-lead less.** Your default is to check to the aggressor, then call or raise based on the buckets above. Build a check-raising range so you're not purely passive.
- **Use range/board advantage when you have it.** On the low/connected boards that favor your wide defending range, you become the aggressor (check-raise, donk on the right textures) — this is where OOP defending turns profitable.
- **Pot-control your medium hands.** Check-call to showdown rather than bloating pots you'll misnavigate OOP. Many of your defends are bluff-catchers — play them as such.
- **Fold turns and rivers without shame.** Defending wide preflop and on the flop means you'll often whiff and have to surrender to continued aggression. That's correct — the profit was in seeing the flop cheaply and continuing when you connected, not in heroically calling down every time.

---

## 10.7 The Exploitative Layer

- **vs. over-c-betters who give up turns:** **float in position** relentlessly and **check-raise** more — they bet too much air and surrender.
- **vs. players who barrel relentlessly (multi-street aggressors):** call down lighter / wider (defend beyond MDF) with bluff-catchers — their betting range is too bluff-heavy.
- **vs. under-bluffers (most players):** **over-fold** — drop your weak bluff-catchers; they're not bluffing enough to make calls pay.
- **vs. players who never check-raise or donk get respected:** when *you* lead or check-raise as a bluff, they over-fold — so add bluffs to your raising/leading ranges against them.
- **vs. fit-or-fold callers when you're IP:** if *they're* the passive caller and you're the aggressor, this chapter is your opponent's manual — exploit them by c-betting and barreling (Chapter 9).

> **The leak this chapter fixes.** The two big caller leaks are **(1) pure passivity** — only ever calling or folding, never check-raising/floating/probing, which lets aggressors run you over — and **(2) calling too much OOP** with hands that aren't bluff-catchers, then bleeding off on later streets. The fix: defend the right *quantity* (MDF, adjusted by reads) with the right *hands*, and use the **whole toolkit** — call, check-raise, float, donk, probe — to make the caller's seat an active, aggressive one.

---

## 10.8 Chapter Summary

- Start defense from **MDF** as a baseline, then **deviate**: fold more vs. under-bluffers, call/raise more vs. over-bluffers. Defend the right **quantity** *and* the right **hands**.
- **Call** with bluff-catchers (beat bluffs, lose to value), medium made hands (pot control), and marginal draws — bluff-catching is decided by the **bettor's bluff frequency vs. pot odds**, not hand pride.
- **Raise / check-raise** a **polarized** range (value + semi-bluff draws), especially on **caller-favoring boards** and **vs. over-c-betters**. Always have a check-raising range — don't be purely passive.
- **Float** (call now, take it later) is an **in-position** play vs. aggressors who **c-bet and give up**; prefer floats with backup equity.
- **Donk-bet** rarely, only on **boards that crush your range**; **probe-bet** turns after the PFR **checks back** (capped range) — high-value attack on shown weakness.
- **OOP:** check-call/check-raise more, pot-control medium hands, attack the boards that favor you, and **fold later streets without shame** when you whiff.
- **Exploit:** float/check-raise vs. over-c-betters, call down wide vs. relentless barrelers, over-fold vs. under-bluffers, and add bluffs to your raises/leads vs. players who over-respect them.

**This completes Part III (Postflop Fundamentals).** You can now read board texture (Ch. 8), bet as the aggressor (Ch. 9), and play the full toolkit as the caller (Ch. 10).

**Next:** [Chapter 11 — Premium Pairs & AK/AQ](11-premium-hands.md) opens **Part IV (How to Play Each Hand Type)**, where we apply all of this to specific hand classes — starting with your biggest hands.
