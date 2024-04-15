using Powtorzeniowy;

class PlikGłówny
{
    
    static void Main(string[] args)
    {
        //zmienna, która jest odwołaniem do innego skryptu
        Tablice tablica = new Tablice();
        int[] tab = tablica.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i]+ ", ");
        }

    }
}