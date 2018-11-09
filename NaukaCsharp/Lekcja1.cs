using System; //jeśli przestrzeń nazw nie jest wyszarzona to znaczy że program jej używa
using System.Text; //pozwala ustawić kodowanie dzięki czemu w konsoli będą widoczne polskie znaki
//using System.Management.Automation;

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

            //konwersja niejawna to po prostu przypisanie zmiennych za pomocą = , np a=b
            //konwersja jawna to np s = (short)i; , czyli wprost podajemy typ jaki ma teraz mieć 
            //trzeba brać pod uwagę że jeśli skonwertujemy typ bardziej pojemny na mniej pojemny to wystąpią błędy

            //string input1 = Console.ReadLine();
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1250");
           // Console.WriteLine("Napisałeś " +input1);
            //int i1 = int.Parse(input1) +100; //konwertuje input1 na int i dodaje do niej
            //Console.WriteLine(i1);

           //var string2 = input1.ToString(); //zamienia na stringa
            //Console.WriteLine(string2);
            var string3 = "Hello";
            var string4 = Console.ReadLine();
            Console.WriteLine("{0} {1}", string3 ,string4); //zawsze zaczynamy od {0} a potem po kolei argumenty które przypiszemy
            Console.ResetColor(); //przywraca standardową kolorystykę konsoli po jakichś zmianach

            // = to przypisanie wartości do zmiennej, == to porównanie wartości
            //!= czy się coś różni
            //break; -> wychodzi z pętli 
            //
            Console.WriteLine("Podaj jakąś liczbę od jodyn do czy");
            int zmienna_dla_switcha = int.Parse(Console.ReadLine()); //domyślnie concolde.readline to string więc musimy skonwertować
            switch(zmienna_dla_switcha)
            {
                case 1:
                    Console.WriteLine("Adin");
                    break;//wyjdź poza pętlę
                case 2:
                    Console.WriteLine("Duwa");
                    break;
                case 3:
                    Console.WriteLine("Tri");
                    break;
                default: //wszystkie inne przypadki
                    Console.WriteLine("no weź");
                    goto koniec;
            }

            //tablica to zbiór danych tego samego typu, każdy rekord w innej komórce pamięci (w indeksach)
            int[] tablica1 = new int[3]; //tworzymy nowy obiekt tablicy typu int o określonym rozmiarze bez zadeklarowanych elementów
            string[] dni_tygodnia = { "Poniedziałek", "Wtorek", "Środa", "Czwartek","Piątek","Sobota","Niedziela"}; // od razu podajemy elementy
            int[,] tablica_wielowymiarowa = new int[2, 3]; //po lewej określamy liczbę wymiarów, po prawej liczbę komórek, czyli tutaj dwa wiersze na 3 kolumny  
            //nie można roszerzyć tablicy
            for (int i = 0; i < dni_tygodnia.Length; i++)
            {
                Console.WriteLine("Dzień nr " + (i+1) +" to " + dni_tygodnia[i]);
            }

            Console.WriteLine(tablica_wielowymiarowa.GetLength(0)); //podaj wielkość pierwszego wymiaru tablicy wielowymariowej
            Console.WriteLine(tablica_wielowymiarowa.GetLength(1));  //podaj wielkość drugiego wymiaru tablicy wielowymariowej
            //Array.Sort(tablica); <- sortuje wartości tablicy rosnąco
            //Array.Reverse(tablica); <- odwraca kolejnośc tablicy - po uprzednim posortowaniu
            



        koniec: //etykieta do której możemy się odwołać za pomocą goto
            Console.WriteLine("\nDowolny klawisz zakończy program");
            Console.ReadKey(); //żeby okno nie zniknęło od razu po wykonaniu poleceń
        }
    }
}
