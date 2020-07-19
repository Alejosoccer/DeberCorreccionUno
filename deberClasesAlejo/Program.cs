using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace deberClasesAlejo
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Bienvenido");
            // generamos para un numero randomico
            Random generador = new Random();

            //creo el objeto persona


            Television television = new Television();
            television.Id = generador.Next();
            television.Marca = "LG";
            television.Modelo = "Smart 32";
            television.Precio = 500;
            television.Garantia = "5 años";

            Licuadora licuadora = new Licuadora();
            licuadora.Id = generador.Next();
            licuadora.Marca = "Oster";
            licuadora.Modelo = "XX";
            licuadora.Precio = 100;
            licuadora.Garantia = "2 años";

            Computadora computadora = new Computadora();

            computadora.Id = 1;
            computadora.Marca = "Hp";
            computadora.Modelo = "LL";
            computadora.Precio = 700;
            computadora.Garantia = "3 años";

            Cliente cliente = new Cliente
            {
                id = 1,
                Nombre = "Alejadro",
                Apellido = "López",
                CorreroElectronico = "aelr238@gmail.com",
                Nacionalidad = "Ecuatoriano",
                Tv = television,
                MiPc = computadora,
                Licu = licuadora
            };

            // a quien voy a saludar
            string personaSaludar = "Juan";
            //llama al metodo saludar 
            // crea una variable saludo y se va hacer referencia a quien saludar y le agrego como valor Juan
            string saludo = cliente.Saludar(personaSaludar);
            Console.WriteLine(saludo);

            Console.ReadKey();
            //llamamos a los productos para que se imprima

            string producto1 = cliente.ProductoUno();
            Console.WriteLine(producto1);
            Console.ReadKey();

            string producto2 = cliente.ProductoDos();
            Console.WriteLine(producto2);
            Console.ReadKey();

            string producto3 = cliente.ProductoTres();
            Console.WriteLine(producto3);
            Console.ReadKey();

            
           

        }
        //sobrecargas de metodos 
        int a = 300;
        int b = 200;
        int c = 400;
        public int SumarPrecio(int a, int b)
        {
            return a + b ;
        }
        public int SumarPrecio (int a, int b, int c)
        {
            return a + b + c;
        }




    }

    
}