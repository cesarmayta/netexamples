using operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca Cola",1000);
            bebida.Beberse(500);

            Console.WriteLine(bebida.Cantidad);
            Console.ReadKey();
        }
    }
}
