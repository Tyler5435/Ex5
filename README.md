# Exercise 5: Selection Statements

## Project overview

Exercise 5 is a C# console application made up of a menu and a collection of small programming exercises. Its main purpose is to demonstrate **selection statements**: instructions that let a program choose what to do based on a condition or a value entered by the user.

The exercises prompt for input, store that input in a variable, evaluate it, and display a message. Most exercises have two versions: one using `if`/`else` and another using a `switch` statement. Comparing these versions helps show that the same decision can often be expressed in different ways.

This is a learning project rather than a single-purpose production application. Each option runs one independent example, and the menu lets the user choose another exercise afterwards.

## Learning objectives

The project provides practice with:

- Reading text entered in a console window with `Console.ReadLine()`.
- Converting input text into integer values.
- Comparing values with operators such as `==`, `<`, and `>`.
- Combining conditions with the logical OR operator, `||`.
- Selecting between outcomes with `if`, `else if`, and `else`.
- Matching values or value ranges with `switch`, `case`, and `default`.
- Displaying information with `Console.WriteLine()`.
- Organising multiple examples into separate classes and namespaces.
- Repeating a menu with a `while` loop and exiting when requested.

## How the program works

When the application starts, `ExerciseMenu.Main` displays a numbered list of exercises. It reads the selected option as text and uses an `if`/`else if` chain to call the `Main` method for the matching exercise. After the selected exercise finishes, the loop displays the menu again.

Enter `0` to leave the menu. End-of-input (when `Console.ReadLine()` returns `null`) also exits. Any other menu entry displays a reminder of the valid choices, then returns to the menu.

Each exercise is kept in its own `.cs` file and namespace. The project file sets `ExerciseMenu` as the startup object, so the menu runs when the application starts even though the exercise files also contain `Main` methods.

## Menu and exercise guide

### Option 1: Enter an integer

**File:** `Program.cs`  
**Selection type:** `if` / `else if` / `else`

The program asks for an integer and checks it against three specific values:

| Input | Response |
| --- | --- |
| `1` | `Thank you.` |
| `2` | `That's fine.` |
| `3` | `Too big.` |
| Any other integer | `Not a number I know.` |

This illustrates an ordered chain of conditions: the first matching branch runs, while `else` handles every value not matched earlier.

### Option 2: 24 + 9 quiz

**File:** `Ex5_1.cs`  
**Selection type:** `if` / `else`

The program asks, “What is 24 + 9?” It expects the integer `33`. If the answer equals 33, it displays `Correct!`; otherwise, it displays `Incorrect. The answer is 33.`

This is a simple two-outcome decision. The equality operator `==` tests whether the entered answer matches the expected answer.

### Option 3: Baker's dozen quiz

**File:** `Ex5_2.cs`  
**Selection type:** `if` / `else`

The program asks how many items are in a baker's dozen. It checks whether the integer entered is `13`, then displays `Correct!` or `Incorrect!`.

This exercise uses the same two-branch structure as option 2, with a different question and expected value.

### Option 4: Film age check

**File:** `Ex5_3.cs`  
**Selection type:** `if`

The program asks for an age. If the entered value is less than 18, it displays `Sorry, this film is not for you`.

This version only defines a response for ages below 18. For ages of 18 or above, it does not print an additional message. Option 10 demonstrates a version with both an under-18 response and an eligible-age response.

### Option 5: Password check

**File:** `Ex5_4.cs`  
**Selection type:** `if` / `else`

The program asks for a password and compares the entered text with the exact value `PASSWORD`. A match displays `Welcome to the treasure`; any other value displays `Go away, it's all mine`.

The comparison is case-sensitive: for example, `password` in lowercase does not match `PASSWORD`.

### Option 6: Number range

**File:** `Ex5_5.cs`  
**Selection type:** `if`

The program asks for a number between 1 and 10. It checks whether the value is less than 1 **or** greater than 10. If either condition is true, it displays `Sorry...out of range`.

The `||` operator means “or”. In this version, a number from 1 through 10 does not produce a message. Option 12 shows a `switch` version that explicitly reports values in range.

### Option 7: Compare two numbers

**File:** `Ex5_6.cs`  
**Selection type:** `if` / `else if` / `else`

