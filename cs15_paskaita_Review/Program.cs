using System;
using System.Linq;

namespace cs15_paskaita_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs15_PASKAITA_Review");

            #region Review

            // Klasė gali turėti tuščią konstruktorių
            // Strukūra negali paveldėti

            // Kuo skiriasi inicializavimas nuo deklaravimo? Deklaruojant sukuriamas kintamasis,
            // o inicializuojant priskiriama reikšmė;



            //var page = new Page("Content", 1);
            //var page2 = new Page("Content", 2);
            //var page3 = new Page("Content", 3);

            //var book = new Book(Guid.NewGuid(), "Book");

            //book.Pages.Add(page);
            //book.Pages.Add(page2);
            //book.Pages.Add(page3);

            // arba:

            //var book = new Book(Guid.NewGuid(), "Book");

            //book.Pages.Add(new Page("Content", 1));
            //book.Pages.Add(new Page("Content", 2));
            //book.Pages.Add(new Page("Content", 3));

            ////book.Pages.RemoveAll(x=>x.PageNumber == 1); <-- trynimas
            ////           trinti viską x, kur x yra PageNumber yra 1

            ////book.Pages = book.Pages.Where(x => x.Content != "Book Name1").ToList(); <-- Alternatyvus trynimo būdas

            //foreach (var item in book.Pages)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            // TV show:
            //P         ID
            //P         Duration
            //P         Title
            //P         Description
            //P         StartTime
            //          
            // TV Programme:
            //P         List of TV Shows
            //M         Add TV show
            //M         Remove TV Show by Name
            //M         Remove TV Show by Id
            //M         Print Programme
            //M         Clear Programme
            //
            // Additional stuff:
            //          Extract TV Programme functionality to separate TVProgrammeService

            var random = new Random();
            var show1 = new TV_Show((random.Next(25, 55)), "101", "about", "11:00");
            var show2 = new TV_Show((random.Next(25, 55)), "102", "about", "12:00");
            var show3 = new TV_Show((random.Next(25, 55)), "103", "about", "13:00");
            var show4 = new TV_Show((random.Next(25, 55)), "104", "about", "14:00");
            var show5 = new TV_Show((random.Next(25, 55)), "105", "about", "15:00");

            //M         Add TV show

            var showList = new TV_Programme();
            
            showList.AddTVShow(show1);
            showList.AddTVShow(show2);
            showList.AddTVShow(show3);
            showList.AddTVShow(show4);
            showList.AddTVShow(show5);
            showList.PrintProgramme();
            Console.WriteLine("---");
            //M         Remove TV Show by Name
            showList.RemoveTVShowByName("101");
            showList.PrintProgramme();
            Console.WriteLine("---");

            //M         Remove TV Show by Id
            showList.RemoveTVShowByID(show5.ID);
            showList.PrintProgramme();
            Console.WriteLine("---");
            //M         Print Programme
            //showList.PrintProgramme();

            //M         Clear Programme
            showList.ClearProgramme();
            showList.PrintProgramme();
            Console.WriteLine("---");
        }
    }
}

