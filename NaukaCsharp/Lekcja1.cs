using System; //jeśli przestrzeń nazw nie jest wyszarzona to znaczy że program jej używa

namespace NaukaCsharp //w tej przestrzeni obowiązują nazwy zmiennych i klas, poza nią można nadawać takie same nazwy
{
    class Lekcja1 //klasy są mniejsze od przestrzeni nazw
    {
        static void Main(string[] args) //zawsze tylko jedna metoda o nazwie main, ona uruchamia program
        {//metody grupują pojedyńcze instrukcje
            Console.Title("C# nauka");
            Console.WriteLine("<# Helou Wołrld"); //instrukcja
            Console.ReadKey(); //instrukcja
        }
    }
}
