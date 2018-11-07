using System; //jeśli przestrzeń nazw nie jest wyszarzona to znaczy że program jej używa
using System.Text; //pozwala ustawić kodowanie dzięki czemu w konsoli będą widoczne polskie znaki

namespace NaukaCsharp //w tej przestrzeni obowiązują nazwy zmiennych i klas, poza nią można nadawać takie same nazwy
{
    class Lekcja1 //klasy są mniejsze od przestrzeni nazw
    {
        static void Main(string[] args) //zawsze tylko jedna metoda o nazwie main, ona uruchamia program
        {//metody grupują pojedyńcze instrukcje

            var zmienna = int.MaxValue; //zmienna powinna się zaczynać z małej litery, aby odróżnić od metod i klas, nie może być spacji w nazwie
                             //nie może być słów kluczowych typu int,void będących poleceniami języka. Każda zmienna ma swoją komórkę w pamięci
            var zmienna_tekstowa = "jakiś tekst";
            Console.WriteLine("C# Helou Wołrld"); //instrukcja
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1250"); //ustawia kodowanie tak żeby wyświetlało polskie znaki w konsoli
            Console.WriteLine(zmienna_tekstowa+" "+zmienna); //instrukcja
            Console.ReadKey(); //instrukcja
        }
    }
}
