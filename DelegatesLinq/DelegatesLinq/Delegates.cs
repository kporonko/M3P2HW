using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLinq
{
    internal class Delegates
    {
        public Delegates()
        {
            MyEvent += Sum;
            MyEvent += Sum;

            // I had to call this here, because only in this class i can call the method and PUSH MyEvent into it.
            Actions actions = new Actions();
            actions.Result(MyEvent, 3, 4);
        }

        public event Func<int, int, int> MyEvent;
        public Func<int, int, int> Func { get; set; }
        public int Sum(int x, int y) => x + y;
    }
}
