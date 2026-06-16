# Chapter 4 — Opening (RFI) Ranges

RFI stands for **Raise First In** — you are the first player to voluntarily enter the pot, by raising, with everyone before you having folded. This is the most common and most important preflop decision you make, because it happens on a huge fraction of hands and sets up every postflop situation as the **preflop raiser (PFR)** with initiative and (usually) range advantage. Limping first-in is almost never correct in 6-max (we'll explain why), so RFI strategy is essentially **"which hands do I open-raise from each seat, and to what size?"**

This chapter gives you concrete baseline ranges as 13×13 grids, the sizing logic, and the exploitative adjustments. These ranges are your **GTO-flavored default**; the rest of the chapter teaches you when to widen or tighten them.

---

## 4.1 Why You Raise, and Why Not Limp

When you're first in, you have two real options: **raise** or **fold**. Open-limping (just calling the big blind) is a mistake in almost all 6-max situations because:

1. **It surrenders initiative.** Raising makes others fold (you can win uncontested) and gives you the betting lead postflop. Limping does neither.
2. **It caps your range.** A limp says "I don't have a strong hand," so good players attack your limps with raises and you're stuck playing weak hands out of position.
3. **It invites multiway pots.** Limping encourages others to come along cheaply, and multiway pots reduce the equity and playability of most hands (Chapter 27).

The lone exception worth knowing is a deliberate, balanced limping strategy in the **small blind** when folded to (covered in 4.5 and Chapter 7) — and even there, raise-first-in is simpler and very strong. Everywhere else: **raise or fold.**

---

## 4.2 Opening Sizes

Bet sizing for opens has converged on small raises in modern 6-max, because smaller opens risk less to win the same blinds and let you open a wider range profitably.

| Position | Recommended open size (100bb) | Why |
|----------|-------------------------------|-----|
| UTG, HJ, CO | **2.2–2.5bb** | Standard. Some players use a flat 2.3bb from all early/middle seats. |
| BTN | **2.0–2.5bb** | Can go a touch smaller; you have position and only two players left. Some go 2.5bb to charge the blinds more. |
| SB | **3.0–3.5bb (larger)** | You'll be out of position postflop; a bigger raise buys more fold equity and builds a pot you want heads-up, not multiway. |

A note on **adjusting to the field:** if opponents call too much (sticky, recreational tables), size **up** (e.g., 3bb) to get more money in with your strong hands and charge their loose calls. If they fold too much or 3-bet aggressively, the small 2.2–2.5bb keeps your risk low. Sizing is an exploit lever, not a fixed rule.

---

## 4.3 The Master Opening Grid (UTG → Button)

Because RFI ranges get progressively wider from UTG to the Button, we can encode all four positions in **one grid**. Each cell shows the **earliest (tightest) position that opens that hand** — and every position later than that also opens it.

**Legend (open from this position *and all later* positions):**
- **U** = open from **UTG** onward (i.e., every position opens it)
- **H** = open from **HJ** onward (HJ, CO, BTN)
- **C** = open from **CO** onward (CO, BTN)
- **B** = open from **BTN** only
- **·** = fold (not opened even on the Button)

**How to read the grid:** pairs are on the diagonal (top-left **AA** → bottom-right **22**). **Suited** hands are in the upper-right triangle (above the diagonal); **offsuit** hands are in the lower-left triangle (below the diagonal). Row = higher card, column = lower card.

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | U | U | U | U | U | U | U | U | U | U | U | U | U |
| **K** | U | U | U | U | U | U | C | C | B | B | B | B | B |
| **Q** | U | U | U | U | U | U | C | B | B | B | B | · | · |
| **J** | U | H | H | U | U | U | C | B | · | · | · | · | · |
| **T** | H | C | C | C | U | U | H | B | · | · | · | · | · |
| **9** | C | B | B | B | B | U | U | H | B | · | · | · | · |
| **8** | C | B | · | · | · | B | U | U | H | B | · | · | · |
| **7** | B | · | · | · | · | · | · | U | U | H | · | · | · |
| **6** | B | · | · | · | · | · | · | · | U | U | C | · | · |
| **5** | B | · | · | · | · | · | · | · | · | U | U | B | · |
| **4** | B | · | · | · | · | · | · | · | · | · | U | C | · |
| **3** | B | · | · | · | · | · | · | · | · | · | · | U | · |
| **2** | B | · | · | · | · | · | · | · | · | · | · | · | U |

*Example reads:* the cell at Row **K**, Column **8** is the **suited** hand **K8s**, marked **C** → opened from the **CO and Button**, folded from UTG/HJ. The cell at Row **9**, Column **A** (lower-left, offsuit) is **A9o**, marked **C**. The cell at Row **T**, Column **A** is **ATo**, marked **H** → opened from HJ onward.

### The same ranges as text lists (for precise reference)

**UTG (≈16%)** — all the **U** cells:
- Pairs: **22+**
- Suited: **A2s+, K9s+, Q9s+, J9s+, T9s, 98s, 87s, 76s, 65s, 54s**
- Offsuit: **AJo+, KQo**

**Hijack (≈21%)** — adds the **H** cells to UTG:
- Pairs: **22+**
- Suited: **A2s+, K9s+, Q9s+, J9s+, T8s+, 97s+, 86s+, 75s+, 65s, 54s**
- Offsuit: **ATo+, KJo+, QJo**

**Cutoff (≈27%)** — adds the **C** cells:
- Pairs: **22+**
- Suited: **A2s+, K7s+, Q8s+, J8s+, T8s+, 97s+, 86s+, 75s+, 64s+, 54s, 43s**
- Offsuit: **A8o+, KTo+, QTo+, JTo**

**Button (≈45%)** — adds the **B** cells:
- Pairs: **22+**
- Suited: **A2s+, K2s+, Q4s+, J7s+, T7s+, 96s+, 85s+, 75s+, 64s+, 53s+, 43s**
- Offsuit: **A2o+, K8o+, Q9o+, J9o+, T9o, 98o**

> **Read the trend, not just the cells.** Notice *how* the range widens: from UTG to BTN you add (1) weaker suited aces and kings (for blocker value and flush potential), (2) more suited connectors and gappers (great playability and disguise in position), and (3) progressively weaker offsuit broadways and aces (which need position to be playable due to domination/reverse-implied-odds risk — Chapter 2.5). Offsuit hands are the *last* to be added because they flop the weakest and realize equity worst. This is the structural logic of every opening range.

---

## 4.4 The Small Blind: A Different Animal

The SB is unique: when it folds to you, only the BB remains. You're getting a great immediate price to attack one player's blind, but you will be **out of position for the entire hand** if called. This pulls SB strategy in two directions, and there are two viable approaches:

1. **Raise-first-in (simpler, recommended baseline):** open a fairly wide, somewhat **linear** range to a **larger size (3–3.5bb)**, then play postflop OOP. The bigger size discourages the BB from defending too wide and builds a heads-up pot.
2. **Limp/raise split (advanced):** open-*raise* a polarized range (strong hands + some bluffs) and open-*limp* a wide chunk of medium/speculative hands, planning to play a smaller pot OOP. Solvers do this, and it's strong against good BBs — but it's harder to execute and easy to play badly. We cover it in Chapter 7.

Here is a solid **SB raise-first-in** baseline (≈40%). **Legend: R = open-raise, · = fold.**

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | R | R | R | R | R | R | R | R | R | R | R | R | R |
| **K** | R | R | R | R | R | R | R | R | R | R | R | R | R |
| **Q** | R | R | R | R | R | R | R | R | R | R | R | · | · |
| **J** | R | R | R | R | R | R | R | R | R | · | · | · | · |
| **T** | R | R | R | R | R | R | R | R | R | · | · | · | · |
| **9** | R | R | R | R | R | R | R | R | R | · | · | · | · |
| **8** | R | R | R | R | R | R | R | R | R | R | · | · | · |
| **7** | R | R | · | · | · | R | R | R | R | R | R | · | · |
| **6** | R | · | · | · | · | · | · | · | R | R | R | · | · |
| **5** | R | · | · | · | · | · | · | · | · | R | R | R | · |
| **4** | R | · | · | · | · | · | · | · | · | · | R | R | · |
| **3** | R | · | · | · | · | · | · | · | · | · | · | R | · |
| **2** | R | · | · | · | · | · | · | · | · | · | · | · | R |

**SB raise-first-in (≈40%) as text:**
- Pairs: **22+**
- Suited: **A2s+, K2s+, Q4s+, J6s+, T6s+, 96s+, 85s+, 74s+, 64s+, 53s+, 43s**
- Offsuit: **A2o+, K7o+, Q8o+, J8o+, T8o+, 97o+, 87o**

Note this is **wider than the Button range in suited hands** (you only have one player to get through) but should be played cautiously postflop because you're OOP. Against a BB who defends very wide and plays well postflop, tighten this and lean toward the limp/raise approach.

---

## 4.5 Adjusting Your Opens: The Exploitative Layer

The grids above are baselines. Adjust them based on **who is behind you** (the players left to act) and **how the table plays**:

**Tighten your opens when:**
- There are **aggressive 3-bettors on your left.** Every hand you open faces a re-raise tax; drop the weakest, most domination-prone offsuit hands first (they make the worst hands to play for a 3-bet pot OOP).
- The table is **very loose-passive and multiway.** Hands that need fold equity or play well heads-up (offsuit broadways, weak aces) lose value when four people see the flop; favor hands that flop nutted (pairs, suited connectors, suited aces).

**Widen your opens when:**
- The players behind are **tight/passive (nits) or fold too much.** You can steal more, especially from the CO/BTN — add more suited and offsuit junk because the blinds and remaining players over-fold.
- You have **position on the weak players** (they're in the blinds or fold often). Late-position steals against tight blinds are among the most profitable opens in the game.

**Position-specific exploit notes:**
- **From the BTN**, your open is largely a *steal*. If both blinds are nits, you can open *any two cards* profitably (they fold too often to give the BB and SB any defense equity). If a blind is a sticky calling station or an aggressive 3-bettor, tighten back toward the baseline.
- **From the SB**, your "steal" is against one player. Against a BB who under-defends, widen and even open near-100% of hands you can play; against a tough, wide-defending BB, tighten and consider the limp strategy.
- **From UTG/HJ**, you have many players behind — these opens are about *hand strength*, not stealing. Don't get fancy; the baseline is already optimized for the fact that 3–5 players can wake up with a hand.

> **The most common leak this chapter fixes.** Recreational and many intermediate players open **too tight from late position** (passing up free money against folding blinds) and **too wide/too loose from early position with offsuit junk** (creating disasters OOP in 3-bet pots). Internalize the *shape* of these ranges: early = strong and condensed, late = wide and steal-heavy, and the offsuit hands are always the marginal, last-in, position-dependent additions.

---

## 4.6 Chapter Summary

- **RFI = Raise First In.** In 6-max it's **raise or fold** — open-limping surrenders initiative, caps your range, and invites multiway pots. (SB limp/raise is the lone advanced exception.)
- **Open small:** 2.2–2.5bb from UTG/HJ/CO/BTN; **larger (3–3.5bb) from the SB** because you'll be OOP. Size up vs. sticky callers, keep it small vs. aggressive 3-bettors.
- Ranges **widen from UTG (≈16%) → BTN (≈45%)**. Use the master tiered grid; the additions as you move later are weaker suited aces/kings, more suited connectors/gappers, then weak offsuit broadways and aces.
- **Offsuit hands are added last** everywhere — they flop weakest, suffer reverse-implied odds, and need position to be playable.
- The **SB** is special: wide raise-first-in (≈40%) to a large size, or an advanced limp/raise split — but always cautious postflop because you're OOP.
- **Exploit:** tighten against aggressive 3-bettors on your left and loose-multiway tables; widen against tight/folding blinds and players behind. Late-position steals vs. nitty blinds are premium spots — don't open too tight there.

**Next:** [Chapter 5 — Facing an Open](05-facing-an-open.md). Now that you know how to open, we cover what to do when *someone else* opens and the action reaches you: when to 3-bet, when to flat-call, and when to fold — with grids and the linear-vs-polarized 3-betting framework.
