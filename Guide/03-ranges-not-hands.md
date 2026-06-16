# Chapter 3 — Ranges, Not Hands

The single biggest leap from intermediate to advanced play is a shift in *what you think about*. Beginners think: "What does he have?" Advanced players think: "What is his entire **range** here, and how does my range interact with it?" You will almost never know villain's two cards. You can, however, reason precisely about the *set of all hands* he'd take this line with — and that set, the range, is a knowable, countable thing. This chapter teaches you to think in ranges and introduces the two concepts that turn range-thinking into action: **range advantage** and **nut advantage**.

---

## 3.1 What a Range Is

A **range** is the complete set of hands a player could hold given everything you've observed: their position, the preflop action, their tendencies, and every bet and check since. It's usually expressed as a list of holdings, often with frequencies (e.g., "he raises here with all his sets, two-thirds of his top pairs, and a quarter of his flush draws").

Crucially, *you* have a range too. From the opponent's perspective, you are not "holding AK" — you are holding your entire opening/continuing range, of which AK is one member. Poker is fundamentally **range vs. range**, and good decisions come from understanding the interaction, not from your two specific cards in isolation.

> **The mental switch.** When villain bets the river, the losing question is "Is *my hand* good?" The winning question is "Against *villain's betting range here*, how does *my whole range* do, and where does my specific hand fall within it?" Your AK might be a bluff-catcher at the bottom of your value range or the top of it — same cards, opposite decisions, depending on the range context.

---

## 3.2 How Ranges Narrow Street by Street

A range starts wide and narrows with every action. This is the core mechanic of hand-reading (formalized in Chapter 23). An illustration:

1. **Preflop:** CO opens. From a solid reg, that's a known range — roughly the top ~25–27% of hands (Chapter 4). Already we've eliminated three-quarters of all possible holdings.
2. **Flop (Q♠ 7♦ 2♣), he c-bets:** he keeps betting his Q-x, his overpairs, his sets, plus some backdoor/bluff hands, and checks some of his missed small cards and showdown-bound hands. The range narrows and *polarizes* slightly.
3. **Turn (5♥), he bets again:** double-barreling narrows further — fewer pure air hands survive two barrels; the range concentrates toward real value (top pair good kicker, overpairs, sets) and his *chosen* bluffs (often with equity, like a backdoor draw that picked up outs).
4. **River, he bets a third time:** now the range is tight and polar — strong value and the bluffs he followed through with. *This* is the range you must beat or fold to, and you reason about it by counting combos (Chapter 2.7).

Each action is information. The skill is updating the range correctly at each node rather than anchoring on a first impression.

---

## 3.3 Range Shapes: Linear, Polarized, Merged

Ranges come in three characteristic *shapes*. Knowing which shape you (or villain) are using dictates correct sizing and continuation.

### Linear (a.k.a. "depolarized" / value-heavy / "top-down")
A linear range is simply **the best N% of hands**, top-down, with no gaps. "All hands better than this threshold." Used when you want to get called by worse and deny equity — you're not bluffing, you're just betting a band of strong-to-decent hands.

- *Typical use:* a flop c-bet for a small size on a board that hits your range; some 3-bets for value against a wide opener; opening ranges themselves are linear.
- *Sizing:* tends toward **smaller** bets, because you want calls from the many worse hands.

### Polarized (the "value + bluffs, nothing in between") shape
A polarized range is the **nuts and near-nuts paired with bluffs**, deliberately *excluding* the medium hands (which are checked instead). It's "the top and the bottom, not the middle."

- *Typical use:* big turn/river bets and overbets; 3-bets and 4-bets against tight ranges; any spot where you bet large.
- *Sizing:* tends toward **larger** bets and overbets, because medium hands don't want to bloat the pot, while your strong hands want max value and your bluffs want max fold equity. Medium hands check to control the pot and reach showdown.

> **Why the middle checks.** Medium-strength hands (second pair, a weak top pair) don't want to bet big: worse hands fold (so you get no value) and better hands continue (so you only get called when beaten). They *also* don't want to fold — they have showdown value. So they **check**, aiming to win at showdown or bluff-catch cheaply. Recognizing "this is a check-down hand, not a betting hand" is a hallmark of solid play.

