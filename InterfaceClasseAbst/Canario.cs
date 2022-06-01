using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClasseAbst
{
    internal class Canario : Oviparo
    {
        public override void SeMovimentar()
        {
            Console.WriteLine("to voando");
        }
    }
}
