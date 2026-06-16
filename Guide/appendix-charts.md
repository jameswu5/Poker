# Appendix — Preflop Range Charts (Quick Reference)

Consolidated 13×13 reference charts from Part II, gathered in one place for fast lookup. **All charts assume 100bb effective, 6-max, and are solid teaching baselines — not exact solver outputs.** Adjust exploitatively per the relevant chapters. See the [Glossary](appendix-glossary.md) for any unfamiliar term.

**How to read every grid:** pairs on the diagonal (top-left **AA** → bottom-right **22**); **suited** hands in the upper-right triangle (above the diagonal); **offsuit** hands in the lower-left triangle (below the diagonal). Row = higher card, column = lower card.

---

## A.1 Opening (RFI) Ranges — UTG → Button (Chapter 4)

Each cell shows the **earliest (tightest) position that opens that hand**; every later position also opens it. **U** = UTG+ (all positions) · **H** = HJ+ · **C** = CO+ · **B** = BTN only · **·** = fold.

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

- **UTG (≈16%):** 22+, A2s+, K9s+, Q9s+, J9s+, T9s, 98s, 87s, 76s, 65s, 54s, AJo+, KQo
- **HJ (≈21%):** add ATo, KJo, QJo, K-/Q-/J-/T-/9-/8-suited extensions (T8s, 97s, 86s, 75s)
- **CO (≈27%):** 22+, A2s+, K7s+, Q8s+, J8s+, T8s+, 97s+, 86s+, 75s+, 64s+, 54s, 43s, A8o+, KTo+, QTo+, JTo
- **BTN (≈45%):** 22+, A2s+, K2s+, Q4s+, J7s+, T7s+, 96s+, 85s+, 75s+, 64s+, 53s+, 43s, A2o+, K8o+, Q9o+, J9o+, T9o, 98o

**Sizes:** 2.2–2.5bb (UTG/HJ/CO/BTN); 3–3.5bb (SB). Size up vs. sticky callers, keep small vs. aggressive 3-bettors.

---

## A.2 Small Blind RFI (raise-first-in, ≈40%) — Chapter 4

**R** = open-raise · **·** = fold.

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

- **SB RFI:** 22+, A2s+, K2s+, Q4s+, J6s+, T6s+, 96s+, 85s+, 74s+, 64s+, 53s+, 43s, A2o+, K7o+, Q8o+, J8o+, T8o+, 97o+, 87o. *(Or use the advanced limp/raise split — Ch. 4.4 / 7.1.)*

---

## A.3 Facing an Open: Button vs. Cutoff (in position) — Chapter 5

**3** = 3-bet · **C** = flat-call · **·** = fold.

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 3 | 3 | 3 | C | C | C | C | C | C | 3 | 3 | 3 | 3 |
| **K** | 3 | 3 | C | C | C | C | · | · | · | · | · | · | · |
| **Q** | 3 | C | 3 | C | C | C | · | · | · | · | · | · | · |
| **J** | C | C | C | 3 | C | C | · | · | · | · | · | · | · |
| **T** | C | · | · | · | 3 | C | · | · | · | · | · | · | · |
| **9** | · | · | · | · | · | C | C | · | · | · | · | · | · |
| **8** | · | · | · | · | · | · | C | C | · | · | · | · | · |
| **7** | · | · | · | · | · | · | · | C | C | · | · | · | · |
| **6** | · | · | · | · | · | · | · | · | C | C | · | · | · |
| **5** | · | · | · | · | · | · | · | · | · | C | C | · | · |
| **4** | · | · | · | · | · | · | · | · | · | · | C | · | · |
| **3** | · | · | · | · | · | · | · | · | · | · | · | C | · |
| **2** | · | · | · | · | · | · | · | · | · | · | · | · | C |

- **3-bet value:** TT+, AQs+, AKo, AQo · **3-bet bluff:** A5s–A2s · **Flat:** 22–99, AJs–A6s, KQs–K9s, QJs–Q9s, JTs–J9s, T9s, 98s, 87s, 76s, 65s, 54s, AJo, ATo, KQo, KJo, QJo.
- **3-bet sizing:** ~3× IP, ~4× OOP.

---

## A.4 Facing an Open: Big Blind vs. Button (defense) — Chapter 5

