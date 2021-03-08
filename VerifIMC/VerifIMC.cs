using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifIMC
{
    class VerifIMC
    {
        static void Main(string[] args)
        {
            float imc, massa, altura;
            string sMsg = "Resultado";

            Console.WriteLine("Calculo do IMC");
            Console.WriteLine();

            Console.WriteLine("Informe o peso (kg): ");
            massa = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura (m): ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine();
            imc = (massa / (altura * altura));

            if (imc < 18.5)
                sMsg += " Peso abaixo do normal";
            else if ((imc == 18.5) || (imc == 25))
                sMsg += " Peso normal";
            if ((imc > 25) || (imc == 30))
                sMsg += " Sobrepeso";
            else if ((imc > 30) || (imc ==35))
                sMsg += " Grau de Obesidade 1";
            if ((imc > 35) ||(imc == 40))
                sMsg += " Grau de Obesidade 2";
            else if (imc > 40)
                sMsg += " Grau de Obesidade 3";
            

            Console.WriteLine(sMsg + " IMC = " + imc);


            Console.ReadKey();
        }
    }
}


