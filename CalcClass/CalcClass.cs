
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public class CalcClass
    {
        public static string lastError { get; private set; }

        private static long checkInt(long a)
        {
            if (a < Int32.MinValue)
            {
                lastError = "ERROR 06: Very small for int";
                throw new Exception(lastError);
            }
            else if (a > Int32.MaxValue)
            {
                lastError = "ERROR 06: Very big for int";
                throw new Exception(lastError);
            }
            return a;
        }

        public static long Add(long a, long b)
        {
            checkInt(a);
            checkInt(b);
            return checkInt(a + b);
        }

        public static long Sub(long a, long b)
        {
            checkInt(a);
            checkInt(b);
            return checkInt(a - b);
        }

        public static long Mult(long a, long b)
        {
            checkInt(a);
            checkInt(b);
            return checkInt(a * b);
        }

        private static void checkZeroDiv(long a)
        {
            if (a == 0)
            {
                lastError = "Error 09: Division by zero";
                throw new Exception(lastError);
            }
        }

        public static long Div(long a, long b)
        {
            checkZeroDiv(b);
            checkInt(a);
            checkInt(b);
            return checkInt(a / b);
        }

        public static long Mod(long a, long b)
        {
            checkZeroDiv(b);
            checkInt(a);
            checkInt(b);
            return checkInt(a % b);
        }

        public static long ABS(long a)
        {
            checkInt(a);
            throw new Exception("Not executed");
        }

        public static long IABS(long a)
        {
            checkInt(a);
            throw new Exception("Not executed");
        }
    }
}