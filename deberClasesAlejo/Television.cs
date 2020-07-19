using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
    public class Television : Producto
    {
       
        public float Precio { get; set; }
        public string Garantia { get; set; }




        //metodos de acciones

        public string Encerder()
        {
            return "Su television si enciende";

        }
        public string Apagar()
        {
            return "Su television está apagada";
        }
    }
}

