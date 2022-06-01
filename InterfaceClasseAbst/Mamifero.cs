using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClasseAbst
{
   abstract class Mamifero : IAnimal
    {
        public void Procriar()
        {
           Console.WriteLine("Estou grávida");
        }

        public virtual void SeMovimentar()
        {
            throw new NotImplementedException();
        }
    }
}
