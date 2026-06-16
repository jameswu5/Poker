# Chapter 1 — The 6-Max Table

6-max (six-handed) No-Limit Hold'em is the dominant format in online cash games and a core structure in tournaments. Compared to full-ring (9-handed), it is faster, more aggressive, and more positionally driven. Before any preflop chart or postflop line makes sense, you need a precise mental model of *where you sit*, *how deep you are*, and *how those two facts shape every decision*. This chapter builds that model.

---

## 1.1 The Six Seats

Action moves clockwise. The two players to the left of the button post forced bets (the blinds). In 6-max the seats are:

| Seat | Name | Abbrev. | Position type |
|------|------|---------|---------------|
| 1 | Under the Gun | UTG | Early |
| 2 | Hijack | HJ | Middle |
| 3 | Cutoff | CO | Late |
| 4 | Button | BTN | Late (best) |
| 5 | Small Blind | SB | Blind (out of position) |
| 6 | Big Blind | BB | Blind (out of position) |

Note what 6-max *removes* relative to full-ring: the early-position seats (UTG+1, UTG+2 / MP1, MP2). There is exactly **one** early seat (UTG), one middle seat (HJ), and two genuinely late seats (CO, BTN). This single fact is why 6-max ranges are wider than full-ring: you are far more often in or near late position, where stealing and positional advantage dominate.

**Preflop action order:** UTG acts first, then HJ, CO, BTN, SB, and BB acts last. The BB has the option to check or raise if the pot is unraised to them.

**Postflop action order:** the blinds act first (SB, then BB), then the remaining players in clockwise order, with the BTN acting last whenever they are in the hand. Acting last is *position*, and it is the single most valuable structural edge in poker.

---

## 1.2 Why Position Is Everything

Position = acting after your opponent on every postflop street. The player in position (IP) sees what the out-of-position (OOP) player does before committing, which grants three compounding advantages:

1. **Information.** You act with strictly more information. A check from OOP, a bet, a sizing — all of it is yours to read before you decide.
2. **Pot control.** IP, you can check behind to see a free card with a marginal hand, or bet to deny equity. OOP, checking invites a bet you must then face; you cannot guarantee a free card.
3. **Realization of equity.** This is the key concept. Two hands with identical raw equity do *not* win the same amount of money. The IP hand realizes more of its equity because it can fold, call, and bluff more efficiently. We quantify this with an **equity realization (R) factor**: IP hands typically realize >100% of their raw equity, OOP hands <100%.

> **Worked intuition.** Suppose your hand has 40% raw equity against villain's range. In position, you might realize ~110% of it (effectively playing like ~44%). Out of position, you might realize ~85% (effectively ~34%). Same cards, very different value — purely from seat. This is why a hand that is a profitable call on the button can be a fold from the small blind.

The practical takeaway, established here and reinforced throughout the guide: **widen your range as position improves, tighten it as position worsens, and discount OOP hands for poor equity realization.**

---

## 1.3 The Blinds: Forced Investment, Forced Disadvantage

The SB and BB post chips before seeing their cards. This creates two structural realities:

- **They have already invested**, so they get a price to continue (especially the BB, who often closes the preflop action and gets good pot odds to defend).
- **They are out of position** against everyone except each other postflop, and the SB is out of position against the BB too.

The blinds are where most losing players bleed money. You **cannot** win at 6-max long-term; the goal is to **lose as little as possible** from the blinds while defending correctly. Expect both blinds to be net-losing seats; a strong reg loses less from the BB than a weak one. We devote all of Chapter 7 to blind play.

A note on the **SB specifically**: it is the worst seat at the table. You have invested half a big blind, you are out of position against the entire field including the BB, and you only have one player left to act behind you when stealing. Modern strategy in the SB is heavily polarized toward a 3-bet-or-fold approach (covered in Chapter 7), precisely because flat-calling out of position realizes equity so poorly.

