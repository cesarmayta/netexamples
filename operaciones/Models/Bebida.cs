using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones.Models
{
    class Bebida
    {
        public String Nombre { get; set; }

        public int Cantidad { get; set; }

        public Bebida(string Nombre,int cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = cantidad;
        }

        public void Beberse(int cuantoBebdio)
        {
            this.Cantidad -= cuantoBebdio;
        }
    }
}
