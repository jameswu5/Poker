# Chapter 29 — Tournament Adjustments

This guide is cash-focused, and for good reason: 100bb-deep cash play is the cleanest setting to learn every fundamental, and those fundamentals transfer directly. But 6-max tournaments (and the 6-max tables within larger-field MTTs) add factors that **change the correct strategy in important ways**: stacks get shorter as blinds rise, you can't reload, and — uniquely — **chips change value** as you approach the money. This final chapter adapts everything you've learned to tournament play, covering the big three differences: **changing stack depths, push/fold play, and ICM**. Treat it as a set of *adjustments* to the cash baseline, not a separate game.

---

## 29.1 What's Different About Tournaments

Four structural differences drive every tournament adjustment:

1. **Stacks shrink relative to the blinds.** In cash you're ~100bb deep all session (you reload). In a tournament, blinds rise and your stack, measured in big blinds, **shortens over time** — you'll routinely play 40bb, 25bb, 15bb, and even sub-10bb stacks, each with different correct strategy.
2. **You can't reload.** Bust and you're out. This makes **survival** have value beyond chips and discourages the marginal-but-+chipEV gambles you'd happily take in cash.
3. **Chips have non-linear value (ICM).** The chips you can *win* are worth less than the chips you can *lose*, because tournament payouts are based on *finishing position*, not chip count. This is the single biggest conceptual difference (Section 29.4).
4. **Antes (in later levels) sweeten the pot.** Once antes are in play, there's more dead money to steal, which **widens stealing ranges** and rewards aggression — pushing toward looser opens and re-steals than the equivalent cash spot.

The cash fundamentals — position, ranges, board texture, hand-reading, the GTO/exploit method — **all still apply.** Tournaments layer stack-depth and ICM adjustments *on top* of that foundation.

---

## 29.2 Stack-Depth Adjustments (Recall Chapter 1.4)

As your stack (in big blinds) shortens, strategy shifts systematically. This is the **effective-stack** principle from Chapter 1.4, now changing *within* a single session:

| Effective stack | Character | Key adjustments |
|-----------------|-----------|-----------------|
| **100bb+** | "Deep" (early levels) | Play like the **cash baseline** in this guide. |
| **40–60bb** | Medium | **Stack-off ranges widen** (less room to maneuver); **set-mining and speculative hands lose value** (worse implied odds — Ch. 12); 3-bet/4-bet stacks get in faster. |
| **20–40bb** | Short-medium | **Reduced postflop play**; **3-bet shoving** becomes a tool; fewer flat-calls, more raise-or-fold; pairs/aces want to get in preflop. |
| **15–25bb** | Short | **Re-shove (3-bet jam) ranges** matter a lot; open-raising commits more of your stack; **postflop play shrinks** toward all-in-or-fold dynamics. |
| **< 15bb** | Push/fold | **Open-jam or fold** much of the time (Section 29.3); postflop play largely disappears. |

