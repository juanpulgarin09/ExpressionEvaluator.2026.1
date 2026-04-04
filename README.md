# ExpressionEvaluator

A mathematical expression evaluator built with .NET 10 and C#. It parses and evaluates infix expressions (e.g. `2*7/4-(8-9^(1/2))+6`) using the shunting-yard algorithm to convert them to postfix notation, then computes the result from the postfix representation.

## Supported Operators

| Operator | Description | Precedence |
|---|---|---|
| `^` | Exponentiation | Highest |
| `*` `/` | Multiplication, Division | Medium |
| `+` `-` | Addition, Subtraction | Lowest |
| `(` `)` | Grouping | — |

## Projects

| Project | Type | Description |
|---|---|---|
| ExpressionEvaluator.Core | Class Library | Contains the `Evaluator` class with the parsing and evaluation logic. |
| ExpressionEvaluator.UI.Console | Console App | Demonstrates expression evaluation with sample expressions. |
| ExpressionEvaluator.UI.Win | Windows Forms App | GUI calculator front-end. |

## Getting Started
```bash
# Build the solution
dotnet build

# Run the console application
dotnet run --project ExpressionEvaluator.UI.Console
```

## Usage
```csharp
using ExpressionEvaluator.Core;

double result = Evaluator.Evaluate("4*(5+6-(8/2^3)-7)-1");

// Multi-digit numbers
double result2 = Evaluator.Evaluate("12+345");

// Decimal numbers
double result3 = Evaluator.Evaluate("10.5+20.75");
```

## How It Works

1. **GetParts** — Before converting the expression, it is first divided into meaningful pieces using the `GetParts` function. This function reads the expression character by character and uses:
   - `char.IsDigit` to detect digits (0–9)
   - `c == '.'` to detect decimal points
   - `string.IsNullOrEmpty` to verify if a number was accumulated before saving it
   - `Contains` to verify if a character is a valid operator
   - `List<string>.Add` to store each piece in order

   This produces a list like `["12.5", "+", "345"]` instead of processing character by character.

2. **Infix to Postfix** — The list of pieces is converted from infix notation to postfix (Reverse Polish Notation) using the shunting-yard algorithm. A `Stack<string>` (operator stack) handles operator precedence and parentheses.

3. **Postfix Evaluation** — The postfix string is evaluated using a `Stack<double>` (number stack): operands are pushed onto the stack, and each operator pops its two operands, computes the result, and pushes it back.

## Modifications from Original

The original evaluator had two limitations that were fixed in this fork:

| Issue | Solution |
|---|---|
| Only supported single-digit numbers | Added `GetParts()` function that groups digits into complete numbers |
| Did not support decimal numbers | Added `char.IsDigit \|\| c == '.'` check and `CultureInfo.InvariantCulture` for correct decimal parsing |
| No graphical interface | Added Windows Forms calculator UI with buttons for digits, operators, parentheses, and result |

## Windows Forms Calculator

The `ExpressionEvaluator.UI.Win` project provides a graphical calculator interface with:

- Display screen showing the current expression
- Digit buttons `0–9`
- Operator buttons `+` `-` `*` `/` `^`
- Parenthesis buttons `(` `)`
- Decimal point button `.`
- `Delete` button to remove the last character
- `Clear` button to reset the expression
- `=` button to evaluate and display the result
