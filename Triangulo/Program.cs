using System;
using Triangulo.Controllers;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] triangulo = new int[10] { 6, 3, 5, 9, 7, 1, 4, 6, 8, 4 };
            int[] triangulo2 = new int[6] { 6, 3, 5, 9, 7, 1 };
            int[] triangulo3 = new int[3] { 6, 3, 5 };
            int[] triangulo4 = new int[10] { 6, 3, 5, 9, 1, 3, 4, 6, 1, 4 };
            int[] triangulo5 = new int[10] { 6, 3, 5, 9, 1, 3, 4, 6, 6, 4 };
            int[] triangulo6 = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] triangulo7 = new int[6] { 1, 1, 1, 1, 1, 1 };

            int resultado;
            resultado = triangulo[0]+ triangulo[ 3]+ triangulo[ 4]+ triangulo[6];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

            resultado = triangulo2[0] + triangulo2[1] + triangulo2[3];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

            resultado = triangulo3[0] + triangulo3[2];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());;

            resultado = triangulo4[0] + triangulo4[1] + triangulo4[3];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

            resultado = triangulo5[0] + triangulo5[2] + triangulo5[3];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

            resultado = triangulo6[0] + triangulo6[2] + triangulo6[4] + triangulo6[6];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

            resultado = triangulo7[0] + triangulo7[2] + triangulo7[4];
            Console.WriteLine("O valor do elemento {0}", resultado.ToString());

        }
    }
}
