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
        int[] Vdiarias = new int [7];

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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ARTICULOS\t\t LUNES\t\tMARTES\t\tMIERCOLES\tJUEVES\t\tVIERNES\t\tSABADO\t\tDOMINGO\t\tTOTAL POR ARTICULO\n");
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
                int sumaC = 0;
                for (int j = 0; j < espacios.GetLength(0); j++)
                {
                    sumaC = sumaC + espacios[j , i];
                    Vdiarias[i] = sumaC;
                }
            }
            for (int i = 0; i < espacios.GetLength(1); i++)
            {
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.Write("\t  "+Vdiarias[i]+"\t");
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.Write("\t       " + ST+ "        ");
            Console.ResetColor();
        }

    }
}
