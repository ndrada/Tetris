# 🎲 Tetris Game (WPF / C#)

This is a Tetris game built entirely from scratch using **C#** and **WPF (Windows Presentation Foundation)**. It features custom block logic, a scoring system, held pieces, and colorful sprite-based graphics.

This was a personal project to strengthen my object-oriented programming skills and deepen my understanding of game loops, UI rendering, and state management in C#.

---

## ✨ Features

- Classic Tetris rules with rotation, hold piece, and scoring
- 7 tetromino types (I, J, L, O, S, T, Z) each with rotation logic
- Grid-based collision detection
- Block queue & held piece functionality
- Custom game loop
- Visual design using PNG tile sprites

---

## 📁 Project Structure

```
007-WPF-tetris-game
│
├── Assets/                    # All PNG sprite files (blocks, background, icon)
├── backend/                  # (If needed for expansion, not used here)
├── .vs/, bin/, obj/          # Build folders (ignore)
├── Block.cs                  # Abstract Block class & movement logic
├── BlockQueue.cs             # Handles next piece & randomizer
├── GameGrid.cs               # 2D grid management, full row logic
├── GameState.cs              # Core gameplay logic (score, game over, etc.)
├── IBlock.cs, JBlock.cs...   # Definitions for each tetromino
├── Position.cs               # Simple row/column helper class
├── MainWindow.xaml/.cs       # UI & game loop
└── README.md                 # This file
```

---

## ⚡ Getting Started

### Prerequisites
- Windows OS
- Visual Studio (2022+ recommended)
- .NET Desktop Development workload

### Run the Game
1. Clone the repo:
```bash
git clone https://github.com/ndrada/Tetris.git
```

2. Open the `.sln` file in Visual Studio
3. Hit **Run (F5)** to start playing!

No additional packages or setup needed.

---

## 🏆 Gameplay Highlights
- Score increases by number of cleared rows
- Game ends when new block can't spawn
- You can rotate CW/CCW, move side to side, and hard-drop
- Hold a piece to save for later (one-time per drop)

---

## 📋 Learnings & Challenges
- Implemented OOP principles through abstract classes & inheritance
- Built logic-heavy systems like block collisions, rotations, and queue shuffling
- Gained confidence in WPF rendering and UI threading

---

## ✨ Future Improvements
- Add sound effects
- Implement ghost preview of where block will land
- Add level progression with increasing speed
- High score tracking

---

## 🚀 Made With Love
Built by **yours truly** to level up my C# and game dev skills.
Feel free to fork it, try it, or reach out if you want to roast my game logic haha.

> [andrada.codes](https://andrada.codes) | [@ndrada](https://github.com/ndrada)

---

_Thanks for checking it out!_ ✨

