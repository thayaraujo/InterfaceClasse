using System;

namespace InterfaceClasseAbst
{
    class Program
    {
        static void Main(string[] args)
        {
            var canguru = new Canguru();
            var tilapia = new Tilapia();
            var canario = new Canario();
            var arrAnimal = new IAnimal[3];


            arrAnimal[0] = canguru;
            arrAnimal[1] = tilapia;
            arrAnimal[2] = canario;


            foreach (var item in arrAnimal)
            {
                item.Procriar();
                item.SeMovimentar();
            }
        }
    }
}

