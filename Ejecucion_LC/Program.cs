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
        }
    }
}
