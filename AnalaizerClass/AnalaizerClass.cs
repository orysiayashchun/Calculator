using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class AnalaizerClass
    {
        private string expression = "";
        public string lastError { get; private set; }

        public AnalaizerClass(string expression)
        {
            this.expression = expression;
            lastError = "";
        }

        private void CheckCurrency()
        {
            lengthCheck();

            for (int i = 0; i < expression.Length; i++)
            {
                wrongSymbCheck(expression[i], i + 1);//перевіряємо чи коректрий символ
            }

            symbIsLetter();//чи коректна операція
            bracketsCheck();//перевірка дужок
        }
        public string Estimate()
        {
            CheckCurrency();
            string formatExpr = Format();//розбили на елементи вхідну стрічку і перевірили на правильність
            string polishExpr = PolishInverseExpr(formatExpr);//становлення порядку операцій
            string result = RunEstimate(polishExpr);
            return result;
        }

        //перевірка дужок
        private void bracketsCheck()
        {

            int openedBracketsCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char symb = expression[i];

                if (symb == '(')
                {
                    openedBracketsCount++;
                }
                else if (symb == ')')
                {
                    openedBracketsCount--;
                }

                if (openedBracketsCount < 0)
                {
                    lastError = "ERROE 01 : at " + (i + 1) + "  wrong brackets structure";
                    throw new Exception(lastError);
                }
                else if (openedBracketsCount > 3)//Максимальна глибина вкладеності структури в дужках – 3.
                {
                    lastError = "ERROR 01 : at " + (i + 1) + " : wrong brackets structure";
                    throw new Exception(lastError);
                }
            }

            if (openedBracketsCount != 0)
            {
                lastError = "ERROR 03: Incorrect syntax";
                throw new Exception(lastError);
            }
        }
        //перевірка чи правильно введений символ
        private void symbIsLetter()
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if ((expression[i] == 'm') &&
                    (i < expression.Length - 2) &&
                    (expression[i + 1] == 'o') &&
                    (expression[i + 2] == 'd'))
                {
                    i += 2;
                    continue;
                }

                if (expression[i] == 'm' ||
                    expression[i] == 'p' ||
                    Char.IsDigit(expression[i]) ||
                    Char.IsWhiteSpace(expression[i]) ||
                    expression[i] == '/' ||
                    expression[i] == '*' ||
                    expression[i] == '-' ||
                    expression[i] == '+' ||
                    expression[i] == '(' ||
                    expression[i] == ')')
                {
                    continue;
                }

                lastError = "Error 02 at " + (i + 1) + " : Unknown operator";
                throw new Exception(lastError);
            }
        }


        private bool isAnumb(string line)
        {
            return Char.IsDigit(line[0]) || (line.Length > 1 && Char.IsDigit(line[1]));
        }

        private bool isAnOper(string line)
        {
            if (("+-/*()m".IndexOf(line[0]) != -1))
                return true;
            return false;
        }

        private byte orderOfOperations(string line)
        {
            switch (line[0])
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case 'm': return 5;
                default: return 6;
            }
        }

        private void lengthCheck()
        {
            if (expression.Length > 65536)
            {
                lastError = "ERROR 07: Too long expression ";
                throw new Exception(lastError);
            }
        }

        private void wrongSymbCheck(char a, int position)
        {
            if (Char.IsDigit(a) ||
                Char.IsWhiteSpace(a) ||
                a == '/' ||
                a == '*' ||
                a == '-' ||
                a == '+' ||
                a == '(' ||
                a == ')' ||
                a == 'm' ||
                a == 'o' ||
                a == 'd' ||
                a == 'p')
            {
                return;
            }
            lastError = "ERROR 02 : at " + position + "  unknown operator";
            throw new Exception(lastError);
        }

        private string formatWhitespaces()
        {
            string formatExpr = "";

            bool negativeInt = false;
            for (int i = 0; i < expression.Length; i++)
            {
                char symb = expression[i];

                if (Char.IsWhiteSpace(symb))
                {
                    if (!formatExpr.EndsWith(" "))
                    {
                        formatExpr += ' ';
                    }
                    continue;
                }

                if (symb == '(' ||
                    symb == ')' ||
                    symb == '/' ||
                    symb == '*' ||
                    symb == '+' ||
                    symb == '-')
                {
                    if (!formatExpr.EndsWith(" "))
                    {
                        formatExpr += ' ';
                    }
                    formatExpr += symb;
                    formatExpr += ' ';
                    continue;
                }

                if (symb == 'm')
                {
                    if (i + 1 >= expression.Length)
                    {
                        lastError = "ERROR 05: Not finished expression";
                        throw new Exception(lastError);
                    }

                    if (expression[i + 1] != 'o' &&
                        !Char.IsDigit(expression[i + 1]))
                    {
                        lastError = "ERROR 01 : at " + (i + 1) + "  incorrect syntax";
                        throw new Exception(lastError);
                    }

                    if (!formatExpr.EndsWith(" "))
                    {
                        formatExpr += ' ';
                    }

                    if (!Char.IsDigit(expression[i + 1]))
                    {
                        formatExpr += "mod";
                        i += 2;
                        formatExpr += ' ';
                        continue;
                    }

                    negativeInt = true;
                    continue;
                }

                if (symb == 'p')
                {
                    if (i + 1 >= expression.Length)
                    {
                        lastError = "ERROR 05: Not finished expression";
                        throw new Exception(lastError);
                    }

                    if (!Char.IsDigit(expression[i + 1]))
                    {
                        lastError = "ERROR 01 : at " + (i + 1) + " incorrect syntax";
                        throw new Exception(lastError);
                    }
                    continue;
                }

                string number = negativeInt ? "-" : "";
                negativeInt = false;

                while (true)
                {
                    number += expression[i];

                    if (i + 1 < expression.Length && Char.IsDigit(expression[i + 1]))
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (!formatExpr.EndsWith(" "))
                {
                    formatExpr += ' ';
                }
                formatExpr += number;
            }

            if (formatExpr.StartsWith(" "))
            {
                formatExpr = formatExpr.Remove(0, 1);
            }

            if (formatExpr.EndsWith(" "))
            {
                formatExpr = formatExpr.Remove(formatExpr.Length - 1);
            }
            return formatExpr;
        }


        private string Format()
        {
            string formatExpr = formatWhitespaces();
            string[] operators = formatExpr.Split(' ');
            int count = 0;

            for (int i = 0; i < operators.Length; i++)
            {
                string oper = operators[i];

                if (isAnumb(oper))
                {
                    count++;
                    // number
                    if (i + 1 < operators.Length &&
                        operators[i + 1][0] == '(')
                    {
                        lastError = "ERROR 03: Incorrect syntax";
                        throw new Exception(lastError);
                    }

                    if (i + 1 < operators.Length &&
                        isAnumb(operators[i + 1]))
                    {
                        lastError = "ERROR 03: Incorrect syntax";
                        throw new Exception(lastError);
                    }
                    continue;
                }

                if (oper.Length > 1)
                {
                    // mod
                    count++;
                    if (i + 1 >= operators.Length)
                    {
                        lastError = "ERROR 05: Not finished expression";
                        throw new Exception(lastError);
                    }
                    else
                    {
                        string nextOperator = operators[i + 1];
                        if (!isAnumb(nextOperator) &&
                            nextOperator[0] != '(')
                        {
                            lastError = "ERROR 03: Incorrect syntax";
                            throw new Exception(lastError);
                        }
                    }
                    continue;
                }

                if (oper[0] == '(')
                {
                    if (i + 1 >= operators.Length)
                    {
                        lastError = "ERROR 05: Not finished expression";
                        throw new Exception(lastError);
                    }
                    else
                    {
                        string nextOperator = operators[i + 1];
                        if (!isAnumb(nextOperator) &&
                            nextOperator[0] != '(')
                        {
                            lastError = "ERROR 03: Incorrect syntax";
                            throw new Exception(lastError);
                        }
                    }
                    continue;
                }

                if (oper[0] == ')')
                {
                    if (i + 1 < operators.Length &&
                        operators[i + 1][0] == '(')
                    {
                        lastError = "ERROR 03: Incorrect syntax";
                        throw new Exception(lastError);
                    }

                    if (i + 1 < operators.Length &&
                        isAnumb(operators[i + 1]))
                    {
                        lastError = "ERROR 03: Incorrect syntax";
                        throw new Exception(lastError);
                    }
                    continue;
                }

                if (oper[0] == '+' ||
                    oper[0] == '-' ||
                    oper[0] == '*' ||
                    oper[0] == '/')
                {
                    count++;
                    if (i + 1 >= operators.Length)
                    {
                        lastError = "ERROR 05: Not finished expression";
                        throw new Exception(lastError);
                    }
                    else
                    {
                        string nextOperator = operators[i + 1];
                        if (!isAnumb(nextOperator) &&
                            nextOperator[0] != '(')
                        {
                            lastError = "ERROR 03: Incorrect syntax";
                            throw new Exception(lastError);
                        }
                    }
                    continue;
                }
            }

            if (count > 30)
            {
                lastError = "ERROR 08: Quantity of symbols more than 30";
                throw new Exception(lastError);
            }

            return formatExpr;
        }
        private string PolishInverseExpr(string formatExpr)
        {
            string[] el = formatExpr.Split(' ');

            string output = string.Empty;
            Stack<string> operStack = new Stack<string>();

            for (int i = 0; i < el.Length; i++)
            {
                string element = el[i];

                if (isAnumb(element))
                {
                    output += element + " ";
                    continue;
                }

                if (isAnOper(element))
                {
                    if (element[0] == '(')
                        operStack.Push(element);
                    else if (element[0] == ')')
                    {
                        string s = operStack.Pop();
                        while (s[0] != '(')
                        {
                            output += s + " ";
                            s = operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0)
                        {
                            if (orderOfOperations(element) <= orderOfOperations(operStack.Peek()))
                            {
                                output += operStack.Pop() + " ";
                            }
                        }

                        operStack.Push(element);
                    }
                }
            }

            while (operStack.Count > 0)
            {
                output += operStack.Pop() + " ";
            }

            if (output.EndsWith(" "))
            {
                output = output.Remove(output.Length - 1);
            }

            if (output.StartsWith(" "))
            {
                output = output.Remove(0, 1);
            }

            return output;
        }

        private string RunEstimate(string polishInverseExpr)
        {
            string[] elements = polishInverseExpr.Split(' ');

            long result = 0;
            Stack<long> temp = new Stack<long>();

            for (int i = 0; i < elements.Length; i++)
            {
                string element = elements[i];

                if (isAnumb(element))
                {
                    temp.Push(Int64.Parse(element));
                }
                else if (isAnOper(element))
                {
                    long a = temp.Pop();
                    long b = temp.Pop();

                    switch (element[0])
                    {
                        case '+': result = CalcClass.CalcClass.Add(b, a); break;
                        case '-': result = CalcClass.CalcClass.Sub(b, a); break;
                        case '*': result = CalcClass.CalcClass.Mult(b, a); break;
                        case '/': result = CalcClass.CalcClass.Div(b, a); break;
                        case 'm': result = CalcClass.CalcClass.Mod(b, a); break;
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek().ToString();
        }
    }
}