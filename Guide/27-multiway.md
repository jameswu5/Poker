# Chapter 27 — Multiway Pots

Almost everything in this guide assumed a **heads-up** pot — you against one opponent. But in 6-max, a meaningful fraction of pots go **multiway** (three or more players to the flop): limped pots, multiple cold-callers, squeezes that get called in two spots, blind defenses where both blinds come along. Multiway pots are **under-studied** (solvers handle them less cleanly, and most training focuses heads-up) and **frequently misplayed** — which makes playing them well a real edge. The governing theme is simple and you've seen it flagged throughout: **with more players in the pot, tighten up, value-weight, and abandon most bluffs.** This chapter explains why and how, street by street.

---

## 27.1 Why Everything Changes Multiway

Three structural facts drive all multiway adjustments:

1. **Someone is more likely to have a strong hand.** With three or four ranges live instead of one, the probability that *somebody* connected hard (top pair+, a set, a strong draw) rises sharply. Your hand needs to be **stronger** to be best.
2. **Fold equity collapses.** A bluff needs **everyone** to fold. If each opponent folds 60%, two opponents both fold only ~36% of the time, three only ~22% — bluffing into multiple players is mathematically punishing (the MDF math compounds across players).
3. **Equity is divided.** Your share of the pot is split among more opponents, so most hands have **lower equity** multiway. Hands that were favorites heads-up become underdogs against the *field*.

The net effect: **value goes up in importance, bluffing goes down, and made-hand requirements rise.** Multiway poker is more straightforward and more "honest" — make a hand, bet it; don't try to run people over.

---

## 27.2 Preflop: Hand Selection Shifts

When a pot is likely to go multiway (loose table, limpers, multiple callers), adjust your preflop hand values:

- **Hands that make the nuts gain value:** suited connectors, suited aces, and pocket pairs (set-mining) — they flop **nutted, disguised hands** that get paid by multiple opponents (great implied odds, Ch. 13, 12). These are *better* multiway.
- **Hands that make marginal top pairs lose value:** offsuit broadways and weak aces — their kicker-vulnerable top pairs are far more likely to be dominated or beaten with more opponents (reverse implied odds amplified, Ch. 14). These are *worse* multiway.
- **Isolate, don't join, when you can.** Rather than flat-calling into a building multiway pot with a strong-but-vulnerable hand, **raise to thin the field** (isolate a limper, squeeze cold-callers — Ch. 7) so you play heads-up in position. A big raise that gets it heads-up is often better than a call that keeps it four-way.
- **Tighten your overall continuing range OOP** into multiway action — the price might look good, but poor equity realization against multiple players offsets it.

---

## 27.3 Flop: Bet Less, Value-Weight, Cut Bluffs

This is where multiway discipline matters most (Ch. 9.6, 17.5):

