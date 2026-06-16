# Chapter 9 — C-Betting

The **continuation bet** (c-bet) is a bet made on the flop by the preflop raiser — you "continue" the aggression you started preflop. It's the most frequent postflop action in the game, and it's where most players either print money or quietly bleed it. The modern, solver-informed approach to c-betting is not "always bet because I raised" (the old leak) — it's a precise function of **board texture, range advantage, nut advantage, position, and opponent**. This chapter turns the texture-reading from Chapter 8 into a concrete c-betting strategy: *whether* to bet, *how often*, *what size*, and *with which hands*.

---

## 9.1 Why We C-Bet (Three Goals)

Every c-bet serves one or more of three purposes. Knowing *which* goal you're pursuing tells you the size and which hands to bet.

1. **Value** — get called by worse hands and build a pot with your strong holdings (top pair, overpairs, sets).
2. **Denial / protection** — make hands with equity (overcards, draws) fold, so they don't realize their share. Betting K-7-2 with a hand like A-Q denies the overcards' equity *and* the gutshots/backdoors.
3. **Fold equity / bluffing** — win the pot now with hands that don't want a showdown, leveraging your range and position.

A bet can pursue several at once (a c-bet with top pair gets *value* from worse pairs/draws *and* denies overcard equity). The mistake is c-betting with **no clear goal** — betting a medium hand that folds out worse and gets called by better achieves nothing and just bloats a pot you'll struggle to navigate.

---

## 9.2 The Two C-Bet Strategies: Range Betting vs. Polarized Betting

Modern c-betting splits into two distinct approaches, chosen by **board texture**.

### Range betting (small, high frequency)
On boards that **strongly favor your range** (dry, high/broadway, static — e.g., A-7-2, K-9-4), you can bet a **small size (25–40% pot) with a very high frequency — often your entire range**. This is "range betting."

- **Why it works:** almost every hand in your range benefits. Your strong hands get value, your air has fold equity against a range that mostly whiffed, and the small size risks little while still applying pressure and **denying the caller a free card**. Because you're betting your whole range, you're perfectly balanced by default — villain can't exploit you, because you have it all.
- **Sizing logic:** small, because you don't need a big bet to fold out a range that has few strong hands or draws, and a small bet lets you bet *everything* cheaply. Range advantage without a big nut advantage → **bet small, bet wide** (Chapter 3.5).

### Polarized betting (big, selective frequency)
On boards where you have **nut advantage but the board is more dynamic** (e.g., A-K-5 two-tone, or boards where big bets pressure a capped caller), you shift toward **bigger bets (66–100%+ pot) with a more polarized range** — strong value + chosen bluffs/semi-bluffs, checking your medium hands.

- **Why it works:** the big size charges draws, extracts maximum from your nutted hands, and leverages your nut advantage to put the caller's capped range in a vise. Your medium hands check (they don't want a big pot — Chapter 3.3).
- **Sizing logic:** big, because you hold disproportionately more nut hands and the board is dynamic enough that protection and max value matter.

> **The decision rule.** *Whose range, and who has the nuts?* **Range advantage but shared nuts → small range bet.** **Range advantage + nut advantage on a dynamic board → big polarized bet.** **No range advantage (caller-favoring board) → check a lot** (next section).

---

## 9.3 When NOT to C-Bet (Checking as the PFR)

The biggest modern improvement over old-school play is **checking more as the preflop raiser**. You should check a meaningful chunk of your range — especially out of position — in these situations:

