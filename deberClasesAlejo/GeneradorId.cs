using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
   public class GeneradorId
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public GeneradorId()
        {
            Id = random.Next();
        }

        public GeneradorId(int identificador)
        {
            Id = identificador;
        }

        public GeneradorId(string identificadorCadena)
        {
            Id = Convert.ToInt32(identificadorCadena);
        }
    }
}
