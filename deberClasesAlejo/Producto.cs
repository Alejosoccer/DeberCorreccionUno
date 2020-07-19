using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
   public class Producto : GeneradorId
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Cliente Propietario { get; set; }

        //Métodos virtuales
        public Producto() : base()
        {
        }


    }
}
