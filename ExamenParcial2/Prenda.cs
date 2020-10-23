using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2
{
    abstract class Prenda
    {

        private Boolean standard, premium;
        private int precio, cantidad;


        public bool Standard { get => standard; set => standard = value; }
        public bool Premium { get => premium; set => premium = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
