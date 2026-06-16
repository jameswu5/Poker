# Chapter 19 — River Play

The river is poker distilled. There are no more cards to come, so **equity is binary** — your hand is either the best or it isn't, and there's nothing left to draw to. Every hand is now either **value** (you want to get called by worse), a **bluff** (you want better hands to fold), or a **bluff-catcher** (you beat bluffs but lose to value). The river is where pots are won and lost in their largest amounts, where the math of **polarization, value-to-bluff ratios, and blockers** from Chapter 2 finally pays off, and where the discipline of folding and the courage of bluffing are tested most. This chapter covers value betting (including thin value), bluffing, and bluff-catching on the final street.

---

## 19.1 The River Trichotomy

On the river, every hand you hold is exactly one of three things. Identifying which is the entire game:

1. **Value** — you have a hand that **beats enough of villain's calling range** that betting and getting called shows a profit. You bet to **get called by worse**.
2. **Bluff** — you have a hand that **can't win at showdown** (or only beats other bluffs). You bet to **make better hands fold**, or you check and give up.
3. **Bluff-catcher** — you have a hand that **beats villain's bluffs but loses to their value bets**. You don't bet it (worse folds, better calls); you **check and decide whether to call** based on villain's bluff frequency.

The cardinal river errors all come from mis-sorting: **betting a bluff-catcher** (turning a hand that beats bluffs into one that only gets called by better), **calling with a bluff** (a hand that beats nothing villain bets), or **checking back clear value** (missing a bet worse hands would have paid). Sort correctly first; everything else follows.

---

## 19.2 Value Betting and Thin Value

You bet for value when **worse hands will call often enough to profit**. The key river value skills:

- **Bet a size worse hands will pay.** A value bet is only as good as what calls it. Against a station, bet bigger (they call); against a nit, sometimes bet smaller to get a crying call from a marginal hand. The right size is the one that **maximizes (call frequency × amount)** from worse hands.
- **Thin value** is betting a *medium-strength* hand for value when worse hands still call enough to profit — e.g., betting second pair on the river against a player who calls with ace-high and bottom pair. Thin value is a major edge against **calling stations** (who pay off light) and a trap against **tough/aggressive players** (who only call/raise with better, or check-raise bluff you). The art is **knowing how light villain calls** — thin value prints against loose callers and burns against tight ones.
- **Don't check back clear value out of fear.** Many players check rivers with hands that would get called by worse, leaving money on the table. If worse hands call, **bet** — passive river play with good hands is a quiet, chronic leak.