- **The board favors the caller** (low, connected: 7-6-5, 9-8-6). Your range advantage is gone; betting into a range that crushes you is a leak. Check most of your range and play carefully. (You still bet *some* hands — strong made hands for value/protection and your best draws as semi-bluffs — but at low frequency.)
- **Out of position on dynamic boards.** Being OOP makes c-betting riskier (you'll face raises and tough turns without position). Check more OOP than you would IP on the same board, including some strong hands (a **check-raising** range) and many medium hands (**check-call** or **check-fold**).
- **Your hand is medium-strength with no clear goal** on a board where betting folds out worse and gets called by better. These hands prefer to **check for pot control** and reach showdown (or check-call) rather than bet.

> **The "delayed c-bet."** Checking the flop doesn't mean giving up. You can **check the flop and bet the turn** (a delayed c-bet) — useful when the flop favors the caller but the turn improves your range, when you want to control the pot with a medium hand, or as a balanced way to protect your flop checks. Checking is a tool, not a surrender.

---

## 9.4 C-Bet Sizing Cheat Sheet

| Board / situation | Size | Frequency | Why |
|-------------------|------|-----------|-----|
| Dry, high/broadway (A-7-2, K-9-4) | **25–35% pot** | **High (often range bet)** | Range advantage, shared nuts; bet everything cheaply, deny free cards |
| Paired, dry (Q-Q-4, 8-8-2) | **25–33% pot** | **High** | Few hands connect; cheap pressure on a whiffing range |
| Dynamic with nut advantage (A-K-5ss as 3-bettor) | **66–100%+ pot** | **Selective/polarized** | Charge draws, max value, leverage nut advantage; check medium hands |
| Two-tone broadway (K-Q-4 two-tone) | **50–75% pot** | **Medium** | Protection vs. draws; mix of value and semi-bluffs |
| Monotone (J-8-3 one suit) | **smaller, lower freq** | **Lower** | Flushes already possible; big barrels are risky; proceed cautiously |
| Wet, connected, caller-favoring (9-8-6) | **check most**; bet **big** when you do | **Low** | No range advantage; only bet strong value + best semi-bluffs, sized to charge |

These are defaults. The two questions from Chapter 8 — *static or dynamic?* and *whose range?* — generate them, so you can derive the right size on a novel board rather than memorizing every case.

---

## 9.5 Choosing Which Hands to Bet vs. Check

When you're *not* range-betting (i.e., on boards calling for a polarized or medium approach), sort your range into four buckets:

1. **Strong value (bet):** top pair good kicker and better, overpairs, sets, two pair. Bet for value and protection. On dynamic boards, bet **big**.
2. **Strong draws / good semi-bluffs (bet):** flush draws, open-enders, combo draws, gutshots with overcards/backdoors. These bet as **semi-bluffs** — fold equity now plus equity when called (Chapter 15). Prefer betting draws that **block** villain's continues and have the most outs.
3. **Medium / showdown-value hands (check):** second pair, weak top pair, ace-high that beats bluffs. These **check for pot control** — betting folds out worse and is called by better. They want a cheap showdown or to bluff-catch.
4. **Trash with no equity (check/give up, or bet as a balancing bluff):** hands with no draw and no showdown value. On range-bet boards these are fine to bet (cheaply, balanced); on polarized boards, most should **give up** (check-fold), with a minority continuing as bluffs — *chosen by blocker value*, exactly as in preflop bluff selection.

> **Pair your bluffs with equity and blockers.** The best flop bluffs are **semi-bluffs** (buckets 2) and trash that **blocks villain's calling range** or **unblocks their folding range**. Betting a stone-cold air ball with zero equity and zero blocker relevance is the worst bluff; betting a gutshot with a backdoor flush draw and an overcard is a great one. This is the same principle from preflop (block their continues, keep equity) applied to the flop.

---

## 9.6 Multiway C-Betting (Important in 6-Max)

Everything above assumes a **heads-up** pot (you vs. one caller). When **two or more** players see the flop, c-betting strategy tightens dramatically:

- **Bet far less often, and mostly for value.** With more opponents, someone is more likely to have connected, so your fold equity drops and your bluffs work less. The MDF math compounds — you need *everyone* to fold for a bluff to succeed.
- **Value-bet a bit bigger and more selectively.** Thin value disappears multiway; bet hands that are genuinely strong and can get called by worse from *multiple* ranges.
- **Cut most bluffs.** Pure bluffs are usually unprofitable into multiple players; keep only your strongest semi-bluffs (good draws with real equity), and even those more selectively.
- **Respect aggression more.** When facing a bet or raise multiway, ranges are stronger than heads-up — the field has had multiple chances to wake up with a hand.

Multiway pots get a full treatment in Chapter 27, but internalize now: **the more players in the pot, the tighter, more value-weighted, and less bluffy your betting.**

---

## 9.7 The Exploitative Layer

- **vs. high "fold to c-bet":** c-bet **more** (wider, more bluffs) — especially small on dry boards where they over-fold. Free money.
- **vs. low "fold to c-bet" (calling stations):** c-bet **less as a bluff**, **more for value and bigger**. Stop firing air into someone who never folds; value-bet relentlessly and thinly.
- **vs. players who raise c-bets a lot (aggressive floaters/raisers):** tighten your c-betting range (don't c-bet hands that fold to a raise), check more strong hands to induce/trap, and don't bloat pots with medium hands.
- **vs. players who never raise c-bets (passive):** you can c-bet thinner for value and barrel more freely, since you'll rarely get blown off your hand.
- **vs. opponents who over-fold turns** ("one and done" defenders who call flop, fold turn): c-bet the flop and **barrel the turn** liberally — the second bullet is where they crack.

> **The leak this chapter fixes.** The classic c-bet leak is **betting too often with no plan, the same size every time, regardless of texture or number of opponents** — and then bricking the turn with a medium hand in a bloated pot. The fix: choose a *goal* (value/denial/fold equity), let *texture* pick range-bet vs. polarized vs. check, size accordingly, and **bet far less multiway**. C-betting is a scalpel, not a hammer.

---

## 9.8 Chapter Summary

- A c-bet pursues **value, denial/protection, or fold equity** — bet with a goal; betting medium hands that fold out worse and get called by better achieves nothing.
- Two strategies by texture: **range betting** (small 25–40%, very high frequency, often whole range) on **dry, range-favoring** boards; **polarized betting** (big 66–100%+, selective, check medium hands) on **dynamic boards where you hold the nut advantage**.
- **Check more as the PFR** than old-school play — especially **OOP** and on **caller-favoring (low/connected) boards**; use **check-raises**, **check-calls**, and **delayed c-bets**.
- Sort hands into **value (bet)**, **strong draws (bet as semi-bluffs)**, **medium/showdown (check, pot control)**, and **trash (mostly give up, minority bluff by blockers)**. Best bluffs = **semi-bluffs + blocker hands**.
- **Multiway: bet less, value-weight, cut bluffs, respect aggression** — fold equity collapses with more opponents.
- **Exploit:** c-bet more vs. over-folders, value-bet thin/big and stop bluffing vs. stations, tighten and trap vs. aggressive raisers, and barrel turns hard vs. flop-call/turn-fold opponents.

**Next:** [Chapter 10 — Playing as the Caller](10-playing-as-caller.md). We flip to the other side: what to do when you're *not* the aggressor — floating, raising, donk-betting, probing, and defending against c-bets, especially out of position.