### Merged (the in-between)
A merged range bets a band that's "thick" — strong value *plus* medium-strength hands that can still get called by worse — but typically *without* many pure bluffs. It's a value-dense range that's wider than polarized at the top but doesn't barrel air.

- *Typical use:* medium bet sizes on the turn/river for thin value against calling stations; spots where you have many strong-ish hands and want value but don't need fold equity.
- *Sizing:* **medium**. Big enough for value, small enough that worse hands still call.

The practical link to remember: **bet sizing telegraphs range shape, and range shape should dictate bet sizing.** Small bets ↔ linear/wide; large bets/overbets ↔ polar. When you read villain's sizing, infer the shape; when you choose your own, match size to the shape you're representing (and actually holding, if you want to stay balanced). Full treatment in Chapter 20.

---

## 3.4 Range Advantage

**Range advantage** (a.k.a. equity advantage) belongs to the player whose *entire range* has more equity on a given board. It's not about who has the best single hand — it's about whose collection of hands, on average, does better against the other's collection.

The preflop raiser usually starts with a range advantage on many flops because their range is stronger and more condensed around big cards and pairs. But the *board* decides who it favors:

- **A-high and broadway boards (A-K-4, K-Q-7):** favor the *preflop raiser*, whose range is rich in aces, kings, and broadways. The caller's range (which would have 3-bet its strongest hands) connects less.
- **Low, coordinated boards (6-5-4, 7-6-2):** favor the *caller/defender* more, because the raiser's range is heavy in big cards that miss, while the BB's wide defending range contains more small pairs, suited connectors, and middling cards that connect.

**The rule that follows:** *bet (especially c-bet) more, and you can bet bigger, on boards that favor your range; check more and proceed cautiously on boards that favor villain's range.* Range advantage is the single biggest input into c-betting strategy (Chapter 9).

> **Worked illustration.** You open CO, BB calls. Flop comes A♣ K♦ 6♠. Your CO opening range has tons of Ax and Kx and big pairs; the BB's calling range 3-bets AK/AA/KK a chunk of the time and is left with weaker aces, some kings, small pairs, and connectors that mostly miss. You have a large **range advantage** here — you can c-bet a high frequency, even your whole range, for a small size, because almost every hand you have benefits from betting into a range that whiffed. Now change the flop to 7♥ 6♥ 5♣. Suddenly the BB's range (with 98, 87, 76, 65, 44, etc.) connects hard, while your AK/AQ-type hands are just overcards. Your range advantage evaporates; you check far more.

---

## 3.5 Nut Advantage (and Why It's Different)

**Nut advantage** belongs to the player who holds *more of the very strongest hands* (the "nuts" and near-nuts) on a given board — regardless of average equity. It's about the *top* of the range, not the *mean*.

Range advantage and nut advantage often coincide, but not always — and the difference governs **bet sizing**:

- **Range advantage without strong nut advantage → bet small, high frequency.** You're ahead on average but don't hold disproportionately more nut hands, so you bet a size that pressures their whole range without risking much. (Classic: A-high dry flop where both could have top pair but neither has many sets.)
- **Nut advantage → license to bet big and overbet.** If you hold meaningfully more nutted combos than villain *can* have, you can use large sizes and overbets, because villain can never be confident they have the best hand — they lack the nuts to raise you, and your big bets put their entire range in a vise.

> **The key asymmetry.** On a board like K♦ Q♦ 8♦ where you're the preflop 3-bettor, *you* can have AdXd / KK / QQ / sets and the flush, while the caller's range has far fewer of those (they'd often have re-raised the very best hands or wouldn't flat them). Your **nut advantage** means you can fire big bets and overbets that the caller cannot profitably continue against with their capped range. Conversely, if villain has the nut advantage, *you* should keep the pot small even when your average equity is fine, because the threat of their nutted hands makes big pots dangerous for you.

