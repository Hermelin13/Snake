# Snake - Legacy Code Refactoring

## Project: UTB Zlin - Advanced Programming

Refactoring of an older implementation of the classic Snake game in C# with emphasis on **clean code** and **best practices** in object-oriented programming.

---

## 📋 About the Project

This is a university project at the University of Tomáš Baťa in Zlín focused on refactoring legacy code. The original implementation was taken from Stack Exchange (user Wagacca with community modifications) and serves as an ideal example of poor code structure for refactoring practice.

### Original Source
- **Stack Exchange Code Review**: https://codereview.stackexchange.com/q/127515
- **License**: CC BY-SA 3.0
- **Original Author**: Wagacca (modified by community)

---

## 🎯 Refactoring Goals

| Goal | Description |
|-----|-------|
| **Readability** | Code should be understandable at first glance |
| **Maintainability** | Easy modifications without changing entire code |
| **Testability** | Game logic separated from UI |
| **Extensibility** | Easy addition of new features |
| **SOLID Principles** | Single Responsibility, Open/Closed, Liskov Substitution, ... |

---

## 🛠️ Technology Stack

- **Language**: C# (.NET/Mono)
- **Platform**: Console application
- **.NET Framework**: .NET Framework 4.x+
- **IDE**: Visual Studio / JetBrains Rider

---

## 🚀 How to Run

```bash
# Compile
csc snake.cs

# Run
snake.exe
```

Or in Visual Studio:
1. Open `snake.cs`
2. F5 or Debug → Start Debugging

---

## 📝 Notes

- Game is controlled with **arrow keys** (up, down, left, right)
- Goal: eat as much food as possible without hitting walls or yourself
- Score increases with each food eaten
- Game ends on collision