> **The shortening-stack principle.** As your stack shortens, **implied odds collapse** (you can't win much when you hit, so speculative/set-mining hands lose value — Ch. 12) and **fold equity via the all-in rises** (jamming becomes a primary weapon). You shift from a deep, postflop, implied-odds game toward a **preflop, all-in-equity, fold-equity game.** The hands that gain are high-card strength and pairs (good all-in equity, good blockers); the hands that lose are the speculative suited connectors and small pairs that needed depth to pay off. Re-evaluate your "stack depth" every few orbits as blinds climb.

---

## 29.3 Push/Fold (Short-Stack Play)

When your stack drops to roughly **≤ 15bb** (and especially ≤ 10bb), the game simplifies to **push/fold**: your main decision when entering a pot is whether to **open-shove all-in or fold** (and, facing a raise, whether to **jam over it or fold**). Postflop play mostly disappears because any meaningful action commits your stack.

**Why push/fold:** with a short stack, open-raising small leaves you pot-committed and lets opponents play perfectly against you; **jamming** maximizes **fold equity** (they can't see a flop or out-play you postflop) and realizes your hand's full equity when called. It's mathematically the cleanest short-stack strategy.

**Push/fold is highly solved.** There are well-established **shove/call charts** (Nash equilibrium push/fold ranges) indexed by **stack size, position, and number of players** — you can study and approximately memorize them. The general shape:
- **Shoving ranges widen** as your stack shortens, as your position improves (more from the BTN/CO/SB), and with **more antes/dead money** in the pot.
- **Calling a shove is tighter than shoving** (you need a stronger hand to call off than to jam, because you lack the fold-equity half of the jam's EV).
- **Fewer players left to act = wider shoves** (less chance someone wakes up with a hand) — stealing the blinds/antes with a jam from the SB or BTN is the bread-and-butter short-stack play.

The practical workflow: know your **stack in big blinds**, your **position**, and consult your internalized push/fold ranges — adjusted for ICM (next) and opponents (loose callers → tighten your shoves; tight callers → widen them).

---

## 29.4 ICM: The Heart of Tournament Strategy

**ICM (Independent Chip Model)** is the framework that converts your **chip stack** into its **real-money equity** (your share of the prize pool), accounting for the fact that **tournament payouts are based on finishing position, not chip count.** Its central consequence:

**Chips you can lose are worth more than chips you can win.** Doubling your stack does *not* double your money (you don't get paid for chips, you get paid for *outlasting* people), but busting costs you *everything*. This asymmetry means **survival has value**, and it makes you play **tighter** in high-ICM-pressure spots than raw chip-EV (or a cash game) would suggest.

**Where ICM matters most:**
- **Near the money bubble** (just before payouts begin): busting means **£0**, so **avoid marginal all-ins** — especially as a medium stack who'd be knocked out. Tighten your calling and shoving ranges; let *other* players take the bust risk. Big stacks, conversely, should **apply maximum pressure** (they risk little, others risk elimination).
- **At/near a pay jump** (final table, each elimination is a real money ladder up): the same logic — **survival to climb the payout ladder** outweighs marginal chip gains. Fold spots you'd take in a cash game.
- **As a short or medium stack with bigger stacks behind:** you face extra pressure (they can bust you), so **tighten** your stack-off ranges; pick spots where you have fold equity or a strong hand.

**ICM adjustments in practice:**
- **Tighten calling ranges** facing all-ins under ICM pressure (calling risks your tournament life for chips worth less than they cost).
- **Big stacks bully; short/medium stacks tighten** — the pressure flows from the players who can afford to bust toward those who can't.
- **The bigger the pay jumps and the closer the bubble, the stronger the ICM tax** on risky play.

> **The ICM mindset.** In a cash game, a +chip-EV all-in is always correct — chips are money, one-to-one. In a tournament, a +chip-EV all-in can be **−£EV** because of ICM: the chips you'd win are worth less than the chips you'd lose, and **busting is irreversible.** Tournament skill is largely **knowing when to abandon chip-EV for £-EV** — folding spots that "show a chip profit" because survival and ladder position are worth more. This is the one place where the relentless aggression rewarded in cash and deep play must yield to **disciplined, survival-aware tightening.**

---

## 29.5 Putting It Together: A Tournament Decision Hierarchy

For any tournament spot, layer the considerations in order:
1. **Effective stack depth** — what "mode" am I in (deep/medium/short/push-fold)? This sets the baseline strategy (Section 29.2).
2. **ICM pressure** — how close are the bubble/pay jumps, and how do the stacks around me change the risk? This tightens (or, for big stacks, loosens) my ranges (Section 29.4).
3. **The cash fundamentals** — within those constraints, apply everything from Parts I–VII: position, ranges, board texture, hand-reading, and the GTO/exploit method.
4. **Opponent reads** — adjust exploitatively as always (Ch. 21–26): loose callers → tighten shoves and value-bet; tight players → steal and re-steal wider; ICM-unaware opponents → exploit their failure to tighten on the bubble.

The cash game taught in this guide is the **engine**; stack depth and ICM are the **constraints** that reshape how you run it in a tournament.

---

## 29.6 The Exploitative Layer

- **vs. ICM-unaware opponents on the bubble:** many recreational players don't tighten under ICM — **apply relentless pressure** (steal, re-steal, jam into them as a big stack) since they'll call/bust too wide and hand you chips, and **avoid spewing into the ones who only get it in strong.**
- **vs. players who over-tighten on the bubble (nit up):** **attack their blinds and steal relentlessly** — they're folding far too much to survive, so print chips uncontested.
- **vs. short-stackers not using push/fold correctly** (open-limping or min-raising-folding short): **isolate and pressure them** — punish their non-jam short-stack play.
- **vs. big-stack bullies:** if you're a medium stack, **tighten and pick strong spots** (don't tangle marginally); if you can re-jam with fold equity, do it with hands that have good equity-when-called.
- **As the big stack:** **bully** — open wide, attack the medium stacks who can't afford to bust, and avoid unnecessary clashes with other big stacks.

> **The leak this chapter fixes.** The two biggest tournament leaks are **(1) playing every stack depth like it's 100bb** (set-mining and flatting speculative hands when short, where implied odds are dead and you should be jamming or folding) and **(2) ignoring ICM** (taking +chip-EV but −£EV gambles on the bubble and at pay jumps, busting in spots a survival-aware player folds). The fix: **re-read your stack depth constantly and shift toward push/fold as you shorten; and let ICM tighten your ranges near the money — abandon chip-EV for £-EV when survival and ladder position are worth more.**

---

## 29.7 Chapter Summary

- Tournaments **layer adjustments onto the cash baseline** — all the fundamentals (position, ranges, texture, hand-reading, GTO/exploit) still apply; **stack depth and ICM are the new constraints.**
- Four differences: **stacks shorten** (blinds rise), **no reloads** (survival matters), **ICM** (chips have non-linear value), and **antes** (more dead money → wider steals).
- **Stack-depth adjustments:** play **100bb like cash**; as you shorten, **implied odds collapse** (speculative/set-mining hands lose value) and **fold equity via jamming rises** — shift from a deep postflop game toward a **preflop, all-in, fold-equity game.**
- **Push/fold (≤ ~15bb):** **open-jam or fold**; use **Nash shove/call charts** indexed by stack/position/players — **shove wider** when shorter, later position, fewer players, more antes; **call tighter** than you shove.
- **ICM:** payouts are by **finishing position, not chips**, so **chips lost > chips won** → **survival has value.** **Tighten** near the **bubble and pay jumps**; **big stacks bully, short/medium stacks tighten.** Tournament skill is **abandoning chip-EV for £-EV** when survival/ladder position is worth more.
- **Decision hierarchy:** stack depth → ICM pressure → cash fundamentals → opponent reads.
- **Exploit:** pressure ICM-unaware and over-tight bubble players, punish incorrect short-stack play, tighten vs. bullies as a medium stack, and **bully as the big stack.**

---

**This completes the main guide (Chapters 1–29).** You now have a full 6-max strategy: foundations and math (Part I), a complete preflop game (Part II), postflop fundamentals (Part III), a plan for every hand type (Part IV), street-by-street decision-making (Part V), the tools to read any opponent (Part VI), the theory tying it together and the off-felt discipline to execute it (Part VII), and the adjustments to take it all into tournaments (this chapter).

**See the [Appendix](appendix-charts.md)** for consolidated preflop range charts and a glossary of every term used in the guide.
