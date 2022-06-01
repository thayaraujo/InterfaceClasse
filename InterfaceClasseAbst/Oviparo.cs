using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClasseAbst
{
    abstract class Oviparo : IAnimal
    {
        public void Procriar()
        {
            Console.WriteLine("Botei um ovo");
        }

        public virtual void SeMovimentar()
        {
            throw new NotImplementedException();
        }
    }
}
