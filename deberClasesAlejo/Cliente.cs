using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace deberClasesAlejo
{
    public class Cliente
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string CorreroElectronico { get; set; }



        Computadora miCompu; // TODO : crear propiedades
        Television miTv; // TODO : crear propiedades
        Licuadora miLicua; // TODO : crear propiedades


        // decimos que el cliente es dueño de los siguientes objetos
        public Computadora MiPc
        {

            get
            {
                return miCompu;

            }

            set
            {

                miCompu = value;
                //Estoy definiendo que la persona es dueño de objeto
                miCompu.Propietario = this;
            }
        }
        public Television Tv
        {

            get
            {
                return miTv;

            }

            set
            {

                miTv = value;
                //Estoy definiendo que la persona es dueño de objeto
                miTv.Propietario = this;
            }
        }

        public Licuadora Licu
        {

            get
            {
                return miLicua;

            }

            set
            {

                miLicua = value;
                //Estoy definiendo que la persona es dueño de objeto
                miLicua.Propietario = this;
            }
        }



        //metodos de persona
        public string Saludar(string nombre)
        {
            return ($" Hola como estas? {Nombre}  es un placer servirle mi nombre es  {nombre}");
        }


        public string ProductoUno()
        {
            if (miTv != null)

                return $"Tengo television {miTv.Modelo}";
            else
                return $"No tengo tv {miTv.Modelo}";
        }

        public string ProductoDos()
        {
            if (miLicua != null)

                return $"Tengo licuadora {miLicua.Modelo}";
            else
                return $"No tengo licuadora {miLicua.Modelo}";
        }

        public string ProductoTres()
        {
            if (MiPc != null)

                return $"Tengo computadora {MiPc.Marca}";
            else
                return $"No tengo computadora {MiPc.Marca} ";

            //llaves ultimas
        }
    }
}
        















