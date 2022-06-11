using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLinq
{
    internal class Actions
    {
        public int Res { get; set; } = 0;
        public int Result(Func<int, int, int> myEvent, int x, int y)
        {
            try
            {
                var res = myEvent.Invoke(x, y);
                Res += res;
                return res;
            }
            catch (Exception)
            {
                Console.WriteLine("func was null");
            }

            return 0;
        }
    }
}