---

## 1.4 Effective Stacks

The **effective stack** is the *smaller* of the two stacks in any confrontation — it is the most either player can win or lose. If you have 200bb and villain has 80bb, you are playing an 80bb pot at most; your extra 120bb is irrelevant to this hand.

Effective stack depth reshapes strategy profoundly:

| Effective depth | Character of play |
|-----------------|-------------------|
| **< 20bb** | Push/fold and short-stack dynamics; implied odds collapse; preflop all-ins dominate (mostly a tournament concern, Ch. 29). |
| **40–60bb** | "Medium" stacks; stack-off thresholds lower; set-mining and speculative hands lose value. |
| **100bb** | The cash-game default and our baseline throughout this guide. Full postflop play across all three streets. |
| **150bb+ ("deep")** | Implied odds and position swell in value; suited/connected hands rise; top-pair hands become more cautious; overbets and nut-hand disparity matter more. |

Unless stated otherwise, **assume 100bb effective** for every chart and line in this guide. We flag explicitly when depth changes the answer.

A subtle but vital point: **implied odds** (the money you expect to win on later streets when you hit) scale with effective depth. Set-mining a small pocket pair to flop a set needs deep enough stacks to get paid; at 40bb it's often not worth it, at 150bb it's excellent.

---

## 1.5 Why 6-Max Plays More Aggressively Than Full-Ring

Three structural forces make 6-max looser and more aggressive:

1. **Fewer players, more steals.** With only four non-blind seats, the blinds come around faster and you must contest more pots to beat the rake and blind cost. Tight, full-ring "wait for aces" strategies bleed out in 6-max.
2. **Position more often.** You are on or near the button a larger fraction of hands, so profitable wide opens and steals are available constantly.
3. **Wider ranges → more marginal spots.** Because everyone opens and 3-bets wider, postflop ranges are wider and more dynamic. Hand-reading, range advantage, and aggression carry more weight than in tight full-ring play.

The consequence: 6-max rewards **selective aggression** — opening wide from late position, 3-betting actively, c-betting with range advantage, and applying pressure — far more than passive, nut-peddling play.

---

## 1.6 Table Dynamics & Seat Selection

You are not playing "the field" in the abstract; you are playing the five specific humans at your table. Two dynamics matter from the first hand:

- **Who is on your left vs. your right.** Players on your *left* act after you and can punish your steals with 3-bets; aggressive players on your left are a tax on your positional play. Players on your *right* you get to act after — having fish or passive players on your right is ideal, because you isolate them in position.
- **Seat selection (cash games).** In cash, you can choose and change seats. The standard goal: **sit to the left of the loose/weak players and the aggressive players**, so you act after them. Get the money on your right. This single off-table decision can be worth more than many hours of strategy study.

We develop full opponent profiling in Part VI (Chapters 21–24). For now, internalize that *every range and line in this guide is a baseline to be adjusted based on who you're up against.*

---

## 1.7 Chapter Summary

- 6-max has six seats: **UTG, HJ, CO, BTN, SB, BB.** Only one early seat, two late seats — this is why ranges are wide.
- **Position** (acting last) is the dominant structural edge: more information, better pot control, and superior **equity realization**. Widen IP, tighten OOP.
- The **blinds** are forced-investment, out-of-position seats and are net-losing; the goal is to lose less. The **SB is the worst seat**, favoring 3-bet-or-fold.
- **Effective stack** = the smaller stack. Our baseline is **100bb**; depth changes implied odds and stack-off thresholds.
- 6-max plays **more aggressively** than full-ring because of fewer players, more frequent position, and wider ranges.
- **Seat selection and table dynamics** — getting weak/aggressive players on your right — are decisions you make before any cards are dealt.

**Next:** [Chapter 2 — Core Math](02-core-math.md), where we put numbers to equity, pot odds, EV, and the defense math (MDF/alpha) that underpins every later decision.
