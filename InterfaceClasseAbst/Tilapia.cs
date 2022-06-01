using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClasseAbst
{
    internal class Tilapia : Oviparo
    {
        public override void SeMovimentar()
        {
            Console.WriteLine("to nadando");
        }
    }
}
