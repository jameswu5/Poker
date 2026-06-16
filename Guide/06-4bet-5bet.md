# Chapter 6 — 4-Bet / 5-Bet & Stacking Off Preflop

When a 3-bet meets a re-raise, you've entered **4-bet** territory — and the next escalation, the **5-bet**, is usually all-in at 100bb. These are the highest-leverage preflop decisions in the game: the pots are large, the ranges are narrow, and mistakes are expensive because stacks go in. The good news is that the math and ranges here are *tighter and more knowable* than anywhere else, so once you understand the structure you'll rarely be lost. This chapter covers value 4-bets, 4-bet bluffs, the stack-off thresholds, and how to respond when you're the one facing a 4-bet.

---

## 6.1 The Betting Ladder and Default Sizes

Recall the escalation: **open (2-bet) → 3-bet → 4-bet → 5-bet (usually all-in)**. Default sizing at 100bb:

| Action | Size | Notes |
|--------|------|-------|
| Open (2-bet) | 2.2–2.5bb | Chapter 4 |
| 3-bet | ~3× IP / ~4× OOP | Chapter 5 |
| **4-bet** | **~2.2–2.5× the 3-bet** | Smaller multiplier than the 3-bet used, because the pot is already big and you're committing a lot. IP slightly smaller, OOP slightly larger. |
| **5-bet** | **All-in** | At 100bb, a 5-bet is a jam (or so large it's committing). |

**Worked stack math (100bb, why 5-bets are jams):** CO opens 2.5, BTN 3-bets to 8, CO 4-bets to ~19–20. Now if CO's 4-bet is ~20bb and BTN wants to continue by 5-betting, the only sensible move is all-in — there's ~80bb behind and the pot is already ~30bb, so any "raise" is committing. This is why **the 4-bet is the decision that effectively sets up stacking off**: when you 4-bet (or call one), you should already know your plan for getting it all in.

---

## 6.2 The 4-Bet Range: Value + Bluffs

Like 3-betting, 4-betting is **polarized**: a core of **value hands** that want stacks in, plus a measured number of **4-bet bluffs**. The medium-strong hands (the ones too good to fold but not good enough to stack off) **call the 3-bet** or fold instead — they don't 4-bet.

### Value 4-bets (the hands happy to get 100bb in)
At 100bb against a typical 3-betting range, the hands strong enough to 4-bet for value and stack off are roughly:
- **QQ+, AK** as the core.
- **JJ and AQs** as *position- and opponent-dependent* additions — 4-bet/stack them against loose, light 3-bettors; flat or fold them against tight, value-heavy 3-bettors.

The tighter villain's 3-betting range, the tighter your value 4-bets (against a nit who only 3-bets QQ+/AK, your JJ and AQ are crushed and should just call or fold, not stack off).

### 4-bet bluffs (chosen for blockers)
You add bluffs so villain can't simply fold everything but the nuts to your 4-bets. The best 4-bet bluffs **block villain's value 3-betting range**:
- **Ax blockers** — hands like **A5s, A4s** (and offsuit **Axo** in a pinch). Holding an ace makes it less likely villain has AA or AK, the exact hands that continue against your 4-bet. The suited wheel aces also retain a sliver of playability if called.
- Occasionally **Kx blockers** (e.g., KQs) when you also want a hand that flops well if called.

> **The blocker logic, sharpened.** When you 4-bet bluff, you *want* villain to have a hand that folds. Their continuing range to a 4-bet is mostly **AA, KK, QQ, AK**. If you hold an **ace** (A5s), you remove a chunk of their AA and AK combos; if you hold a **king**, you remove KK/AK combos. Every blocker you hold makes their "I have a monster, I continue" outcome less likely, which is exactly when a bluff prints. This is why **A5s is a better 4-bet bluff than a random suited connector** — the connector blocks *nothing* in their value range.

### A reference 4-bet range (you opened, faced a 3-bet, ~100bb)

**Legend: 4 = 4-bet, C = call the 3-bet, · = fold.** (Shown for a CO/BTN open facing a 3-bet from a regular; tighten vs. tight 3-bettors, widen vs. loose ones.)

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 4 | 4 | C | C | C | · | · | · | · | 4 | 4 | · | · |
| **K** | 4 | 4 | C | · | · | · | · | · | · | · | · | · | · |
| **Q** | C | · | 4 | · | · | · | · | · | · | · | · | · | · |
| **J** | · | · | · | 4 | · | · | · | · | · | · | · | · | · |
| **T** | · | · | · | · | C | · | · | · | · | · | · | · | · |
| **9** | · | · | · | · | · | C | · | · | · | · | · | · | · |
| **8** | · | · | · | · | · | · | C | · | · | · | · | · | · |
| **7** | · | · | · | · | · | · | · | C | · | · | · | · | · |
| **6** | · | · | · | · | · | · | · | · | C | · | · | · | · |
| **5** | · | · | · | · | · | · | · | · | · | C | · | · | · |
| **4** | · | · | · | · | · | · | · | · | · | · | · | · | · |
| **3** | · | · | · | · | · | · | · | · | · | · | · | · | · |
| **2** | · | · | · | · | · | · | · | · | · | · | · | · | · |

**As text:**
- **4-bet (value):** QQ+, AK, AQs *(AQs/JJ are the flex — 4-bet vs. loose 3-bettors, call vs. tight ones)*
- **4-bet (bluff):** A5s, A4s *(ace blockers)*
- **Call the 3-bet:** JJ–TT, AQ, AJs, KQs, and other strong-but-not-stack-off hands (especially **in position**, where you can profitably flat a 3-bet and play postflop)
- **Fold:** everything else

Note the **gap**: medium hands like JJ/TT/AQ/KQs **call** rather than 4-bet — that's the polarized structure. You don't 4-bet hands that hate getting 100bb in but are too good to fold.

---

## 6.3 Calling a 3-Bet (the Middle Option)

Flatting a 3-bet is viable mostly **in position** and mostly with hands that:
- **Realize equity well** and can flop strong (pairs that can set-mine, suited broadways, AQ/AJs/KQs).
- **Don't want to get all-in preflop** but are too strong to fold.

Out of position, calling 3-bets is much weaker (you'll play a bloated pot OOP), so OOP you skew toward **4-bet or fold**. When you do call a 3-bet, you're typically playing a ~17–20bb pot postflop in position with a capped-ish but solid range — plan to use your position, and remember the 3-bettor often has a polarized range that will keep barreling.

---

## 6.4 Facing a 4-Bet: Continue, Jam, or Fold

When **your** 3-bet gets 4-bet, you're usually choosing between **folding**, **calling** (rare at 100bb), and **5-bet jamming**. At 100bb most of your range either folds or jams — calling a 4-bet OOP is awkward and infrequent.

**5-bet jam (all-in) for value:** **AA, KK**, and often **AK** (AK is a jam against most 4-betting ranges because of fold equity + its equity when called). **QQ** is a close, opponent-dependent jam-or-fold (jam against loose 4-bettors, fold/flat against tight ones — it's often dominated by the QQ+/AK core).

**5-bet jam as a bluff:** the best 5-bet bluffs again **block** villain's calling range. **A5s/A4s** are ideal — the ace blocks AA/AK, so your jam gets through more often, and you have a wheel/flush backup the rare times you're called. This is why those suited wheel aces appear at *every* level of the betting ladder (3-bet bluff, 4-bet bluff, 5-bet bluff): they block the nut hands and keep a little equity.

**Fold:** the bulk of your light 3-bets (the suited connectors, the non-ace-blocker bluffs) simply fold to a 4-bet — they've done their job by generating fold equity on the 3-bet, and they can't profitably continue.

> **Don't get attached.** A common, expensive mistake is "I already 3-bet, I can't fold now." You absolutely can. A 3-bet bluff that gets 4-bet has *failed* — folding is the plan for most of those hands. Stacking off light against a 4-bet (which is a strong, narrow range) is how intermediate players punt 100bb pots.

---

## 6.5 Stack-Off Thresholds & Stack-Depth Effects

The core question whenever the betting escalates: **"Am I happy getting 100bb in here?"** Your answer defines your value range.

- **At 100bb**, the standard stack-off core is **QQ+/AK**, widened or tightened by villain's tendencies. Against a maniac 4-bettor, KK/QQ/AK/AQ and more get it in; against a nit, even QQ and AK can be folds.
- **Deeper (150bb+):** stack-off ranges **tighten** in terms of *which hands want all-in*, because the consequences of being dominated (e.g., AK vs AA, KK vs AA) are larger — but implied-odds hands (pairs to set-mine, suited hands) gain value for *calling* rather than stacking off. You 4-bet/5-bet a tighter value range and rely more on postflop play.
- **Shorter (40–60bb):** stack-off ranges **widen** (less room to maneuver, jamming becomes correct with more hands), trending toward push/fold dynamics. This matters most in tournaments (Chapter 29).

The unifying idea: **the deeper the stacks, the more it costs to be second-best when the money goes in, so the tighter your "happy to stack off" range — and the more you lean on postflop skill instead of preflop all-ins.**

---

## 6.6 The Exploitative Layer

- **Villain 4-bets too much (light):** call/jam wider for value — your QQ, AK, even JJ/AQ become profitable stack-offs, and you can add a few more 5-bet bluffs because they're folding out the air they 4-bet with... *unless* they never fold their 4-bets, in which case just value-jam wider and drop bluffs.
- **Villain rarely 4-bets (only nuts):** respect it. Fold your 3-bet bluffs, and even consider folding QQ/AK to their 4-bet. Stop 3-bet-bluffing them as much — they're not folding enough to your 3-bets to make bluffs pay, *and* they punish you when they wake up.
- **Villain folds too much to 4-bets:** add **4-bet bluffs** (ace blockers first) — your 4-bets print when they fold their 3-bet bluffs and medium hands.
- **Villain never folds to 4-bets (calls/jams light):** **cut your 4-bet bluffs** and 4-bet a pure value range; you can also value-4-bet a touch wider since they stack off light.

> **The recurring theme.** Every preflop bluff at every level wants the **same two properties: block their continues, keep some equity.** Suited wheel aces (A5s–A2s) maximize both, which is why they're the universal preflop bluff. When you deviate exploitatively, you're really just answering one question — *how often does this specific villain fold?* — and adding bluffs when the answer is "too often," cutting them when it's "not enough."

---

## 6.7 Chapter Summary

- The ladder is **open → 3-bet → 4-bet → 5-bet (all-in at 100bb)**. 4-bet to **~2.2–2.5× the 3-bet**; the 4-bet is the decision that sets up stacking off, so have a plan before you make it.
- The **4-bet range is polarized:** value (**QQ+, AK**, with **JJ/AQs** as opponent-dependent flexes) + bluffs chosen for **blockers** (**A5s, A4s** — they remove villain's AA/AK). Medium hands **call** the 3-bet, not 4-bet.
- **Calling a 3-bet** is mostly an **in-position** play with hands that realize equity well; OOP, lean **4-bet or fold**.
- **Facing a 4-bet:** **jam AA/KK/AK** (QQ is opponent-dependent), **5-bet-bluff with ace blockers**, and **fold the rest** of your light 3-bets — don't get attached to a failed bluff.
- **Stack-off threshold = "am I happy getting 100bb in?"** Default core **QQ+/AK**, **tighter when deeper** (domination costs more; lean on postflop), **wider when shorter** (toward push/fold).
- **Exploit** by reading *how often villain folds*: add bluffs vs. over-folders, cut bluffs and value-jam wider vs. stations/light-4-bettors, and respect (fold to) players who only escalate with the nuts.

**Next:** [Chapter 7 — Blind Play & The Squeeze](07-blind-play.md). We close Part II with the trickiest seats — the small and big blinds — covering SB 3-bet-or-fold vs. limp strategy, disciplined wide BB defense, the squeeze play, and the cold-call.
