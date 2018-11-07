using System; //jeśli przestrzeń nazw nie jest wyszarzona to znaczy że program jej używa
using System.Text; //pozwala ustawić kodowanie dzięki czemu w konsoli będą widoczne polskie znaki

namespace NaukaCsharp //w tej przestrzeni obowiązują nazwy zmiennych i klas, poza nią można nadawać takie same nazwy
{
    internal class Lekcja1 //klasy są mniejsze od przestrzeni nazw
    {
        private static void Main(string[] args) //zawsze tylko jedna metoda o nazwie main, ona uruchamia program
        {//metody grupują pojedyńcze instrukcje

            uint zmienna = uint.MaxValue; //zmienna powinna się zaczynać z małej litery, aby odróżnić od metod i klas, nie może być spacji w nazwie
                                          //nie może być słów kluczowych typu int,void będących poleceniami języka. Każda zmienna ma swoją komórkę w pamięci
            string zmienna_tekstowa = "jakiś tekst";

            //wartości całkowite
            byte zmienna_bitowa = byte.MaxValue; //od 0 do 255
            short zmienna_short = short.MaxValue; //wartość widać po najechaniu na 
            long zmienna_long = long.MaxValue;
            short zmienna_ujemna = -15;
            ushort zmienna_nie_moze_byc_juz_ujemna = ushort.MaxValue; //typ zmiennej mający "u" jest unsigned czyli nie może mieć wartości ujemnych
                                                                      // unsigned podwaja dostępną wartość 

            //wartości z przecinkami
            float przecinkowa = 3.14F;// na końcu musi być F, bo kompilator bez F traktuje domyślnie taką zmienną jako double
            double przecinkowa2 = 3.21234432234;
            decimal decymalna = 9.234M; //jeszcze większa niż double, jeszcze bardziej obciąża procesor
            //możemy mieć albo dużo cyfr przed przecinkiem albo po nim, dlatego "zmiennoprzecinkowe", komputer nie da rady dla obu, jedno kosztem drugiego
            //double zajmuje więcej miejsca w pamięci, więc szybsze będzie float ale double bardziej precyzyjne
            char znak1 = 'a'; //przechowuje tylko jeden znak
            bool logiczna = true; //albo false, zmienna logiczna; prawda lub fałsz
            bool obliczanie1 = 1 > 2; //wyjdzie False bo 1 nie jest większe od 2; czy jenda wartość jest większa od drugiej

            const string Staua = "niezmienna wartość"; //jesli chcemy zeby wartosc zmiennej nigdy się nie zmieniła, od razu trzeba nadać wartość

            Console.WriteLine("C# rulz"); //instrukcja
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1250"); //ustawia kodowanie tak żeby wyświetlało polskie znaki w konsoli
            Console.WriteLine(zmienna_tekstowa + "\n Maksymalna długość int to " + zmienna); //instrukcja
            Console.WriteLine("\n Maksymalna długość " + zmienna_bitowa.GetTypeCode() + " " + zmienna_bitowa);// "\n" oznacza przejście do kolejnej linii
            Console.WriteLine("\n Maksymalna długość " + zmienna_short.GetTypeCode() + " to " + zmienna_short);
            Console.WriteLine("\n Maksymalna długość " + zmienna_long.GetTypeCode() + " to " + zmienna_long);
            Console.WriteLine(obliczanie1);

            //komentarz jednolinijkowy

            /*
             * komentarz wielolinijkowy, w każdej linijce musi być *
             */

            //CTRL+K a potem CTRL+D czyści kod
            //CTRL+K a potem CTRL+C zmienia zaznaczone linijki w komentarze, CTRL+K a potem CTRL+U odkomentowuje
            //F5 kompiluje
            //snippety - jest ich dużo, trzeba poszukać innych fajnych
            //cw TAB TAB - console.writeline
            //for TAB TAB tworzy pętle for
            

            Console.ReadKey(); //żeby okno nie zniknęło od razu po wykonaniu poleceń
        }
    }
}