The program asks for two integers and compares them:

- If they are equal, it displays `The numbers are equal`.
- If the first is greater, it displays `The first number is bigger`.
- Otherwise, the second is greater, so it displays `The second number is bigger`.

The order of the conditions matters: equality is checked first, then the first number being greater. The final `else` covers the remaining case.

### Option 8: 24 + 9 quiz using `switch`

**File:** `Ex5_1_Switch.cs`  
**Selection type:** `switch`

This repeats the 24 + 9 question. The `case 33` branch reports success, and `default` reports an incorrect answer. It demonstrates matching an integer against a specific `case` value.

### Option 9: Baker's dozen quiz using `switch`

**File:** `Ex5_2_Switch.cs`  
**Selection type:** `switch`

This repeats the baker's dozen question using `case 13` for the correct answer and `default` for all other integer answers.

### Option 10: Film age check using `switch`

**File:** `Ex5_3_Switch.cs`  
**Selection type:** relational `switch`

This asks for an age and uses `case < 18` for people below 18. The `default` branch reports `You can watch the film`, covering ages of 18 or above. This example shows a relational pattern in a `switch` statement rather than a simple exact-value match.

### Option 11: Password check using `switch`

**File:** `Ex5_4_Switch.cs`  
**Selection type:** `switch`

This repeats the password exercise using `case "PASSWORD"` for the matching password and `default` for every other value. It has the same case-sensitive comparison as option 5.

### Option 12: Number range using `switch`

**File:** `Ex5_5_Switch.cs`  
**Selection type:** `switch`

This asks for a number and lists each integer from 1 to 10 as a `case`. All these cases share the message `Number is in range`. The `default` case handles any other integer and displays `Sorry...out of range`.

This shows how several `case` labels can share the same block of instructions.

## Project files

| File | Purpose |
| --- | --- |
| `ExerciseMenu.cs` | Displays the menu, validates the menu choice, and calls the selected exercise. |
| `Program.cs` | First `if`/`else if` example: responding to an entered integer. |
| `Ex5_1.cs` to `Ex5_5.cs` | Exercises covering arithmetic answers, age, password, and number range using `if` conditions. |
| `Ex5_6.cs` | Compares two integers using a multi-branch `if` statement. |
| `Ex5_1_Switch.cs` to `Ex5_5_Switch.cs` | Switch-based versions of the quiz, age, password, and range exercises. |
| `Ex5.csproj` | Defines the console application, target framework, nullable setting, and startup object. |
| `Ex5.slnx` | Solution file used to open the project in a compatible development environment. |

## Requirements

- .NET 10 SDK
- A terminal or command prompt

The project targets `net10.0` and is configured as a console application.

## Build and run

Open a terminal in the project folder and run:

```sh
dotnet run
```

To build without starting the program, run:

```sh
dotnet build
```

When the menu appears, type an option number and press Enter. Complete the prompts for that exercise; when it returns, choose another option or enter `0` to exit.

## Input notes

- Enter whole numbers for the exercise selection and for prompts that ask for an integer or age.
- Enter a whole-number answer for the arithmetic and baker's dozen quizzes.
- For the password exercise, enter `PASSWORD` in uppercase to match the expected value.
- The exercises convert input directly to integers. They are designed for valid input; letters, blank input, or numbers outside the supported integer range may cause a conversion error.
- The program does not impose a realistic age limit or restrict numbers to positive values unless the exercise's condition checks those values.

## Concepts in the code

### `if`, `else if`, and `else`

An `if` statement runs its block when its condition is true. `else if` checks another condition if the earlier one was false. `else` runs when none of the preceding conditions matched. Options 1 and 7 show several possible outcomes.

### `switch`, `case`, and `default`

A `switch` compares one value against `case` labels. The matching case runs, and `default` handles values without a matching case. Options 8, 9, and 11 show exact-value matching; option 10 shows a relational pattern; option 12 groups multiple cases for one response. `break` ends each selected case block.

### Input conversion and comparisons

`Console.ReadLine()` reads input as text. The exercises use `int.Parse` or `Convert.ToInt16` to convert numeric text to an integer. Conditions then compare those integer values or compare password text. This project demonstrates the decision logic and assumes the user enters data in the expected format.
