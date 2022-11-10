/*3) Desarrollar un programa que solicite al usuario ingresar 6 números y almacenar en ARRAY y
por último se lo debe recorrer para calcular y mostrar el promedio de los valores.*/


using System;

namespace Ej3_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float[] numerooos;
            numerooos = new float[6];
     

            float acum = 0, promedio = 0;
            Console.Clear();

            for (int i = 0; i < numerooos.Length ; i++)
            {
                Console.WriteLine("ingrese el numero de la posicion:" + " " + (i + 1));
                numerooos[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i = 0; i < numerooos.Length ; i++)
            {
                Console.WriteLine("El NUMERO INGRESADO EN LA POSICION   " + (i + 1) + " ES: " + numerooos[i]);
                acum = acum + numerooos[i];
            }
            promedio = acum / numerooos.Length;
            Console.WriteLine("El rpomedio de los numeros es: " + promedio);

        }
    }






}

