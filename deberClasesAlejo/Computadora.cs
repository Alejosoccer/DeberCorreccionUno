using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
    public class Computadora
    {

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public string Garantia { get; set; }


        // referencia que la computadora  tiene propietario
        public Cliente Propietario { get; set; }

        public string Encerder()
        {
            return "Su computadora si enciende";

        }
        public string Apagar()
        {
            return "Su computadora está apagada";
        }
    }
}