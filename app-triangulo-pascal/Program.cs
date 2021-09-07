using System;

namespace app_triangulo_pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];
            //imprimir datos por consola
            Console.WriteLine("ingrese el numero de pisos deseados.");
            //procedimiento para obtener datos de la consola
            pisos = Convert.ToInt16(Console.ReadLine());
            //declarar un for loop
            for (int i = 1; i <= pisos; i++)
            {
                int[] pascal = new int[i];
                //for loop que decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    //solo genera un espacio, no un salto de linea
                    Console.Write(" ");
                }
                //for loop que genera la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    //condicionara que evaluara la variable del for loop
                    if(k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //sumamos los numeros que estan en cada posicion del arreglo para fromar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
