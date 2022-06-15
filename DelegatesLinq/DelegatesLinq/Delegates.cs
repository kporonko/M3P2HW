using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLinq
{
    internal class Delegates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Delegates"/> class.
        /// </summary>
        public Delegates()
        {
            // Subscribing method Sum to the event two times.
            MyEvent += Sum;
            MyEvent += Sum;
        }

        public event Func<int, int, int> MyEvent;

        public Func<int, int, int> Func { get; set; }

        public int Sum(int x, int y) => x + y;

        /// <summary>
        /// Method calls the resultive method and create the paramethers we need to push into that method: arrau of delegates, and array of integers.
        /// </summary>
        /// <returns>Result of summing.</returns>
        public int Calc()
        {
            var list = MyEvent.GetInvocationList();

            Actions actions = new Actions();

            try
            {
                // Call the AskNumbers method to fill the int array and then the Result method.
                return actions.Result(list, AskNumbers());
            }
            catch (Exception)
            {
            }

            return 0;
        }

        /// <summary>
        /// Method asks user for 4 numbers he wants to sum.
        /// </summary>
        /// <returns>Array of chosen numbers.</returns>
        private int[] AskNumbers()
        {
            Console.WriteLine("Write 4 numbers");
            List<int> numbers = new List<int>();

            int temp = 0;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(temp);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return numbers.ToArray();
        }
    }
}
