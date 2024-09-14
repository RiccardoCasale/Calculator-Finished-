using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace calcolatrice.classes
{
    internal class Calcolatrice
    {
        

        public static double Somma(double[] array)
        {
            foreach (var item in array) 
            { 
                
            }

            double result = 0;
            foreach (double num in array)
            {
                result += num;
            }
            return result;
        }

        public static double Sottrazione(double[] array)
        {
            double result = array[0];
            double[] numeriDaSottrarre = new double[array.Length - 1];
            int j = 0;

            for(int i = 1 ; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                    throw new ArgumentException();
                }
                numeriDaSottrarre[j] = array[i];
                j++;
            }

            foreach (double num in numeriDaSottrarre)
            {
                result -= num;
            }
            return result;
        }

        public static double Moltiplicazione(double[] array)
        {
            double result = array[0];
            double[] numeriDaMoltiplicareSenzaPrimo = new double[array.Length - 1];
            int j = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                    throw new ArgumentException();
                }
                numeriDaMoltiplicareSenzaPrimo[j] = array[i];
                j++;
            }

            foreach (double num in numeriDaMoltiplicareSenzaPrimo)
            {
                result *= num;
            }

            return result;
        }

        public static double Divisione(double[] array)
        {
            double result = array[0];
            double[] numeriDaDividereSenzaPrimo = new double[array.Length - 1];
            int j = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                    throw new ArgumentException();
                }
                numeriDaDividereSenzaPrimo[j] = array[i];
                j++;
            }

            foreach (double num in numeriDaDividereSenzaPrimo)
            {
                result /= num;
            }

            return result;
        }

    }
}