**Capped vs. uncapped ranges** is the same idea from the other side: a range is **capped** if it contains *no* (or very few) nutted hands — the player would have played those faster/bigger earlier. A range is **uncapped** if it still credibly contains the nuts. **Bet big against capped ranges; be cautious and pot-control against uncapped ones.** Recognizing when villain's line has capped them (e.g., they just called twice and never raised) is one of the most profitable reads in poker, and it licenses relentless pressure.

---

## 3.6 GTO vs. Exploitative: The Framing for This Whole Guide

Two paradigms run through everything that follows. You need both.

### GTO (Game Theory Optimal)
A GTO strategy is **unexploitable**: it's the equilibrium where, no matter what villain does, they can't increase their EV against you. It mixes actions at carefully balanced frequencies (the right ratio of value to bluffs, defending exactly to MDF, etc.) so that villain is *indifferent* — every counter-strategy performs equally poorly.

- **Strength:** you can't be exploited. You don't need reads. It's the correct default against unknown, tough, or observant opponents who would punish any imbalance.
- **Weakness:** GTO is **maximally defensive, not maximally profitable.** Against a player making big mistakes, GTO leaves money on the table — it doesn't *punish* their errors, it just refuses to be punished itself.

### Exploitative
An exploitative strategy **deviates from equilibrium to maximally punish a specific opponent's specific mistakes.** Villain folds too much? Bluff relentlessly, far beyond GTO frequencies. Villain never bluffs? Fold all your bluff-catchers, ignoring MDF. Villain calls too much? Stop bluffing entirely and value-bet thin and large.

- **Strength:** it's where the *big* money is. Most opponents, especially below high stakes, make large, consistent, exploitable errors.
- **Weakness:** deviating from equilibrium opens you to *counter-exploitation*. If you bluff a lot because villain "folds too much" and they adjust (or you misread them), you can be punished. Exploitative play requires accurate reads and is risky against observant opponents.

### How to hold both at once (the guide's core method)
1. **Learn the GTO baseline** for each spot — the balanced, default-correct frequencies and ranges. This is your anchor when you have no read and your shield against good players.
2. **Read the opponent** (Part VI) to identify how they deviate from equilibrium.
3. **Deviate exploitatively** *in the direction their mistakes invite*, by an amount proportional to how confident your read is and how unlikely they are to adjust.

This is exactly the pattern from Chapter 2's MDF discussion: *MDF is the baseline; the read tells you which way to bend it.* Every strategic chapter in this guide will give you the equilibrium default first, then the exploitative deviations. Against tough regs, lean toward the baseline. Against the recreational players who make up most of the money pool, lean hard into exploitation.

> **A practical truth.** You do not need to play perfect GTO to crush 6-max — almost no human can, and it isn't even the most *profitable* approach against weak fields. You need (a) a solid, balanced baseline so good players can't tear you apart, and (b) sharp, disciplined exploitation of the many weak players who can't stop making the same mistakes. This guide aims to give you both.

---

## 3.7 Chapter Summary

- Think in **ranges**, not hands. You and villain each hold an entire range; poker is **range vs. range**. Your specific cards matter only in the context of where they fall in your range.
- Ranges **narrow street by street** as each action eliminates holdings — this is the engine of hand-reading.
- Three range **shapes**: **linear** (top-down value, bet small), **polarized** (value + bluffs, no middle, bet big), **merged** (value-dense, medium size). Sizing both reveals and should match shape.
- **Range advantage** = whose whole range has more equity on this board → governs **c-bet frequency**. Big-card boards favor the raiser; low connected boards favor the caller.
- **Nut advantage** = who holds more of the strongest hands → governs **bet sizing** (big bets/overbets need nut advantage). **Capped** ranges invite pressure; **uncapped** ones demand caution.
- **GTO** = unexploitable baseline (defensive, read-free). **Exploitative** = punish specific mistakes (profitable, read-dependent, counter-exploitable). The method: **learn the GTO baseline, read the opponent, deviate toward their mistakes.**

**Next:** [Chapter 4 — Opening (RFI) Ranges](04-rfi-ranges.md). We begin Part II by putting concrete, position-by-position opening ranges on the table — as 13×13 grids — and the sizing logic behind them.
