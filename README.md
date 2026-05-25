[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/2acq7Syj)
# [Game Title Here]

---

## Group Members

| Name |
|------|
| Member 1 — *[Full Name]* |
| Member 2 — *[Full Name] (optional)* |
| Member 3 — *[Full Name] (optional)* |

> Groups must have between **1 and 3 members**. Remove unused rows.

---

## Game Mechanics

### Mechanic 1 — *[Name]*
*Describe something the player can do, something the player can interact with, or a rule the game enforces*

*Describe how the game reacts or responds*

*Describe the effects of this mechanic on the player*

### Mechanic 2 — *[Name]*
*Describe something the player can do, something the player can interact with, or a rule the game enforces*

*Describe how the game reacts or responds*

*Describe the effects of this mechanic on the player*

### Mechanic 3 — *[Name]*
*Describe something the player can do, something the player can interact with, or a rule the game enforces*

*Describe how the game reacts or responds*

*Describe the effects of this mechanic on the player*

<!-- Game Jam B: Uncomment and complete the two additional mechanics below -->
<!--
### Mechanic 4 — *[Name]*
*Describe something the player can do, something the player can interact with, or a rule the game enforces*

*Describe how the game reacts or responds*

*Describe the effects of this mechanic on the player*

### Mechanic 5 — *[Name]*
*Describe something the player can do, something the player can interact with, or a rule the game enforces*

*Describe how the game reacts or responds*

*Describe the effects of this mechanic on the player*
-->

---

## UI Elements

| # | UI Element | Purpose |
|---|------------|---------|
| 1 | *[e.g. Health Bar]* | *[e.g. Displays the player's current health]* |
| 2 | *[e.g. Score Counter]* | *[e.g. Tracks and displays the player's current score]* |

---

## Core Gameplay Loop

*Provide a brief overview of the core loop — what does the player do moment to moment?*

> *Example: "The player navigates procedurally generated rooms, defeating enemies to collect keys that unlock the next floor, while managing a limited health pool."*

---

### How to Win

1. *[Describe the one win condition — what must the player achieve to win?]*

---

### How to Lose

1. *[Describe lose condition #1 — what causes the player to fail?]*

<!-- Game Jam B: Uncomment and complete the second lose condition below -->
<!--
2. *[Describe lose condition #2 — what is the second way the player can fail?]*
-->

---

## Anticipated Challenges

*Before you begin building, identify **3 challenges** you expect to encounter during development.*

1. **[Challenge Title]** — *Describe the challenge and why you think it will be difficult.*

2. **[Challenge Title]** — *Describe the challenge and why you think it will be difficult.*

3. **[Challenge Title]** — *Describe the challenge and why you think it will be difficult.*

---

## Screenshots

> Upload **two screenshots** showing a **before and after** of the player performing an action or using a mechanic. Replace the placeholder text below with your actual images.

### Before
![Before Screenshot](screenshots/before.png)
*Caption: Describe what is happening before the action (e.g., "Player approaching the jump pad").*

### After
![After Screenshot](screenshots/after.png)
*Caption: Describe what is happening after the action (e.g., "Player launched into the air after touching the jump pad").*

> Place your screenshots in a `/screenshots` folder in your repository and update the file names above to match.

---

## Input & Code Highlight

> Identify a section of your code that demonstrates **functional player input**. Paste it in the code block below and explain what it does.

**File:** `Assets/Scripts/[YourScriptName].cs` &nbsp;|&nbsp; **Lines:** `[e.g. 24–41]`

**What it does:**
*Briefly explain what this code does and how it responds to player input.*

```csharp
// Paste your code snippet here
// Example:
void Update()
{
    float moveInput = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    if (Input.GetButtonDown("Jump") && isGrounded)
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
```

---

*README last updated: [Date]*
