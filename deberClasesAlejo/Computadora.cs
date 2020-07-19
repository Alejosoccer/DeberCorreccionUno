using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
   // hereda los atrivutos de productos
    public class Computadora : Producto
    {

        public float Precio { get; set; }
        public string Garantia { get; set; }


           
        public string Encender()
        {
            return "Su computadora si enciende";

        }
        public string Apagar()
        {
            return "Su computadora está apagada";
        }
    }
}