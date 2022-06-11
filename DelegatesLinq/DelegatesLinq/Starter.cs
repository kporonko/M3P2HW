using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLinq
{
    internal class Starter
    {
        public static void Start()
        {
            Delegates delegates = new Delegates();
            Actions actions = new Actions();
            Console.WriteLine(actions.Result(delegates.MyEvent, 3, 4));
        }
    }
}
