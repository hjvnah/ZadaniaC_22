using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorzeniowy
{
    public class Tablice
    {
        //tworzymy publiczne funckje w skrypcie Tablice
        public void Wyswietl(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]+ ", ");
            }
        }
        public int[] Tworzenie_tablicy()
        {            
            //pobieramy dlugosc tablicy od uzytkownika
            Console.WriteLine("Ile znaków ma mieć tablica?");
            int dlugosc = int.Parse(Console.ReadLine());

            //tworzymy pusta tablice o podanej dlugosci
            int[] ints = new int[dlugosc];

            //dodajemy kolejnp elementy do tablicy
            for(int i = 0; i < dlugosc; i++)
            {
                Console.Write("Podaj kolejny element: ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
        public void SortowanieBąbelkowe(int[] tab)
        {
            int n = tab.Length;
            while ( n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                       int nazwa = tab[i];
                       tab[i] = tab[i + 1];
                       tab[i + 1] = nazwa;
                    }
                }
                n--;
            }
        } 
        public void Przeszukaj(int[] tab)
        {
            Console.WriteLine("Jakiej liczby szukasz w tablicy? ");
            int szukana = int.Parse(Console.ReadLine());

           
            bool liczba_istnieje = false;
            int ile_powtorzen = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == szukana)
                {
                    liczba_istnieje = true;
                    ile_powtorzen++;
                }
            }
            if(liczba_istnieje == true)
            {
                Console.WriteLine($"liczba jest w tablicy występuje {ile_powtorzen} razy.");
            }
            else
            {
                Console.WriteLine("Liczby nie ma w tbalicy");
            }
        }
    }
}