> **The thin-value heuristic.** Ask: "What worse hands can call?" If the answer is "several, and this villain calls with them," bet — even with a medium hand. If the answer is "almost none — worse folds, better calls," check (it's a bluff-catcher or a give-up, not a value bet). Thin value is *opponent-dependent*: the same second pair is a value bet vs. a station and a check vs. a nit.

---

## 19.3 River Bluffing: Polarization, Ratios, and Blockers

River bluffs are pure — no equity, just fold equity. To bluff profitably you need villain to fold often enough (the **alpha** from Ch. 2.6), and to stay unexploitable you need the right **value-to-bluff ratio**:

| Your bet size | Value : Bluff | Bluff % of betting range |
|---------------|---------------|--------------------------|
| 1/2 pot | 2 : 1 | ~33% |
| 2/3 pot | 1.7 : 1 | ~37% |
| Full pot | 1 : 1 | ~50% |
| 2× pot overbet | 0.5 : 1 | ~67% |

**Bigger bets allow (and require) more bluffs** — an overbet can be more than half bluffs and still be unexploitable, because the size makes villain's bluff-catchers indifferent.

**Choosing river bluffs — blockers are king.** With no equity to differentiate them, your bluff candidates are separated almost entirely by **blocker value**:
- **Block villain's value (calling) range.** Bluff with hands that hold cards making villain's strong hands less likely. Classic: on a flush-completing river, bluff with the **ace of the flush suit** — you block the nut flush, so villain is less likely to hold a hand that calls. Holding a key card to their straights/sets/two pairs does the same.
- **Unblock villain's folding (bluff/missed-draw) range.** Don't bluff with cards that make villain's *folding* hands less likely. If you block the busted draws they'd fold, your bluff gets called more.
- **Bluff your worst hands, not your bluff-catchers.** Turn your **busted draws and stone-cold air** into bluffs (they can't win at showdown anyway). Don't bluff a hand with showdown value — check it and win sometimes, or bluff-catch with it.

> **A busted draw is a bluff, not a bluff-catcher.** This bears repeating because it's the most common river confusion. When your flush draw bricks, it can **beat only other busted draws** — so *calling* with it is almost always wrong (you can't beat a value bet, and the only worse hands aren't betting). But it makes a fine **bluff** if it blocks villain's value and unblocks their folds. So: **busted draws bet (as selected bluffs) or check-fold — they almost never call.**

---

## 19.4 River Bluff-Catching

When villain bets the river and you hold a bluff-catcher (beats bluffs, loses to value), calling is a pure function of **villain's bluff frequency vs. your pot odds** — *not* your hand's absolute strength:

- **The math:** if villain bets half pot, you need to be good **~33%** of the time to call (you're getting 3:1 — Ch. 2.3). If villain's betting range is more than ~33% bluffs, call; if less, fold. Your specific bluff-catcher's strength (second pair vs. ace-high) barely matters *if they all beat the same bluffs and lose to the same value* — what matters is **villain's ratio**.
- **Most players under-bluff rivers** (they bet value and give up air), so the population default is to **over-fold** river bluff-catchers relative to MDF. Hero-calling a passive player's river bet is usually -EV.
- **Use your own blockers to decide close spots.** If your bluff-catcher **blocks villain's value** (e.g., you hold a card that makes their nut hands less likely), call more; if you **block their bluffs** (your card makes their busted draws less likely), fold more. Blocker-aware bluff-catching is what separates good river calls from coin-flips.
- **Pick one bluff-catcher and stick to it.** Among several equivalent bluff-catchers, calling with all of them over-defends; the right move is to call the ones with the best **unblocker/blocker profile** and fold the rest, defending to the correct *frequency*.

> **The bluff-catch discipline.** Calling the river with a bluff-catcher is right when **villain bluffs more than your price requires** and your card **blocks their value / unblocks their bluffs**. It's wrong against under-bluffers, and it's wrong when your blockers point the other way. "He might be bluffing" is not a reason to call; "his range here is more than X% bluffs, and I unblock his bluffs" is.

---

## 19.5 Position on the River

- **In position**, you act last with perfect information: you can **value-bet** when checked to, **bluff** the cards/blockers that favor it, or **check back** your bluff-catchers and give-ups to realize showdown value. Position maximizes river EV — you never face a bet without seeing villain's action first.
- **Out of position**, you choose between **betting** (value or bluff), **check-calling** (bluff-catch), and **check-folding**. A key OOP tool is the **check-raise** (rare but powerful) for value and as an occasional polarized bluff. OOP, lean toward **checking your bluff-catchers** (let villain bluff into them) rather than betting them (which folds out worse and gets called by better). Avoid the OOP leak of "blocker-betting" your bluff-catchers into a range that only continues when it beats you.

---

## 19.6 The Exploitative Layer

- **vs. calling stations:** **value-bet relentlessly and thinly, bet bigger, and never bluff.** They pay off light and don't fold — extract maximum thin value, abandon all bluffs.
- **vs. under-bluffers (most players):** **over-fold your bluff-catchers** (they're not bluffing) and **bluff more** yourself (they over-fold) — but only with good blockers.
- **vs. over-bluffers / aggressive players:** **bluff-catch wider** (call down with your bluff-catchers — their betting range is bluff-heavy) and **bluff less** (they don't fold). Consider check-raising as a trap.
- **vs. players who don't fold to overbets:** value-overbet your nutted hands (they call too wide) and drop overbet bluffs.
- **vs. tough regs:** lean on **balanced ratios and blocker-perfect bluff/bluff-catch selection** — they punish imbalance, so size your value:bluff correctly and choose blockers precisely.

> **The leak this chapter fixes.** Two big river leaks: **(1) hero-calling under-bluffers** with bluff-catchers ("he might have it" → he does), and **(2) checking back / under-betting clear value** out of timidity, plus the subtler **(3) calling with busted draws** and **bluffing hands that had showdown value.** The fix: **sort every river hand into value / bluff / bluff-catcher, value-bet (even thin) what worse hands call, bluff your worst hands with the best blockers at the right ratio, and bluff-catch only when villain bluffs enough and your blockers agree.**

---

## 19.7 Chapter Summary

- On the river, **equity is binary** — every hand is **value** (bet to get called by worse), a **bluff** (bet to fold out better, or give up), or a **bluff-catcher** (beats bluffs, loses to value — check and decide to call). **Sort correctly first.**
- **Value-bet** a size worse hands will pay; pursue **thin value** vs. loose callers (opponent-dependent — prints vs. stations, burns vs. nits); **don't check back clear value.**
- **Bluffing:** keep the right **value-to-bluff ratio** for your size (bigger bets → more bluffs allowed); choose bluffs by **blockers** — **block villain's value, unblock their folds, and bluff your worst hands.** A **busted draw is a bluff, not a bluff-catcher.**
- **Bluff-catching** is **villain's bluff frequency vs. pot odds**, not hand strength; **over-fold vs. under-bluffers**, and use **blockers/unblockers** to decide close spots.
- **Position:** IP, value-bet/bluff/check-back with full information; OOP, lean to **check-calling bluff-catchers** and reserve check-raises for value + occasional polarized bluffs.
- **Exploit:** thin-value-bet and never bluff stations; over-fold + bluff more (good blockers) vs. under-bluffers; call wide + bluff less vs. over-bluffers; balance precisely vs. regs.

**Next:** [Chapter 20 — Bet Sizing Theory](20-bet-sizing.md), which unifies the sizing decisions scattered across every street — small bets, big bets, overbets, geometric sizing — and how size both reveals and disguises range.
