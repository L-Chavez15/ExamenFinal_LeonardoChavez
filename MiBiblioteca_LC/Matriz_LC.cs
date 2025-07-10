using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LC
{
    public class Matriz_LC
    {
        int[,] espacios = new int[7, 7];
        int[] VentasDiarias = new int [7];

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
        public int SumaTotal()
        {
            int Stotal = 0;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    Stotal += espacios[i, j];
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
            return Stotal;
        }
        public void MostrarMatriz()
        {
            int ST = SumaTotal();
            Console.BackgroundColor= ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ARTICULOS               LUNES           MARTES        MIERCOLES         JUEVES         VIERNES         SABADO         DOMINGO          TOTAL POR ARTICULO  ");
            Console.ResetColor();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ARTICULO " + (i + 1) + " \t");
                Console.ResetColor();

                int total = 0;
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    total = total+ espacios[i, j];
                    Console.Write("\t  " + espacios[i, j] + "\t");
                }
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("\t       "+total+"\n");
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" Ventas Diarias " );
            Console.ResetColor();

            for (int i = 0; i < espacios.GetLength(1); i++)
            {
                int sumaColumna = 0;
                for (int j = 0; j < espacios.GetLength(0); j++)
                {
                    sumaColumna = sumaColumna + espacios[j , i];
                    VentasDiarias[i] = sumaColumna;
                }
            }
            for (int i = 0; i < espacios.GetLength(1); i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.Write("          "+ VentasDiarias[i]+"   ");
            }
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("               " + ST+ "         ");
            Console.WriteLine();
            Console.ResetColor();
        }

    }
}
