using System;
using System.Linq;
namespace Calcular_Resistencias
{
   
    
    
    internal class ResistenciasArchivos
    {
        /*Estas son las opciones que tendra el menu*/
        private string[] _opcionesDelMenu = {"Calcular Resistencia","Informacion","Salir"};
        //AQUI COMIENZAN LOS ATRIBUTOS
        //Estos son los valores numericos de las resistencias
        public string[] _NombreNumeric = { "negro", "cafe", "rojo", "naranja", "amarillo", "verde", "azul", "violeta", "gris", "blanco" };
        private int _NumNegro = 0;
        private int _NumCafe = 1;
        private int _NumRojo = 2;
        private int _NumNaranja = 3;
        private int _NumAmarillo = 4;
        private int _NumVerde = 5;
        private int _NumAzul = 6;
        private int _NumVioleta = 7;
        private int _NumGris = 8;
        private int _NumBlanco = 9;

        //ESTOS SON LOS VALORES MULTIPLICATIVOS DE LAS RESISTENCIAS
        public string[] _NombreMult = { "negro","cafe","rojo","naranja","amarillo","verde","azul","violeta","gris","blanco","oro","plata" };
        private  double _MultNegro= 1;
        private double _MultCafe = Math.Pow(10,1);
        private double _MultRojo = Math.Pow(10,2);
        private double _MultNaranja = Math.Pow(10,3);
        private double _MultAmarillo = Math.Pow(10,4);
        private double _MultVerde = Math.Pow(10,5);
        private double _MultAzul = Math.Pow(10,6);
        private double _MultVioleta = Math.Pow(10,7);
        private double _MultGris = Math.Pow(10,8);
        private double _MultBlanco = Math.Pow(10,9);
        private double _MultOro = Math.Pow(10,-1);
        private double _MultPlata = Math.Pow(10,-2);