**3** = 3-bet · **C** = flat-call (defend) · **·** = fold.

|     | A | K | Q | J | T | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
|-----|---|---|---|---|---|---|---|---|---|---|---|---|---|
| **A** | 3 | 3 | 3 | C | C | C | C | C | C | 3 | 3 | 3 | 3 |
| **K** | 3 | 3 | C | C | C | C | C | C | C | C | C | C | C |
| **Q** | 3 | C | 3 | C | C | C | C | C | C | C | C | · | · |
| **J** | C | C | C | 3 | C | C | C | C | C | · | · | · | · |
| **T** | C | C | C | C | 3 | C | C | C | C | · | · | · | · |
| **9** | C | C | C | C | C | C | C | C | C | · | · | · | · |
| **8** | C | C | C | C | C | C | C | C | C | C | · | · | · |
| **7** | C | C | · | · | · | C | C | C | 3 | C | C | · | · |
| **6** | C | · | · | · | · | · | · | · | C | 3 | C | · | · |
| **5** | C | · | · | · | · | · | · | · | · | C | C | C | · |
| **4** | C | · | · | · | · | · | · | · | · | · | C | C | · |
| **3** | C | · | · | · | · | · | · | · | · | · | · | C | · |
| **2** | C | · | · | · | · | · | · | · | · | · | · | · | C |

- **3-bet value:** TT+, AQs+, AKo · **3-bet bluff:** A5s–A2s, 76s, 65s · **Flat:** very wide (the BB closes the action and gets a price — fold the least). **Don't over-fold the big blind.**

---

## A.5 4-Betting Range (you opened, faced a 3-bet) — Chapter 6

**4** = 4-bet · **C** = call the 3-bet · **·** = fold. *(CO/BTN open vs. a reg's 3-bet; tighten vs. tight 3-bettors, widen vs. loose.)*

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

- **4-bet value:** QQ+, AK, AQs *(AQs/JJ flex)* · **4-bet bluff:** A5s, A4s · **Call:** JJ–TT, AQ, AJs, KQs (esp. IP) · **5-bet jam:** AA, KK, AK (QQ opponent-dependent); **5-bet bluff:** A5s/A4s. Default stack-off core: **QQ+/AK** (tighter when deeper, wider when shorter).

---

## A.6 SB vs. BTN (3-bet-or-fold, OOP) — Chapter 7

**3** = 3-bet · **·** = fold.

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

- **Value:** 77+, ATs+, KTs+, QTs+, JTs, AJo+, KQo · **Bluffs:** A5s–A2s, T9s, 98s, 87s, 76s, 65s, 54s · **Fold the rest** (SB plays 3-bet-or-fold OOP). Tighten/value-weight vs. tighter openers.

---

## A.7 Quick Math Reference (Chapter 2)

**Pot odds — bet size → equity needed to call:**

| Villain bets | You need |
|---|---|
| 1/4 pot | 16.7% |
| 1/3 pot | 20% |
| 1/2 pot | 25% |
| 2/3 pot | 28.6% |
| 3/4 pot | 30% |
| Pot | 33.3% |
| 1.5× (overbet) | 37.5% |
| 2× (overbet) | 40% |

**Alpha / MDF — bet size → bluff must work / you must defend:**

| Bet size | α (bluff works) | MDF (defend) | Value:Bluff (river) |
|---|---|---|---|
| 1/3 pot | 25% | 75% | — |
| 1/2 pot | 33% | 67% | 2 : 1 |
| 2/3 pot | 40% | 60% | 1.7 : 1 |
| Pot | 50% | 50% | 1 : 1 |
| 2× overbet | 67% | 33% | 0.5 : 1 |

**Outs (Rule of 2 & 4):** flop equity ≈ outs × 4; turn equity ≈ outs × 2. Flush draw = 9 outs (~36%/18%); OESD = 8 (~32%/16%); gutshot = 4 (~16%/8%); combo draw = 15 (~55%+). *Discount tainted outs.*

**Combos:** unpaired hand = 16 (4 suited / 12 offsuit); pair = 6; suited hand = 4. **Set-mining:** flop a set ~1 in 8.5 (11.8%); want ~10–15× effective stacks behind + a paying opponent.

---

*Charts consolidated from Chapters 2, 4, 5, 6, and 7. For the reasoning behind any range, see the source chapter.*
