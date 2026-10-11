namespace Backend;public static class ExpressionEvaluator
{
    public static double Evaluate(string infix) => EvaluatePostfix(ToPostfix(infix));
    private static string ToPostfix(string infix)
    {
        var postfix = string.Empty;
        var stack = new Stack<char>();

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];

            // Si encontramos un número o punto
            if (char.IsDigit(item) || item == '.')
            {
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    postfix += infix[i];
                    i++;
                }

                // Espacio para separar el número de otro número u operador
                postfix += " ";

                i--;
            }
            else if (IsOperator(item))
            {
                if (item == ')')
                {
                    var op = stack.Pop();

                    while (op != '(')
                    {
                        postfix += op;
                        postfix += " ";
                        op = stack.Pop();
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postfix += stack.Pop();
                            postfix += " ";
                            stack.Push(item);
                        }
                    }
                }
            }
        }
        while (stack.Count != 0)
        {
            postfix += stack.Pop();
            postfix += " ";
        }

        return postfix;
    }
    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Expresión inválida."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Expresión inválida."),
    };

    private static bool IsOperator(char item) =>
        item == '^' ||
        item == '*' ||
        item == '/' ||
        item == '+' ||
        item == '-' ||
        item == '(' ||
        item == ')';

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var number = string.Empty;

        foreach (var item in postfix)
        {
            // Si encontramos un dígito o puntos, lo guardamos
            if (char.IsDigit(item) || item == '.')
            {
                number += item;
            }
            else if (item == ' ')
            {
                // Cuando encontramos un espacio, convertimos el número completo
                if (number != string.Empty)
                {
                    stack.Push(double.Parse(number, System.Globalization.CultureInfo.InvariantCulture));
                    number = string.Empty;
                    
                }
            }
            else if (IsOperator(item))
            {
                var operand2 = stack.Pop();
                var operand1 = stack.Pop();

                stack.Push(Calculate(operand1, operand2, item));
            }

        }

        return stack.Pop();
    }

    private static double Calculate(double operand1, double operand2, char item) => item switch
    {
        '*' => operand1 * operand2,
        '/' => operand1 / operand2,
        '+' => operand1 + operand2,
        '-' => operand1 - operand2,
        '^' => Math.Pow(operand1, operand2),
        _ => throw new Exception("Expresión inválida."),
    };
}