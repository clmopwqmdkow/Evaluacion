using System;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alejandra Arcega calderon 331-01
            //Sintaxis para definir una función
            /*
            tipo_de_dato_devuelto nombre_de función(parametros)
            {
                bloque_de_instrucciones
            }
            */
            //Definir un cilo para imprimir la siguiente secuencia:2, 4, 6, 9, 12, 15, 19, 2, 27
            int a = 2;
            while (a <= 27)
            {
                if (a >= 15)
                {

                    Console.WriteLine($"A:{a}");
                    a += 4;
                }
                if (a % 3 == 0)
                {
                    Console.WriteLine($"A:{a}");
                    a += 3;
                }
                if (a < 10)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine($"A:{a}");
                        a += 2;
                    }
                }

            }
            //Declarar e inicializar 2 variables: incio, limite
            int inicio = 3;
            int limite = 20;
            if (inicio * limite < 8 && inicio > limite)
            {
                int q = 10;
                while (q > 1)
                {
                    Console.WriteLine($"Q: {q}");
                    q -= 1;
                }
            }
            else
            {
                int f = 1;
                while (f < 10)
                {
                    Console.WriteLine($"f: {f}");
                    f += 1;
                }
            }
            //Definir e invocar una función para determinar si un numero es multiplo de 5

            double funcion(int h = 4)
            {
                if (h % 5 = 0)
                {
                    bool h = true;
                    Console.WriteLine($"H:{h}");
                }
                else
                {
                    bool h = false;
                    Console.WriteLine($"H:{h}");
                }
            }
            funcion();
            //Definir e invocar una funcion vacia para imprimrir
            void cosa()
            {
                int z = 1;
                if (z == 1)
                {
                    str algo = "Programación II";
                }
                Console.WriteLine($"Examen:{algo}");
            }
            cosa;
        

        }
    }

}
