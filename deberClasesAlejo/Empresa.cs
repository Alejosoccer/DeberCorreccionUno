using System;
using System.Collections.Generic;
using System.Text;

namespace deberClasesAlejo
{
    // Hereda de la clase GeneradorId
    class Empresa : GeneradorId
    {
        public string Nombre { get; set; }

        public Empresa() : base()
        { }

        public Empresa(int id) : base(id)
        { }

        public Empresa(string id) : base(id)
        { }
        public Computadora ConstruirComputadora(string modelo)
        {

            return new Computadora()
            {
                Marca = Nombre,
                Modelo = modelo
            };

        }


        public Licuadora ConstruirLicuadora(string modelo)
        {

            return new Licuadora()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }
        public Television ConstruirTelevision(string modelo)
        {

            return new Television()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }








    }
}
