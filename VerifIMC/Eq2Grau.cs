using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifIMC
{
    class Eq2Grau
    {
        public static void Main(string[] args)  
        {
            float A, B, C, delta;
            float x1 = 0;
            float x2 = 0;


            Console.WriteLine(" ");
            Console.Write("Informe o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o valor de  B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (A == 0)
            {
                Console.WriteLine("A NÃO PODE SER IGUAL A ZERO!");
            }

            delta = (float)(B * B - (4 * A * C));

            if (delta < 0)
            {
                Console.WriteLine("DELTA NEGATIVO NÃO POSSUI RAÍZES REAIS");
            }
            else
            {
                x1 = (float)(-B + Math.Sqrt(delta)) / (2 * A);
                x2 = (float)(-B - Math.Sqrt(delta)) / (2 * A);
            }

            Console.WriteLine("Valor x1: " + x1 + "\nValor x2: " + x2);

        }
    }
    }
