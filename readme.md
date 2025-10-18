# Single Operator Calculator

[![Difficulty](https://img.shields.io/badge/difficulty-easy-brightgreen)]()
[![Languages](https://img.shields.io/badge/languages-C%23%20%7C%20Node.js%20%7C%20Python%20%7C%20Java%20%7C%20Go%20%7C%20Rust-informational)]()
[![Deadline](https://img.shields.io/badge/deadline-2025--10--20-critical)]()

> A simple console-based calculator that takes two numbers from the user and performs addition. Proper error handling and standard output formatting should be implemented.

---

## Table of Contents

* [Requirements](#requirements)
* [Problem Description](#problem-description)
* [Rules and Constraints](#rules-and-constraints)
* [Input/Output and Examples](#inputoutput-and-examples)
* [How to Run and Test](#how-to-run-and-test)
* [How to Submit (PR)](#how-to-submit-pr)
* [Evaluation Criteria](#evaluation-criteria)
* [Timeline](#timeline)
* [Contact](#contact)

---

## Requirements

* Allowed Languages: **C#**, **Node.js**, **Python**, **Java**, **Go**, **Rust**
* Recommended Versions: `.NET 6`, `Node 20+`, `Python 3.11+`, `Java 17+`, `Go 1.21+`, `Rust 1.70+`
* OS: Any (Windows / Linux / macOS)
* Familiarity with:

  * Basic programming concepts
  * Console input/output
  * Error handling (`try/catch`, `try/except`, `Result`)

---

## Problem Description

Write a program that:

1. Reads two numbers from the user via console input.
2. Performs **addition** on those two numbers.
3. Displays the result in a properly formatted output.
4. Prints an appropriate error message if invalid input is provided (e.g., text instead of a number).

**Goal:** Practice basic input/output, error handling, and clean coding structure.

---

## Rules and Constraints

* Only one operation is allowed: **Addition**
* Input must be read from standard input (`Console.ReadLine()` / `input()` / `readline` / etc.).
* Exception handling is mandatory (no crashes).
* Do not use any external libraries unless part of the language’s standard library.
* Code must be readable and well-documented.

---

## Input/Output and Examples

**Sample Input:**

```text
Enter first number: 7
Enter second number: 5
```

**Sample Output:**

```text
Result: 12
```

**Invalid Input:**

```text
Enter first number: abc
```

**Output:**

```text
Invalid input! Please enter numeric values only.
```

---

## How to Run and Test

### 1) Clone the Project

```bash
git clone https://github.com/dotin-challenge/cache-t1.git
cd cache-t1
```

### 2) Build and Run (depending on your language)

#### ▶ C#

```bash
dotnet build
dotnet run
```

#### ▶ Node.js

```bash
node solutions/<username>/index.js
```

#### ▶ Python

```bash
python solutions/<username>/main.py
```

#### ▶ Java

```bash
javac solutions/<username>/Main.java
java solutions.<username>.Main
```

#### ▶ Go

```bash
go run solutions/<username>/main.go
```

#### ▶ Rust

```bash
cargo run --bin <username>
```

### 3) (Optional) Run Tests

If test files are included:

```bash
dotnet test
# or
npm test
# or
pytest
```

---

## How to Submit (PR)

1. **Fork** the repository.
2. Create a new branch:

   ```bash
   git checkout -b solution/<username>
   ```
3. Place your code inside the following folder (based on language):

   ```text
   solutions/<language>/<username>/
     ├─ main source file(s)
     └─ README.md (optional explanation)
   ```
4. Example:

   ```text
   solutions/C#/jaber-borzouei/
     ├─ Program.cs
     └─ README.md
   ```
5. Open a Pull Request with the title:

   ```text
   [Solution] Single Operator Calculator - <username>
   ```

---

## Evaluation Criteria

| Criteria                             | Weight |
| ------------------------------------ | ------ |
| Correctness                          | 40%    |
| Code Quality & Readability           | 25%    |
| Error Handling                       | 10%    |
| Output Formatting & User Interaction | 10%    |
| Documentation                        | 5%     |
| **Submission Speed (Time of PR)**    | **5%** |

> The earlier you submit a correct and working PR before the deadline, the higher your chance to earn these extra 5%.

---

## Timeline

* Start: `2025-10-18`
* PR Submission Deadline: `2025-10-20`

---

## Contact

* .NET Community Group
* Or open an **Issue** in this repository for any questions or discussions
