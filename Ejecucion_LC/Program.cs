using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBiblioteca_LC;

namespace Ejecucion_LC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz_LC matriz = new Matriz_LC();
            matriz.CreacionL();
            matriz.CreacionM();
            matriz.CreacionMi();
            matriz.CreacionJ();
            matriz.CreacionV();
            matriz.CreacionS();
            matriz.CreacionD();
            matriz.MostrarMatriz();
            //matriz.SUMATOTAL();
            MinMax_LC m1 = new MinMax_LC();
            m1.CreacionL();
            m1.CreacionM();
            m1.CreacionMi();
            m1.CreacionJ();
            m1.CreacionV();
            m1.CreacionS();
            m1.CreacionD();
            Console.ReadKey();

        }
    }
}
