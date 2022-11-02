using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood
{
    public static class Math
    {
        public const string NegativeArgument = "Argument cannot be negative number";
        public const string ArgumentTooLarge = "Argument is too large";
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), n, NegativeArgument);
            }
            try
            {

                long result = 1;
                for (int i = 2; i <= n; ++i)
                {
                    result *= i;
                }
                return result;

            }
            catch (OverflowException)
            {
                throw new ArgumentOutOfRangeException(nameof(n), n, ArgumentTooLarge);
            }
        }
    }
}
