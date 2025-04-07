using System;
namespace Calcular_Resistencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aqui arrancamos el programa y lo hacemos funcionar dentro de el void iniciarApp
            iniciarApp();
        }

        static void iniciarApp()
        {
            ResistenciasArchivos Informacion = new ResistenciasArchivos();
            ResistenciasArchivos Resistencias = new ResistenciasArchivos();
            bool VerificarCase = false;
            string opcion;
            var OpcionesMenu = new ResistenciasArchivos();

            do
            {
                int caso = 0;
                int intentosMenu = 0; // Contador de intentos en el menú
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Bienvenido usuario a su app medidora de resistencias por excelencia");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Ingrese su opcion de manera numerica:");
                OpcionesMenu.OpcionesMenu();
                Console.Write("->");
                opcion = Console.ReadLine();

                while (intentosMenu < 3)
                {
                    if (opcion == "1" || opcion == "2" || opcion == "3")
                    {
                        caso = Convert.ToInt32(opcion);
                        break;
                    }
                    else
                    {
                        intentosMenu++;
                        if (intentosMenu < 3)
                        {
                            Console.WriteLine("Favor escriba una opcion correcta. Intento {0}/3", intentosMenu);
                            Console.Write("Pulse cualquier tecla para continuar. . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("*******************************************************************");
                            Console.WriteLine("Bienvenido usuario a su app medidora de resistencias por excelencia");
                            Console.WriteLine("*******************************************************************");
                            Console.WriteLine("Ingrese su opcion de manera numerica:");
                            OpcionesMenu.OpcionesMenu();
                            Console.Write("->");
                            opcion = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Número máximo de intentos alcanzado. Cerrando el programa...");
                            VerificarCase = true;
                            break;
                        }
                    }
                }

                switch (caso)
                {
                    case 1:
                        CalcularResistMenu();
                        break;
                    case 2:
                        Informacion.Info();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("MUCHAS GRACIAS POR UTILIZAR EL PROGRAMA");
                        Console.Write("Pulse cualquier tecla para continuar. . .");
                        VerificarCase = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (!VerificarCase);
        }

        static void CalcularResistMenu()
        {
            bool CerrarCalculadora = false;
            string banda1 = "";
            string banda2 = "";
            string banda3 = "";
            string banda4 = "";
            string banda5 = "";
            string banda6 = "";

            do
            {
                ResistenciasArchivos Resistencias = new ResistenciasArchivos();
                string nbandas;
                int NumBandasCase = 0;
                int intentosBandas = 0; // Contador de intentos para el número de bandas

                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("CALCULADORA DE RESISTENCIAS");
                Console.WriteLine("***************************");
                Console.WriteLine("INGRESE 0 PARA DIRIGIRSE AL MENU ANTERIOR");
                Console.WriteLine("");
                Console.Write("Ingrese el n bandas de su resistencia: ");
                nbandas = Console.ReadLine();

                if (nbandas == "0")
                {
                    CerrarCalculadora = true;
                    Console.Clear();
                }
                else
                {
                    while (intentosBandas < 3)
                    {
                        if (nbandas == "3" || nbandas == "4" || nbandas == "5" || nbandas == "6")
                        {
                            NumBandasCase = Convert.ToInt32(nbandas);
                            break;
                        }
                        else
                        {
                            intentosBandas++;
                            if (intentosBandas < 3)
                            {
                                Console.WriteLine("Porfavor ingrese un n bandas correcto. Intento {0}/3", intentosBandas);
                                Console.WriteLine("PARA MAS INFORMACION DIRIGASE A OPCION Nro 2.");
                                Console.WriteLine("Pulse cualquier tecla para continuar. . .");
                                Console.ReadKey();
                                Console.Clear();
                                Console.Write("Ingrese el n bandas de su resistencia: ");
                                nbandas = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Número máximo de intentos alcanzado.");
                                CerrarCalculadora = true;
                                break;
                            }
                        }
                    }
                }

                switch (NumBandasCase)
                {
                    case 3:
                        //trabajamos las bandas por medios de if y strings
                        Console.Write("Favor escribir el color de su primer banda:");
                        banda1 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su segunda banda: ");
                        banda2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su tercer banda: ");
                        banda3 = Console.ReadLine();
                        //aqui vamos a convertir lo que el usuario escriba a una cadena de 
                        //caracteres en minusculas
                        banda1 = banda1.ToLowerInvariant();
                        banda2 = banda2.ToLowerInvariant();
                        banda3 = banda3.ToLowerInvariant();

                        Resistencias.TresBandas(banda1, banda2, banda3);
                        break;
                    case 4:
                        Console.Write("Favor escribir el color de su primer banda:");
                        banda1 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su segunda banda: ");
                        banda2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su tercer banda: ");
                        banda3 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su cuarta banda: ");
                        banda4 = Console.ReadLine();
                        Console.WriteLine("");
                        //aqui vamos a convertir lo que el usuario escriba a una cadena de 
                        //caracteres en minusculas
                        banda1 = banda1.ToLowerInvariant();
                        banda2 = banda2.ToLowerInvariant();
                        banda3 = banda3.ToLowerInvariant();
                        banda4 = banda4.ToLowerInvariant();
                        Resistencias.CuatroBandas(banda1, banda2, banda3, banda4);
                        break;
                    case 5:
                        Console.Write("Favor escribir el color de su primer banda:");
                        banda1 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su segunda banda: ");
                        banda2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su tercer banda: ");
                        banda3 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su cuarta banda: ");
                        banda4 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su quinta banda: ");
                        banda5 = Console.ReadLine();
                        Console.WriteLine("");
                        //aqui vamos a convertir lo que el usuario escriba a una cadena de 
                        //caracteres en minusculas
                        banda1 = banda1.ToLowerInvariant();
                        banda2 = banda2.ToLowerInvariant();
                        banda3 = banda3.ToLowerInvariant();
                        banda4 = banda4.ToLowerInvariant();
                        banda5 = banda5.ToLowerInvariant();
                        Resistencias.CincoBandas(banda1, banda2, banda3, banda4, banda5);
                        break;
                    case 6:
                        Console.Write("Favor escribir el color de su primer banda:");
                        banda1 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su segunda banda: ");
                        banda2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su tercer banda: ");
                        banda3 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su cuarta banda: ");
                        banda4 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su quinta banda: ");
                        banda5 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Favor escribir el color de su sexta banda: ");
                        banda6 = Console.ReadLine();
                        Console.WriteLine("");
                        //aqui vamos a convertir lo que el usuario escriba a una cadena de 
                        //caracteres en minusculas
                        banda1 = banda1.ToLowerInvariant();
                        banda2 = banda2.ToLowerInvariant();
                        banda3 = banda3.ToLowerInvariant();
                        banda4 = banda4.ToLowerInvariant();
                        banda5 = banda5.ToLowerInvariant();
                        banda6 = banda6.ToLowerInvariant();
                        Resistencias.SeisBandas(banda1, banda2, banda3, banda4, banda5, banda6);
                        break;
                }
            }
            while (CerrarCalculadora != true);
        }
    }
}
