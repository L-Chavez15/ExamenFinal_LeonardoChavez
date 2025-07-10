using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LC
{
    public class MinMax_LC
    {
        int[,] espacios = new int[7, 7];

        Random r = new Random();
        public void CreacionL()
        {
            int col = 0;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionM()
        {
            int col = 1;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionMi()
        {
            int col = 2;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionJ()
        {
            int col = 3;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionV()
        {
            int col = 4;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionS()
        {
            int col = 5;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }
        public void CreacionD()
        {
            int col = 6;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 201);
                espacios[i, col] = precios;
            }
        }

        public void MinimoMaximo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\n:::::ARTICULOS::::::::MINIMO:::::::::MAXIMO:::::");
            Console.ResetColor();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int min = espacios[i,0];
                int max = espacios[i, 0];
                int suma= 0;

                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    if (espacios[i, j] < min)
                    {
                        min = espacios[i, j];
                    }
                    if (espacios[i, j] > max)
                    {
                        max = espacios[i, j];
                    }
                }
                Console.WriteLine(":    ARTICULO " + (i+1) + "\t  :     " +min + "\t:     " + max +"      :");
                Console.WriteLine("................................................");
            }
        }
        public void Promedio()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\n:::::ARTICULOS::::::::::PROMEDIO::::::");
            Console.ResetColor();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    suma += espacios[i, j];
                }
                float promedio = (float)suma / 7;
                Console.WriteLine("    ARTICULO " + (i + 1) + "\t   :     " + promedio );
                Console.WriteLine("......................................");
            }
        }
    }

}
