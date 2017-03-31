using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorytmy_Lista_2.Klasy;
namespace Algorytmy_Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isClose = false;
            string oper;
            TablicaFifo<Liczba> Stos = new TablicaFifo<Liczba>(10);

            while (!isClose)
            {
                Console.Clear();
                Console.WriteLine("STOS TABLICOWY");
                Console.WriteLine();
                Console.WriteLine("D - dodaj element stosu");
                Console.WriteLine("U - usun element stosu");
                Console.WriteLine("C - exit");
                Console.WriteLine();
                Console.Write("STOS -> ");
                Stos.Print();
                Console.WriteLine();
                Console.Write("Podaj operację: ");
                oper = Console.ReadLine();

                oper = oper.ToUpper();

                if (oper == "D")
                {
                    Random rnd = new Random();
                    Liczba l = new Liczba(rnd.Next(100));
                    Stos.Push(l);
                }
                else if (oper == "U")
                {
                    Stos.Pop();
                }
                else if (oper == "C")
                {
                    isClose = true;
                }
            }
        }
    }
}
