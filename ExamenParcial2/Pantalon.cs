using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2
{
    class Pantalon : Prenda
    {

        private Boolean bermuda;

        /*public Pantalon(bool bermuda)
        {
            this.bermuda = bermuda;
        }*/

        public bool Bermuda { get => bermuda; set => bermuda = value; }


        public int calcularPrecio()
        {
            if (bermuda)
            {
                Precio -= (Precio * 20) / 100;
            }
            if (Premium)
            {
                Precio += (Precio * 30) / 100;
            }

            return Precio * Cantidad;

        }

    }
}
