using System;

namespace evidencia_jhon_bayron_fajardo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la máquina expendedora");

            Console.WriteLine("¿Cuantas compras deseas realizar?");

            int num_compras = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("¿Cuanto dinero vas a gastar?");


            int saldo = Convert.ToInt32(Console.ReadLine());
            if (saldo > 0)
            {


                for (int i = 1; i <= num_compras; i++)
                {
                    int dia;
                    Console.Write("***Selecciona una opción***\n" +
                        "1. Jugo $800\n" +
                        "2. Paquete de papas $1.400\n" +
                        "3. Ponque $600 \n" +
                        "4. Mani $600 \n" +
                        "5. Gaseosa $1.200\n" +
                        "6. Galletas $400\n");
                    dia = Convert.ToInt32(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            int valor_jugo = 800;
                            saldo = saldo - valor_jugo;

                            if (saldo >= valor_jugo)
                            {
                                Console.WriteLine($"se te descontaron ${valor_jugo} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tu jugo :)) ");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra");
                            }
                            break;

                        case 2:
                            int valor_papas = 1400;
                            saldo = saldo - valor_papas;

                            if (saldo >= valor_papas)
                            {


                                Console.WriteLine($"se te descontaron ${valor_papas} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tus papas :)) ");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra");
                            }

                            break;
                        case 3:
                            int valor_ponque = 600;
                            saldo = saldo - valor_ponque;

                            if (saldo >= valor_ponque)
                            {


                                Console.WriteLine($"se te descontaron ${valor_ponque} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tu ponque");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra :(");
                            }
                            break;
                        case 4:
                            int valor_mani = 600;
                            saldo = saldo - valor_mani;

                            if (saldo >= valor_mani)
                            {


                                Console.WriteLine($"se te descontaron ${valor_mani} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tu mani");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra");
                            }

                            break;
                        case 5:
                            int valor_gaseosa = 1200;
                            saldo = saldo - valor_gaseosa;

                            if (saldo >= valor_gaseosa)
                            {


                                Console.WriteLine($"se te descontaron ${valor_gaseosa} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tu gaseosa");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra :/ ");
                            }
                            break;

                        case 6:
                            int valor_galletas = 400;
                            saldo = saldo - valor_galletas;
                            if (saldo >= valor_galletas)
                            {


                                Console.WriteLine($"se te descontaron ${valor_galletas} y tu restante es de : ${saldo} \n" +
                                    "Disfruta de tus galletas");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente saldo para realizar esta compra :c");
                            }
                            break;

                    }

                    Console.WriteLine("Cerrando programa...");
                }

            }
            else
            {
                Console.WriteLine("Sin saldo no puedes comprar nada :/ ");
            }
        }
    }
}
