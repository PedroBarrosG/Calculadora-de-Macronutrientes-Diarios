using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculodeingestao
{
    class Program
    {
        static void Main(string[]args)
        {
            double kg, c, g, p;
            

            Console.WriteLine("###Cálculo de ingestão de Macronutrientes###");

            Console.WriteLine("Gostaria de calcular para ganho de massa ou emagrecimento? \nDigite: \n1 para ganho de massa \n2 para emagrecimento:");
            double opcao = (Console.ReadLine());
            Console.Write("Insira aqui o seu peso:");
            kg = (Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");

            //double.Parse

            if (opcao == 1)
            {
                p = kg * 2;
                c = kg * 4;
                g = kg * 1;
                Console.WriteLine("Você deve ingerir cerca de: " + p + "g de proteínas," + c + "g de carboidratos e " + g + "g de gorduras diariamente para ganho de massa");
                Console.WriteLine("Muito obrigado por usar a minha calculadora!");
                Console.WriteLine("----------------------------------------");
            }//Opção perda de peso
            else if( opcao == 2 )
            {
                p = kg * 2;
                c = kg * 2;
                g = kg * 1;

                Console.WriteLine("Você deve ingerir cerca de: " + p + "g de proteínas," + c + "g de carboidratos e " + g + "g de gorduras diariamente para emagrecer");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Muito obrigado por usar a minha calculadora!");
                Console.WriteLine("----------------------------------------");
            }//Opção emagrecimento
            Console.WriteLine("Pressione qualquer tecla para sair do programa :)");
            Console.ReadKey();
        }
    }
}