        //AQUI VAMOS A PONER LAS DE LA TOLERANCIA
        public string[] _NombreTolerancia = { "cafe", "rojo", "verde","azul", "violeta","gris","oro","plata"};
        private string _TolCafe = "±1%";
        private string _TolRojo = "±2%";
        private string _TolVerde = "±0.5%";
        private string _TolAzul = "±0.25%";
        private string _TolVioleta = "±0.1%";
        private string _TolGris = "±0.05%";
        private string _TolOro = "±5%";
        private string _TolPlata = "±10%";
        //Y por aqui las que miden coeficiente de temperatura
        public string[] _NombreCoeficiente = { "negro", "cafe", "rojo", "naranja", "amarillo", "verde", "azul", "violeta", "gris" };
        private string _CoefNegro = "250 ppm/°C";
        private string _CoefCafe = "100 ppm/°C";
        private string _CoefRojo = "50 ppm/°C";
        private string _CoefNaranja = "15 ppm/°C";
        private string _Coefamarillo = "25 ppm/°C";
        private string _CoefVerde = "20 ppm/°C";
        private string _CoefAzul = "10 ppm/°C";
        private string _CoefVioleta = "5 ppm/°C";
        private string _CoefGris = "1 ppm/°C";
        //A partir de aqui trabajaremos los metodos que se usen en el programa
        //Vamos a crear un metodo para cada tipo de bandas trabajables
        public void TresBandas(string banda1, string banda2, string Mult)
        {
            int Primerbanda = 0;
            int Segundabanda = 0;
            int ConcatBandas = 0;
            double multiplicador = 0.0;
            double ValorResistencia= 0.0;
            if (_NombreNumeric.Contains(banda1))
            {
                if (banda1 == "negro")
                {
                    Primerbanda = _NumNegro;
                }else if (banda1 == "cafe")
                {
                    Primerbanda = _NumCafe;
                }else if (banda1 == "rojo") 
                {
                    Primerbanda = _NumRojo;
                }else if (banda1 == "naranja")
                {
                    Primerbanda = _NumNaranja;
                }
                else if (banda1 == "amarillo")
                {
                    Primerbanda = _NumAmarillo;
                }
                else if (banda1 == "verde")
                {
                    Primerbanda = _NumVerde;
                }
                else if (banda1 == "azul")
                {
                    Primerbanda = _NumAzul;
                }
                else if (banda1 == "violeta")
                {
                    Primerbanda = _NumVioleta;
                }
                else if (banda1 == "gris")
                {
                    Primerbanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Primerbanda = _NumBlanco;
                }
            }
            else 
            { 
                Console.WriteLine("BANDA 1 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreNumeric.Contains(banda2))
            {
                if (banda2 == "negro")
                {
                    Segundabanda = _NumNegro;
                }
                else if (banda2 == "cafe")
                {
                    Segundabanda = _NumCafe;
                }
                else if (banda2 == "rojo")
                {
                    Segundabanda = _NumRojo;
                }
                else if (banda2 == "naranja")
                {
                    Segundabanda = _NumNaranja;
                }
                else if (banda2 == "amarillo")
                {
                    Segundabanda = _NumAmarillo;
                }
                else if (banda2 == "verde")
                {
                    Segundabanda = _NumVerde;
                }
                else if (banda2 == "azul")
                {
                    Segundabanda = _NumAzul;
                }
                else if (banda2 == "violeta")
                {
                    Segundabanda = _NumVioleta;
                }
                else if (banda2 == "gris")
                {
                    Segundabanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Segundabanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 2 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreMult.Contains(Mult))
            {
                if (Mult == "negro")
                {
                    multiplicador = _MultNegro;
                }
                else if (Mult == "cafe")
                {
                    multiplicador = _MultCafe;
                }
                else if (Mult == "rojo")
                {
                    multiplicador = _MultRojo;
                }
                else if (Mult == "naranja")
                {
                    multiplicador = _MultNaranja;
                }
                else if (Mult == "amarillo")
                {
                    multiplicador = _MultAmarillo;
                }
                else if (Mult == "verde")
                {
                    multiplicador = _MultVerde;
                }
                else if (Mult == "azul")
                {
                    multiplicador = _MultAzul;
                }
                else if (Mult == "violeta")
                {
                    multiplicador = _MultVioleta;
                }
                else if (Mult == "gris")
                {
                    multiplicador = _MultGris;
                }
                else if (Mult == "blanco")
                {
                    multiplicador = _MultBlanco;
                }
                else if (Mult == "oro")
                {
                    multiplicador = _MultOro;
                }
                else if (Mult == "plata")
                {
                    multiplicador = _MultPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 3 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            //Luego de verificar que lo de las bandas sea valido
            //Concatenamos las bandas
            ConcatBandas = Primerbanda * 10 + Segundabanda;
            ValorResistencia = ConcatBandas * multiplicador;
            if (ValorResistencia >= 0 && ValorResistencia <= 9)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmio. Con tolerancia ±20%");
            }else if (ValorResistencia >= 10 && ValorResistencia <= 999) 
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmios. Con tolerancia ±20%");
            }else if (ValorResistencia >= 1000 && ValorResistencia <= 999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia/1000} Kiloohmios. Con tolerancia ±20%");
            }
            else if (ValorResistencia >= 1000000 && ValorResistencia <= 999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia/1000000} Megaohmios. Con tolerancia ±20%");
            }
            else if (ValorResistencia >= 1000000000 && ValorResistencia <= 999999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia/ 1000000000} Gigaohmios. Con tolerancia ±20%");
            }
            //NO ponemos tera porque no se va a utilizar con nuestras bandas de colores asi que lo dejamos hasta giga

            Console.Write("Pulse cualquier tecla para continuar. . .");
            Console.ReadKey();
        }
        public void CuatroBandas(string banda1, string banda2, string Mult, string Tolerancia)
        {
            int Primerbanda = 0;
            int Segundabanda = 0;
            int ConcatBandas = 0;
            double multiplicador = 0.0;
            double ValorResistencia = 0.0;
            string ValorTolerancia = "";
            if (_NombreNumeric.Contains(banda1))
            {
                if (banda1 == "negro")
                {
                    Primerbanda = _NumNegro;
                }
                else if (banda1 == "cafe")
                {
                    Primerbanda = _NumCafe;
                }
                else if (banda1 == "rojo")
                {
                    Primerbanda = _NumRojo;
                }
                else if (banda1 == "naranja")
                {
                    Primerbanda = _NumNaranja;
                }
                else if (banda1 == "amarillo")
                {
                    Primerbanda = _NumAmarillo;
                }
                else if (banda1 == "verde")
                {
                    Primerbanda = _NumVerde;
                }
                else if (banda1 == "azul")
                {
                    Primerbanda = _NumAzul;
                }
                else if (banda1 == "violeta")
                {
                    Primerbanda = _NumVioleta;
                }
                else if (banda1 == "gris")
                {
                    Primerbanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Primerbanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 1 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreNumeric.Contains(banda2))
            {
                if (banda2 == "negro")
                {
                    Segundabanda = _NumNegro;
                }
                else if (banda2 == "cafe")
                {
                    Segundabanda = _NumCafe;
                }
                else if (banda2 == "rojo")
                {
                    Segundabanda = _NumRojo;
                }
                else if (banda2 == "naranja")
                {
                    Segundabanda = _NumNaranja;
                }
                else if (banda2 == "amarillo")
                {
                    Segundabanda = _NumAmarillo;
                }
                else if (banda2 == "verde")
                {
                    Segundabanda = _NumVerde;
                }
                else if (banda2 == "azul")
                {
                    Segundabanda = _NumAzul;
                }
                else if (banda2 == "violeta")
                {
                    Segundabanda = _NumVioleta;
                }
                else if (banda2 == "gris")
                {
                    Segundabanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Segundabanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 2 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreMult.Contains(Mult))
            {
                if (Mult == "negro")
                {
                    multiplicador = _MultNegro;
                }
                else if (Mult == "cafe")
                {
                    multiplicador = _MultCafe;
                }
                else if (Mult == "rojo")
                {
                    multiplicador = _MultRojo;
                }
                else if (Mult == "naranja")
                {
                    multiplicador = _MultNaranja;
                }
                else if (Mult == "amarillo")
                {
                    multiplicador = _MultAmarillo;
                }
                else if (Mult == "verde")
                {
                    multiplicador = _MultVerde;
                }
                else if (Mult == "azul")
                {
                    multiplicador = _MultAzul;
                }
                else if (Mult == "violeta")
                {
                    multiplicador = _MultVioleta;
                }
                else if (Mult == "gris")
                {
                    multiplicador = _MultGris;
                }
                else if (Mult == "blanco")
                {
                    multiplicador = _MultBlanco;
                }
                else if (Mult == "oro")
                {
                    multiplicador = _MultOro;
                }
                else if (Mult == "plata")
                {
                    multiplicador = _MultPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 3 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreTolerancia.Contains(Tolerancia))
            {
            if (Tolerancia == "cafe")
                {
                    ValorTolerancia = _TolCafe;
                }
                else if (Tolerancia == "rojo")
                {
                    ValorTolerancia = _TolRojo;
                }
                else if (Tolerancia == "verde")
                {
                    ValorTolerancia = _TolVerde;
                }
                else if (Tolerancia == "azul")
                {
                    ValorTolerancia = _TolAzul;
                }
                else if (Tolerancia == "violeta")
                {
                    ValorTolerancia = _TolVioleta;
                }
                else if (Tolerancia == "gris")
                {
                    ValorTolerancia = _TolGris;
                }
                else if (Tolerancia == "oro")
                {
                    ValorTolerancia = _TolOro;
                }
                else if (Tolerancia == "plata")
                {
                    ValorTolerancia = _TolPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 4 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            //Luego de verificar que lo de las bandas sea valido
            //Concatenamos las bandas
            ConcatBandas = Primerbanda * 10 + Segundabanda;
            ValorResistencia = ConcatBandas * multiplicador;
            if (ValorResistencia >= 0 && ValorResistencia <= 9)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmio. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 10 && ValorResistencia <= 999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000 && ValorResistencia <= 999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000} Kiloohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000000 && ValorResistencia <= 999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000} Megaohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000000000 && ValorResistencia <= 999999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000000} Gigaohmios. Con tolerancia del {ValorTolerancia}");
            }
            //NO ponemos tera porque no se va a utilizar con nuestras bandas de colores asi que lo dejamos hasta giga

            Console.Write("Pulse cualquier tecla para continuar. . .");
            Console.ReadKey();
        }
        public void CincoBandas(string banda1, string banda2, string banda3, string Mult, string Tolerancia)
        {
            int Primerbanda = 0;
            int Segundabanda = 0;
            int TerceraBanda = 0;
            int ConcatBandas = 0;
            double multiplicador = 0.0;
            double ValorResistencia = 0.0;
            string ValorTolerancia = "";
            if (_NombreNumeric.Contains(banda1))
            {
                if (banda1 == "negro")
                {
                    Primerbanda = _NumNegro;
                }
                else if (banda1 == "cafe")
                {
                    Primerbanda = _NumCafe;
                }
                else if (banda1 == "rojo")
                {
                    Primerbanda = _NumRojo;
                }
                else if (banda1 == "naranja")
                {
                    Primerbanda = _NumNaranja;
                }
                else if (banda1 == "amarillo")
                {
                    Primerbanda = _NumAmarillo;
                }
                else if (banda1 == "verde")
                {
                    Primerbanda = _NumVerde;
                }
                else if (banda1 == "azul")
                {
                    Primerbanda = _NumAzul;
                }
                else if (banda1 == "violeta")
                {
                    Primerbanda = _NumVioleta;
                }
                else if (banda1 == "gris")
                {
                    Primerbanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Primerbanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 1 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreNumeric.Contains(banda2))
            {
                if (banda2 == "negro")
                {
                    Segundabanda = _NumNegro;
                }
                else if (banda2 == "cafe")
                {
                    Segundabanda = _NumCafe;
                }
                else if (banda2 == "rojo")
                {
                    Segundabanda = _NumRojo;
                }
                else if (banda2 == "naranja")
                {
                    Segundabanda = _NumNaranja;
                }
                else if (banda2 == "amarillo")
                {
                    Segundabanda = _NumAmarillo;
                }
                else if (banda2 == "verde")
                {
                    Segundabanda = _NumVerde;
                }
                else if (banda2 == "azul")
                {
                    Segundabanda = _NumAzul;
                }
                else if (banda2 == "violeta")
                {
                    Segundabanda = _NumVioleta;
                }
                else if (banda2 == "gris")
                {
                    Segundabanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Segundabanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 2 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreNumeric.Contains(banda3))
            {
                if (banda3 == "negro")
                {
                    TerceraBanda = _NumNegro;
                }
                else if (banda3 == "cafe")
                {
                    TerceraBanda = _NumCafe;
                }
                else if (banda3 == "rojo")
                {
                    TerceraBanda = _NumRojo;
                }
                else if (banda3 == "naranja")
                {
                    TerceraBanda = _NumNaranja;
                }
                else if (banda3 == "amarillo")
                {
                    TerceraBanda = _NumAmarillo;
                }
                else if (banda3 == "verde")
                {
                    TerceraBanda = _NumVerde;
                }
                else if (banda3 == "azul")
                {
                    TerceraBanda = _NumAzul;
                }
                else if (banda3 == "violeta")
                {
                    TerceraBanda = _NumVioleta;
                }
                else if (banda3 == "gris")
                {
                    TerceraBanda = _NumGris;
                }
                else if (banda3 == "blanco")
                {
                    TerceraBanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 3 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreMult.Contains(Mult))
            {
                if (Mult == "negro")
                {
                    multiplicador = _MultNegro;
                }
                else if (Mult == "cafe")
                {
                    multiplicador = _MultCafe;
                }
                else if (Mult == "rojo")
                {
                    multiplicador = _MultRojo;
                }
                else if (Mult == "naranja")
                {
                    multiplicador = _MultNaranja;
                }
                else if (Mult == "amarillo")
                {
                    multiplicador = _MultAmarillo;
                }
                else if (Mult == "verde")
                {
                    multiplicador = _MultVerde;
                }
                else if (Mult == "azul")
                {
                    multiplicador = _MultAzul;
                }
                else if (Mult == "violeta")
                {
                    multiplicador = _MultVioleta;
                }
                else if (Mult == "gris")
                {
                    multiplicador = _MultGris;
                }
                else if (Mult == "blanco")
                {
                    multiplicador = _MultBlanco;
                }
                else if (Mult == "oro")
                {
                    multiplicador = _MultOro;
                }
                else if (Mult == "plata")
                {
                    multiplicador = _MultPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 4 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreTolerancia.Contains(Tolerancia))
            {
                if (Tolerancia == "cafe")
                {
                    ValorTolerancia = _TolCafe;
                }
                else if (Tolerancia == "rojo")
                {
                    ValorTolerancia = _TolRojo;
                }
                else if (Tolerancia == "verde")
                {
                    ValorTolerancia = _TolVerde;
                }
                else if (Tolerancia == "azul")
                {
                    ValorTolerancia = _TolAzul;
                }
                else if (Tolerancia == "violeta")
                {
                    ValorTolerancia = _TolVioleta;
                }
                else if (Tolerancia == "gris")
                {
                    ValorTolerancia = _TolGris;
                }
                else if (Tolerancia == "oro")
                {
                    ValorTolerancia = _TolOro;
                }
                else if (Tolerancia == "plata")
                {
                    ValorTolerancia = _TolPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 5 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            //Luego de verificar que lo de las bandas sea valido
            //Concatenamos las bandas
            ConcatBandas = Primerbanda * 100 + Segundabanda * 10 + TerceraBanda;
            ValorResistencia = ConcatBandas * multiplicador;
            if (ValorResistencia >= 0 && ValorResistencia <= 9)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmio. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 10 && ValorResistencia <= 999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000 && ValorResistencia <= 999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000} Kiloohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000000 && ValorResistencia <= 999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000} Megaohmios. Con tolerancia del {ValorTolerancia}");
            }
            else if (ValorResistencia >= 1000000000 && ValorResistencia <= 999999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000000} Gigaohmios. Con tolerancia del {ValorTolerancia}");
            }
            //NO ponemos tera porque no se va a utilizar con nuestras bandas de colores asi que lo dejamos hasta giga

            Console.Write("Pulse cualquier tecla para continuar. . .");
            Console.ReadKey();
        }
        //recordamos que el coef es el coeficiente de temperatura
        public void SeisBandas(string banda1, string banda2, string banda3, string Mult, string Tolerancia, string COEF)
        {

            int Primerbanda = 0;
            int Segundabanda = 0;
            int TerceraBanda = 0;
            int ConcatBandas = 0;
            double multiplicador = 0.0;
            double ValorResistencia = 0.0;
            string ValorTolerancia = "", ValorCoeficiente = "";
            if (_NombreNumeric.Contains(banda1))
            {
                if (banda1 == "negro")
                {
                    Primerbanda = _NumNegro;
                }
                else if (banda1 == "cafe")
                {
                    Primerbanda = _NumCafe;
                }
                else if (banda1 == "rojo")
                {
                    Primerbanda = _NumRojo;
                }
                else if (banda1 == "naranja")
                {
                    Primerbanda = _NumNaranja;
                }
                else if (banda1 == "amarillo")
                {
                    Primerbanda = _NumAmarillo;
                }
                else if (banda1 == "verde")
                {
                    Primerbanda = _NumVerde;
                }
                else if (banda1 == "azul")
                {
                    Primerbanda = _NumAzul;
                }
                else if (banda1 == "violeta")
                {
                    Primerbanda = _NumVioleta;
                }
                else if (banda1 == "gris")
                {
                    Primerbanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Primerbanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 1 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreNumeric.Contains(banda2))
            {
                if (banda2 == "negro")
                {
                    Segundabanda = _NumNegro;
                }
                else if (banda2 == "cafe")
                {
                    Segundabanda = _NumCafe;
                }
                else if (banda2 == "rojo")
                {
                    Segundabanda = _NumRojo;
                }
                else if (banda2 == "naranja")
                {
                    Segundabanda = _NumNaranja;
                }
                else if (banda2 == "amarillo")
                {
                    Segundabanda = _NumAmarillo;
                }
                else if (banda2 == "verde")
                {
                    Segundabanda = _NumVerde;
                }
                else if (banda2 == "azul")
                {
                    Segundabanda = _NumAzul;
                }
                else if (banda2 == "violeta")
                {
                    Segundabanda = _NumVioleta;
                }
                else if (banda2 == "gris")
                {
                    Segundabanda = _NumGris;
                }
                else if (banda1 == "blanco")
                {
                    Segundabanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 2 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreNumeric.Contains(banda3))
            {
                if (banda3 == "negro")
                {
                    TerceraBanda = _NumNegro;
                }
                else if (banda3 == "cafe")
                {
                    TerceraBanda = _NumCafe;
                }
                else if (banda3 == "rojo")
                {
                    TerceraBanda = _NumRojo;
                }
                else if (banda3 == "naranja")
                {
                    TerceraBanda = _NumNaranja;
                }
                else if (banda3 == "amarillo")
                {
                    TerceraBanda = _NumAmarillo;
                }
                else if (banda3 == "verde")
                {
                    TerceraBanda = _NumVerde;
                }
                else if (banda3 == "azul")
                {
                    TerceraBanda = _NumAzul;
                }
                else if (banda3 == "violeta")
                {
                    TerceraBanda = _NumVioleta;
                }
                else if (banda3 == "gris")
                {
                    TerceraBanda = _NumGris;
                }
                else if (banda3 == "blanco")
                {
                    TerceraBanda = _NumBlanco;
                }
            }
            else
            {
                Console.WriteLine("BANDA 3 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");

            }
            if (_NombreMult.Contains(Mult))
            {
                if (Mult == "negro")
                {
                    multiplicador = _MultNegro;
                }
                else if (Mult == "cafe")
                {
                    multiplicador = _MultCafe;
                }
                else if (Mult == "rojo")
                {
                    multiplicador = _MultRojo;
                }
                else if (Mult == "naranja")
                {
                    multiplicador = _MultNaranja;
                }
                else if (Mult == "amarillo")
                {
                    multiplicador = _MultAmarillo;
                }
                else if (Mult == "verde")
                {
                    multiplicador = _MultVerde;
                }
                else if (Mult == "azul")
                {
                    multiplicador = _MultAzul;
                }
                else if (Mult == "violeta")
                {
                    multiplicador = _MultVioleta;
                }
                else if (Mult == "gris")
                {
                    multiplicador = _MultGris;
                }
                else if (Mult == "blanco")
                {
                    multiplicador = _MultBlanco;
                }
                else if (Mult == "oro")
                {
                    multiplicador = _MultOro;
                }
                else if (Mult == "plata")
                {
                    multiplicador = _MultPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 4 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreTolerancia.Contains(Tolerancia))
            {
                if (Tolerancia == "cafe")
                {
                    ValorTolerancia = _TolCafe;
                }
                else if (Tolerancia == "rojo")
                {
                    ValorTolerancia = _TolRojo;
                }
                else if (Tolerancia == "verde")
                {
                    ValorTolerancia = _TolVerde;
                }
                else if (Tolerancia == "azul")
                {
                    ValorTolerancia = _TolAzul;
                }
                else if (Tolerancia == "violeta")
                {
                    ValorTolerancia = _TolVioleta;
                }
                else if (Tolerancia == "gris")
                {
                    ValorTolerancia = _TolGris;
                }
                else if (Tolerancia == "oro")
                {
                    ValorTolerancia = _TolOro;
                }
                else if (Tolerancia == "plata")
                {
                    ValorTolerancia = _TolPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 5 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreMult.Contains(Mult))
            {
                if (Mult == "negro")
                {
                    multiplicador = _MultNegro;
                }
                else if (Mult == "cafe")
                {
                    multiplicador = _MultCafe;
                }
                else if (Mult == "rojo")
                {
                    multiplicador = _MultRojo;
                }
                else if (Mult == "naranja")
                {
                    multiplicador = _MultNaranja;
                }
                else if (Mult == "amarillo")
                {
                    multiplicador = _MultAmarillo;
                }
                else if (Mult == "verde")
                {
                    multiplicador = _MultVerde;
                }
                else if (Mult == "azul")
                {
                    multiplicador = _MultAzul;
                }
                else if (Mult == "violeta")
                {
                    multiplicador = _MultVioleta;
                }
                else if (Mult == "gris")
                {
                    multiplicador = _MultGris;
                }
                else if (Mult == "blanco")
                {
                    multiplicador = _MultBlanco;
                }
                else if (Mult == "oro")
                {
                    multiplicador = _MultOro;
                }
                else if (Mult == "plata")
                {
                    multiplicador = _MultPlata;
                }
            }
            else
            {
                Console.WriteLine("BANDA 4 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            if (_NombreCoeficiente.Contains(COEF))
            {
                if (COEF == "negro")
                {
                    ValorCoeficiente = _CoefNegro;
                }else if (COEF == "cafe")
                {
                    ValorCoeficiente = _CoefCafe;
                }
                else if (COEF == "rojo")
                {
                    ValorCoeficiente = _CoefRojo;
                }
                else if (COEF == "naranja")
                {
                    ValorCoeficiente = _CoefNaranja;
                }
                else if (COEF == "amarillo")
                {
                    ValorCoeficiente = _Coefamarillo;
                }
                else if (COEF == "verde")
                {
                    ValorCoeficiente = _CoefVerde;
                }
                else if (COEF == "azul")
                {
                    ValorCoeficiente = _CoefAzul;
                }
                else if (COEF == "violeta")
                {
                    ValorCoeficiente = _CoefVioleta;
                }
                else if (COEF == "gris")
                {
                    ValorCoeficiente = _CoefGris;
                }
            }
            else
            {
                Console.WriteLine("BANDA 6 INCORRECTA");
                Console.WriteLine("Para mas informacion opcion info (Nro 2.)");
                Console.Write("Pulse cualquier tecla para continuar. . .");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            //Luego de verificar que lo de las bandas sea valido
            //Concatenamos las bandas
            ConcatBandas = Primerbanda * 100 + Segundabanda * 10 + TerceraBanda;
            ValorResistencia = ConcatBandas * multiplicador;
            if (ValorResistencia >= 0 && ValorResistencia <= 9)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmio. \nCon tolerancia del {ValorTolerancia}. \nY Coeficiente de temperatura {ValorCoeficiente}");
            }
            else if (ValorResistencia >= 10 && ValorResistencia <= 999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia} Ohmios. \nCon tolerancia del {ValorTolerancia}. \nY Coeficiente de temperatura {ValorCoeficiente}");
            }
            else if (ValorResistencia >= 1000 && ValorResistencia <= 999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000} Kiloohmios. \nCon tolerancia del {ValorTolerancia}. \nY Coeficiente de temperatura {ValorCoeficiente}");
            }
            else if (ValorResistencia >= 1000000 && ValorResistencia <= 999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000} Megaohmios. \nCon tolerancia del {ValorTolerancia}. \nY Coeficiente de temperatura {ValorCoeficiente}");
            }
            else if (ValorResistencia >= 1000000000 && ValorResistencia <= 999999999999)
            {
                Console.WriteLine($"El valor de su resistencia es de: {ValorResistencia / 1000000000} Gigaohmios. \nCon tolerancia del {ValorTolerancia}. \nY Coeficiente de temperatura {ValorCoeficiente}");
            }
            //NO ponemos tera porque no se va a utilizar con nuestras bandas de colores asi que lo dejamos hasta giga

            Console.Write("Pulse cualquier tecla para continuar. . .");
            Console.ReadKey();
        }

        //Desde aqui generaremos el menu del programa//
        public void OpcionesMenu()
        {
            int LongitudMenu = _opcionesDelMenu.Length;
            for (int i = 1; i <= LongitudMenu; i++) 
            {
                Console.WriteLine($"{i}. {_opcionesDelMenu[i-1]}");
            }
        }

            public void Info()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("                  ¿POR QUÉ LAS RESISTENCIAS TIENEN                  ");
            Console.WriteLine("                      DE 3 A 6 BANDAS DE COLORES?                   ");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Las bandas de colores en una resistencia indican su valor ohmico,");
            Console.WriteLine("tolerancia y, en algunos casos, el coeficiente térmico.            ");
            Console.WriteLine("");
            Console.WriteLine("► 3 BANDAS:");
            Console.WriteLine("   - Primera y segunda banda: dígitos significativos.");
            Console.WriteLine("   - Tercera banda: multiplicador.");
            Console.WriteLine("   - No indican tolerancia (se asume ±20%).");
            Console.WriteLine("");
            Console.WriteLine("► 4 BANDAS:");
            Console.WriteLine("   - Primera y segunda banda: dígitos.");
            Console.WriteLine("   - Tercera banda: multiplicador.");
            Console.WriteLine("   - Cuarta banda: tolerancia.");
            Console.WriteLine("");
            Console.WriteLine("► 5 BANDAS:");
            Console.WriteLine("   - Primera, segunda y tercera: dígitos.");
            Console.WriteLine("   - Cuarta banda: multiplicador.");
            Console.WriteLine("   - Quinta banda: tolerancia.");
            Console.WriteLine("");
            Console.WriteLine("► 6 BANDAS:");
            Console.WriteLine("   - Igual que las de 5 bandas, pero con:");
            Console.WriteLine("   - Sexta banda: coeficiente térmico (ppm/°C).");
            Console.WriteLine("");
            Console.WriteLine("✱ No se utilizan más de 6 bandas porque no se necesita más         ");
            Console.WriteLine("información práctica en componentes estándar. Más bandas harían    ");
            Console.WriteLine("la lectura más compleja sin agregar utilidad.                      ");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine(" Pulse cualquier tecla para continuar con la informacion ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("                   TABLA DE COLORES DE RESISTENCIAS                ");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine(" Color     | Dígito | Multiplicador      | Tolerancia  | Térmico (ppm/°C)");
            Console.WriteLine("-----------|--------|--------------------|-------------|------------------");
            Console.WriteLine(" Negro     |   0    | x1                 |     —       | 250");
            Console.WriteLine(" Marrón    |   1    | x10                |   ±1%       | 100");
            Console.WriteLine(" Rojo      |   2    | x100               |   ±2%       | 50");
            Console.WriteLine(" Naranja   |   3    | x1,000             |     —       | 15");
            Console.WriteLine(" Amarillo  |   4    | x10,000            |     —       | 25");
            Console.WriteLine(" Verde     |   5    | x100,000           |  ±0.5%      | —");
            Console.WriteLine(" Azul      |   6    | x1,000,000         |  ±0.25%     | 10");
            Console.WriteLine(" Violeta   |   7    | x10,000,000        |  ±0.1%      | 5");
            Console.WriteLine(" Gris      |   8    | x100,000,000       |  ±0.05%     | —");
            Console.WriteLine(" Blanco    |   9    | x1,000,000,000     |     —       | —");
            Console.WriteLine(" Dorado    |   —    | x0.1               |   ±5%       | —");
            Console.WriteLine(" Plateado  |   —    | x0.01              |  ±10%       | —");
            Console.WriteLine(" Sin color |   —    | —                  |  ±20%       | —");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine(" Pulse cualquier tecla para regresar al menú...");
        }
    }
} 

