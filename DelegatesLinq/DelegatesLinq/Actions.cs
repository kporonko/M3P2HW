using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLinq
{
    internal class Actions
    {
        /// <summary>
        /// Gets the result of summing numbers.
        /// </summary>
        /// <value>
        /// Result of method sum sums.
        /// </value>
        public int Res { get; private set; } = 0;

        /// <summary>
        /// Method to count the result sum.
        /// </summary>
        /// <param name="list">The list of Delegates array.</param>
        /// <param name="numbers">Numbers array we want to sum.</param>
        /// <returns>Result of summing BOTH methods "Sum" returned values.</returns>
        public int Result(Delegate[] list, int[] numbers)
        {
            try
            {
                // i and j are for calling numbers from array.
                int i = 0;
                int j = 1;
                Res = 0;

                // Go through list of Delegates (we can consider it as Method array) by foreach loop and call it.
                foreach (var method in list)
                {
                    // The result of each call, returned value of both methods actually.
                    Res += Convert.ToInt32(method.DynamicInvoke(numbers[i], numbers[j]));
                    i += 2;
                    j += 2;
                }

                return Res;
            }
            catch (Exception)
            {
                Console.WriteLine("func was null");
            }

            return 0;
        }
    }
}
