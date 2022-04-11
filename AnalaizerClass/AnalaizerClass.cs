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

    }
}