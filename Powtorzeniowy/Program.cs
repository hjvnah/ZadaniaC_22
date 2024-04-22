using Powtorzeniowy;

class PlikGłówny
{
    
    static void Main(string[] args)
    {
        //zmienna, która jest odwołaniem do innego skryptu
        Tablice tablica = new Tablice();
        //wywołujemy funkcje tworzącą tablicę
        int[] tab = tablica.Tworzenie_tablicy();
        //wywołujemy metodę wyświetlającą tablicę
        tablica.SortowanieBąbelkowe(tab);
        tablica.Wyswietl(tab);
    }
}