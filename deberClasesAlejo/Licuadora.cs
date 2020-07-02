using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
    public class Licuadora
    {

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public string Garantia { get; set; }

        // referencia que la licuadora tiene propietario
        public Cliente Propietario { get; set; }
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
