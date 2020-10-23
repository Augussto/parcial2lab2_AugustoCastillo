using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2
{
    class Camisa : Prenda
    {

        private Boolean mangaCorta;

       /*public Camisa(bool mangaCorta)
        {
            this.mangaCorta = mangaCorta;
        }*/

        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }


        public int calcularPrecio()
        {

            if (mangaCorta)
            {
                Precio -= (Precio * 10) / 100; 
            }
            if (Premium)
            {
                Precio += (Precio * 30) / 100;
            }

            return Precio * Cantidad;
        }
    }
}
