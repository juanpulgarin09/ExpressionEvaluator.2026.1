namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static List<string> GetParts(string infix)
    {
        var parts = new List<string>();
        var number = string.Empty;

        foreach (var c in infix)
        {
            if (char.IsDigit(c) || c == '.')
            {
                number += c;
            }
            else
            {
                if (!string.IsNullOrEmpty(number))
                {
                    parts.Add(number);
                    number = string.Empty;
                }
                if ("+-*/^()".Contains(c))
                    parts.Add(c.ToString());
            }
        }

        if (!string.IsNullOrEmpty(number))
            parts.Add(number);

        return parts;
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<string>();
        var parts = GetParts(infix);

        foreach (var part in parts)
        {
            if (double.TryParse(part, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out _))
            {
                postFix += part + " ";
            }
            else if (part == "(")
            {
                stack.Push(part);
            }
            else if (part == ")")
            {
                while (stack.Count > 0 && stack.Peek() != "(")
                    postFix += stack.Pop() + " ";
                if (stack.Count > 0) stack.Pop();
            }
            else if (IsOperator(part))
            {
                while (stack.Count > 0 && IsOperator(stack.Peek()) &&
                       PriorityStack(stack.Peek()) >= PriorityInfix(part))
                {
                    postFix += stack.Pop() + " ";
                }
                stack.Push(part);
            }
        }

        while (stack.Count > 0)
            postFix += stack.Pop() + " ";

        return postFix.Trim();
    }

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var parts = postfix.Split(' ');

        foreach (var part in parts)
        {
            if (double.TryParse(part, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double number))
            {
                stack.Push(number);
            }
            else
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(part switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    "^" => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error.")
                });
            }
        }

        return stack.Pop();
    }

    private static bool IsOperator(string part) =>
        part == "+" || part == "-" || part == "*" ||
        part == "/" || part == "^";

    private static int PriorityInfix(string part) => part switch
    {
        "^" => 4,
        "*" or "/" => 2,
        "+" or "-" => 1,
        _ => 0
    };

    private static int PriorityStack(string part) => part switch
    {
        "^" => 3,
        "*" or "/" => 2,
        "+" or "-" => 1,
        _ => 0
    };
}