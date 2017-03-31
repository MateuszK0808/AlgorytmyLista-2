using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_Lista_2.Klasy
{
    public class TablicaFifo<E> where E : class
    {
        object[] tablica;
        int d = 0;
        int head = 0;
        int tail = 0;
        public TablicaFifo(int dlugosc)
        {
            d = dlugosc;
            tablica = new Object[d];
        }

        public void Push(E wartosc)
        {
            if (Pelna()) throw new StackOverflowException();
            else
            {
                tablica[tail] = wartosc;
                tail = (tail + 1) % d;
                if (tail == head) tail = -1;
            }
        }
        public E Pop()
        {
            if (Pusta()) return null;
            else
            {
                object toReturn = tablica[head];
                tablica[head] = null;
                if (Pelna()) tail = head;
                head++;
                if (head >= d) head = 0;
                return (E) toReturn;
            }
        }

        public bool Pusta()
        {
            if (tail == head) return true;
            else return false;
        }

        public bool Pelna()
        {
            if (tail == -1) return true;
            else return false;
        }
        public void Print()
        {
            if (Pusta())
            {
                Console.WriteLine("Stos pusty");
            }
            else
            {
                int index = tail;
                if (tail < head) index = tail + 10;
                if (Pelna()) index = head + 10;
                for (int i = head; i < index; i++)
                {
                    Console.Write(tablica[i % 10]);
                    Console.Write(" | ");
                }
                
                Console.WriteLine();
            }
        }

    }
}
