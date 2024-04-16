using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace shows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = 100;
            double totalP = 0;
            int half = 0;
            int full = 0;
                for (int ing = 1; ing <= 30; ing++) 
            {
                Console.WriteLine("Possui certificação de estudante: 1(sim)/2(nao)");
                int cert = int.Parse(Console.ReadLine());
                if (ing<=10 && cert==1) {
                    preco = preco/2;
                    half++;
                }else if (ing<=20 && cert == 1)
                {
                    half++;
                    preco = (preco*1.5)/2;
                }else if (ing<=30 && cert == 1)
                {
                    half++;
                    preco = (preco * 3) / 2;
                }
                if (ing <= 10 && cert == 2)
                {
                    full++;
                    preco = preco ;
                }
                else if (ing <= 20 && cert == 2)
                {
                    full++;
                    preco = (preco * 1.5);
                }
                else if (ing <= 30 && cert == 2)
                {
                    full++;
                    preco = (preco * 3);
                }




                totalP += preco;
            }
            Console.WriteLine("O total foi de:" + totalP);
            Console.WriteLine("Ingressos inteiros: "+full);
                Console.WriteLine("Meio ingresso: "+half);

            Console.ReadKey();

        }
        
    }
}