- **C-bet far less often.** The "range bet small at high frequency" approach is a **heads-up** strategy. Multiway, betting your whole range is a disaster — too many hands behind you can continue or raise. **Check most of your range** and bet selectively.
- **Bet mostly for value, and size up.** Thin value evaporates multiway (someone has better), so bet hands that are **genuinely strong** and can get called by worse from *multiple* ranges. Use a **bigger size** for value/protection — you're charging more drawing hands and want to thin the field further.
- **Cut almost all bluffs.** Pure bluffs need everyone to fold — rarely worth it. Keep only your **strongest semi-bluffs** (big draws with real equity), and even those more selectively. A naked bluff into three players is lighting money on fire.
- **Respect aggression more.** When someone bets, or bets *and* gets called ahead of you, ranges are strong — the field has had multiple chances to wake up. **Fold marginal hands** you might have continued with heads-up; a bet-and-a-call in front of you signals real strength.
- **Position matters even more.** Acting last multiway is hugely valuable (you see multiple players' actions before deciding). Play tighter from early multiway positions, looser (but still value-weighted) when you close the action.

---

## 27.4 Turn and River: Straightforward and Honest

By later streets in a multiway pot, ranges are very strong and the dynamics simplify:

- **Value-bet your strong hands, mostly give up your weak ones.** Multiway later streets are not the place for fancy bluffs — if you don't have a strong hand, you usually don't have a hand worth betting. Bet value, check/fold air.
- **Bluff-catch much tighter.** A bet that survived multiway to the turn/river, or a player betting into multiple opponents, represents **serious strength** (you have to beat several ranges, and someone willing to bet into a crowd usually has it). **Over-fold** your bluff-catchers relative to heads-up standards — the bettor's range is value-heavy because bluffing multiway is so unprofitable.
- **Be cautious with one-pair and overpair hands.** Hands you'd stack off heads-up (an overpair, top pair top kicker) are **much weaker multiway** — more opponents means more ways you're beaten. **Pot-control and be willing to fold** one-pair hands to multiway aggression; don't auto-stack-off (Ch. 11.6, the "tighten multiway" rule).
- **When *you* bet into multiple players on later streets, have it.** Your own multiway later-street bets should be value-heavy and strong — both because bluffs don't work and because thinking opponents (correctly) won't believe a multiway bluff anyway, so you won't get the folds.

---

## 27.5 A Worked Multiway Hand

You open CO with **A♥5♥**, the BTN calls, and the BB calls — three-way to the flop. Flop **K♥ 8♥ 3♣** (you flopped the nut flush draw).
- *Heads-up*, this is a clear semi-bluff c-bet (fold equity + big draw). *Multiway*, reconsider: a c-bet folds out little (two ranges behind, one likely has a King or a pair), and as a *bluff* it's poor (someone continues). But you have a **strong draw with real equity** (nut flush draw), so a **selective semi-bluff bet (sized up) or a check-call** are both fine — you're betting for the *equity and the nut potential*, not primarily for fold equity. If you check and the BTN bets into two players, your nut flush draw is a fine **call** (great implied odds — you'll stack someone when you hit the nuts, and you can't be dominated). 
- *Contrast a weak bluff:* the same spot with **Q♠7♠** (no pair, no draw) is a clear **check-give-up** multiway — no equity, no fold equity. Heads-up you might float or barrel; multiway you fold.

The thread: multiway, you play your **equity and your nut potential**, not your fold equity — strong draws and made hands continue, air gives up.

---

## 27.6 The Exploitative Layer

- **vs. loose-passive multiway tables (common at low stakes):** these are **gold** — play your **nut-making hands** (suited connectors, suited aces, pairs to set-mine), **value-bet relentlessly** when you hit (multiple stations pay you off), and **never bluff** (no one folds). Multiway fish pots are among the most profitable situations in poker — just make hands and bet them.
- **vs. opponents who still bluff multiway:** rare, but if someone hasn't learned that multiway bluffs fail, **bluff-catch them** wider — their multiway bets are more bluff-heavy than they should be.
- **vs. nits multiway:** their multiway bets are *extra* strong (they already only bet strong, and multiway amplifies it) — **fold even more** to their aggression.
- **Isolate the fish:** when a recreational player limps or enters, **raise to get heads-up with them in position** rather than letting the pot go multiway and diluting your edge. Thinning the field to isolate a weak player is a core multiway-adjacent exploit.

> **The leak this chapter fixes.** The big multiway leaks are **(1) applying heads-up aggression multiway** — range-betting, bluffing, and barreling into multiple players who don't fold — and **(2) overvaluing one-pair hands** (stacking off an overpair or top pair against a field that has you beaten). The fix is the chapter's one rule: **multiway, tighten up, value-weight, abandon bluffs, raise your made-hand requirements, and play your equity/nut-potential rather than your fold equity.**

---

## 27.7 Chapter Summary

- Multiway pots (3+ players) are **frequent in 6-max and often misplayed.** Three forces drive every adjustment: **someone likely has a strong hand, fold equity collapses (everyone must fold), and equity is divided** — so **value rises, bluffing falls, made-hand requirements rise.**
- **Preflop:** favor **nut-making hands** (suited connectors/aces, set-mining pairs); devalue **kicker-vulnerable offsuit broadways**; **isolate/raise to thin the field** rather than joining multiway pots with vulnerable hands.
- **Flop:** **c-bet far less, value-weight, size up, cut almost all bluffs** (keep only strong semi-bluffs), and **respect aggression** (a bet-and-call ahead = real strength).
- **Turn/river:** **value-bet strong hands, give up weak ones, bluff-catch much tighter** (multiway bets are value-heavy), and **pot-control/fold one-pair hands** you'd stack off heads-up.
- **Play your equity and nut potential, not your fold equity** — strong draws and made hands continue; air gives up.
- **Exploit:** loose-passive multiway fish pots are **gold** (play nut hands, value-bet, never bluff); fold extra to nits; **isolate the fish** to get heads-up in position.

**Next:** [Chapter 28 — Mental Game & Bankroll](28-mental-game.md), the off-felt foundation — tilt, variance, bankroll management, and the study routine that turns knowledge into a winning long-term result.
