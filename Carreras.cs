using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
namespace Hilos
{
    public class Carreras
    {
        public static void Corredor(object obj)
        {
            var sw = Stopwatch.StartNew();
            var nombre = (string)obj;
            var random = new Random();
            int aleatorio = 0;
            var hiloActual = Thread.CurrentThread;
            int pasos = 0;
            string carga = "▒";
            //
            do
            {
                aleatorio = random.Next(0, 4);
                pasos += aleatorio;
                carga = carga + Carreras.obtenerBarra(aleatorio);
                //Carreras.ImprimirBarra(nombre, pasos, carga);
                //Carreras.ClearLine(nombre);
                Console.WriteLine("El corredor {0} ha recorrido {1}", nombre, carga);
                Thread.Sleep(300);
            } while (pasos < 100);
            Console.WriteLine("El corredor {0} ha llegado a la meta y tardo en llegar {1} segundos", nombre,sw.ElapsedMilliseconds/1000);

        }
        public static void ClearLine(string corredor)
        {
            if (corredor == "EMERSON")
            {
                Console.SetCursorPosition(1,0);
                Console.WriteLine(" ");
                Console.SetCursorPosition(1,0);
            }
            if(corredor == "ERICK")
            {
                Console.SetCursorPosition(1, 3);
                Console.WriteLine(" ");
                Console.SetCursorPosition(1, 3);
            }
            if (corredor == "JULEIDY")
            {
                Console.SetCursorPosition(1, 5);
                Console.WriteLine(" ");
                Console.SetCursorPosition(1, 5);
            }
            if (corredor == "PATRICIO")
            {
                Console.SetCursorPosition(1, 7);
                Console.WriteLine(" ");
                Console.SetCursorPosition(1, 7);
            }
        }
        public static void ImprimirLlegada(string nombre)
        {

        }
            public static void ImprimirBarra(string nombre, int pasos, string carga)
        {
            if (nombre == "EMERSON")
            {
                Console.SetCursorPosition(1,0);
                Console.WriteLine("El corredor {0} ha recorrido {1}", nombre, carga);
            }
            if(nombre == "ERICK")
            {
                Console.SetCursorPosition(1,3);
                Console.WriteLine("El corredor {0} ha recorrido {1}", nombre, carga);
            }
            if (nombre == "JULEIDY")
            {
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("El corredor {0} ha recorrido {1}", nombre, carga);
            }
            if (nombre == "PATRICIO")
            {
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("El corredor {0} ha recorrido {1}", nombre, carga);
            }
        }
        public static string obtenerBarra(int pasos)
        {
            int contador = 0;
            string recorrido = "▒";
            while (contador != pasos)
            {
                recorrido = recorrido + "";
                contador++;
            }
            return recorrido;
        }
    }
}
