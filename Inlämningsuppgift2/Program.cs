using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Inlämningsuppgift2
{

    class KlassKamrat
    {

        private string name;
        private string town;
        private int age;
        private string housing;
        private string family;
        private string housePet;
        private string latestWork;
        private string hobby;
        private string favoriteFood;
        private string favoriteMusic;
        private string motProg;

        public KlassKamrat()
        {

        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Town
        {
            get { return town; }
            set { town = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Housing
        {
            get { return housing; }
            set { housing = value; }
        }

        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        public string HousePet
        {
            get { return housePet; }
            set { housePet = value; }
        }

        public string LatestWork
        {
            get { return latestWork; }
            set { latestWork = value; }
        }

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }

        public string FavoriteMusic
        {
            get { return favoriteMusic; }
            set { favoriteMusic = value; }
        }

        public string MotProg
        {
            get { return motProg; }
            set { motProg = value; }
        }





    }

    class BasGrupp : KlassKamrat
    {

        public BasGrupp()
        {

        }

        public BasGrupp(string name, string town, int age, string housing, string family, string housePet, string latestWork, string hobby, string favFood, string favMusic, string motProg)
        {

            Name = name;
            Town = town; 
            Age = age;
            Housing = housing;
            Family = family;
            HousePet = housePet;
            Hobby = hobby;
            LatestWork = latestWork;
            FavoriteFood = favFood;
            FavoriteMusic = favMusic;
            MotProg = motProg;
        }

        public void ConsoleAllInfo()
        {

            Console.WriteLine($"{Name}\n{Town}\n{Age}\n{Housing}\n{Family}\n{HousePet}\n{Hobby}\n{LatestWork}\n{FavoriteFood}\n{FavoriteMusic}\n{MotProg}\n");
        }

        public void ConsoleAllInfoList(List<BasGrupp> l)
        {
            foreach (BasGrupp b in l)
            {
                b.ConsoleAllInfo();
            }

        }

        public void FillGroupInfo(List<BasGrupp> l)
        {

            l.Add(new BasGrupp("David Josef Frödin", "Sundbyberg", 25, "Lägenhet", "Det vanliga", "Inga", "Verksamhetschef", "Filosof", "Ryskt", "Rock", "blandning mellan kreativtet och kul"));
            l.Add(new BasGrupp("Mikael Alexander Larsson", "Vänersborg", 36, "Villa", "Fru och 3 döttrar", "Två kaniner", "Resturangledare", "Träning och hälsa", "Bönchiligryta", "elektroniskt", "Daglig hjärngympa"));
            l.Add(new BasGrupp("Karin Madeleine Karlsson", "Stockholm", 35, "Villa", "Sambo och en dotter", "Tre katter", "Ekonomiassistent", "Bakning och spel", "´Kött och rotfrukter", "!= barnvisor", "Ballt hu det skapas osv"));
            l.Add(new BasGrupp("Sammy On Tat Wong", "Åmål", 54, "Villa", "Fru och en son", "3 katter och 1 hund", "Personlig assistent", "Fotografering", "Italeinsk", "Soul", "Kunna skapa något"));
            l.Add(new BasGrupp("Rauf Karimli", "Göteborg", 36, "Villa", "Fru, son och en dotter", "inga", "projektledare", "spela piano", "grillat kött", "gott och blandat", "gränslösa möjligheter att utvecklas"));
            l.Add(new BasGrupp("Erik Rindlert", "Stockholm", 31, "lägenhet", "Ogift", "inga", "IT-support", "Litteratur", "Fisksoppa", "Darkthrone", "Bygga bygga bygga"));
            l.Add(new BasGrupp("Daniel Jacob Arlbring", "Alingsås", 24, "Lägenhet", "Sambo", "Inga", "Väktare", "Motorsport", "Italienskt", "house", "okänt"));
            l.Add(new BasGrupp("Svante Joelsson", "Strömstad", 36, "Lägenhet", "Sambo och en son", "Hund", "Fritidspedagog", "Illustrera", "Pasta al fungi", "Gubbrock", "Kul combo av problemlösning"));
            l.Add(new BasGrupp("Sarah Winroth", "Vara", 31, "Lägenhet", "Gift", "Inga", "Reseledare", "Motionerar gärna", "All mat", "Allt", "Problemlösning"));
            l.Add(new BasGrupp("Farzane Zafarzade", "Karlstad", 32, "Lägenhet", "Man", "inga", "IT-support", "Träning", "Pastarätter", "Lugn musik", "Ballt"));
        }

        public void DecisionGroupInfo(List<BasGrupp> l)
        {

            string input;
            BasGrupp B = new BasGrupp();

            Console.WriteLine("Vill du ha information om en specifik deltagare eller allihopa?" + "\n");

            // du kan skriva ut alla namn här. 

            Console.WriteLine("1. Skriv deltagarens namn för att skriva ut en specifik deltagare");
            Console.WriteLine("2. Skriv 'alla' för att allihopa");
            input = Console.ReadLine();


            if (input == "alla")
            {
                B.ConsoleAllInfoList(l);
            }
            else
            {
                B.OnePersonInfo(input, l);
            }

        }

        public void OnePersonInfo(string input, List<BasGrupp> l)
        {
            BasGrupp temp;
            bool noName = true;

            for (int i = 0; i < l.Count(); i++)
            {
                temp = l[i];
                if (input.Equals(temp.Name))
                {
                    temp.ConsoleAllInfo();
                    noName = false;
                    break;
                }

            }

            if (noName)
            {
                Console.WriteLine("Namnet finns inte, pröva vänligen igen");
            }
        }

        public void AllNamesGroup(List<BasGrupp> l)
        {

            List<string> listNames = new List<string>();
            int i = 0;
            foreach (BasGrupp b in l)
            {
                i++;
                listNames.Add(b.Name);
            }

            Console.WriteLine(String.Join(", ", listNames));
            Console.WriteLine($"Det är totalt {l.Count()} personer i din grupp" + "\n");

        }

        public void TotalAgeGroup (List<BasGrupp> l)
        {
            int age;
            int totalAge = 0;

            foreach(BasGrupp b in l)
            {
                age = b.Age;
                totalAge += age;
            }

            Console.WriteLine($"Den totala åldern är {totalAge} år, ballt!");

        }

        public void RemoveMember (List<BasGrupp> l)
        {
            string input;
            BasGrupp temp;
            bool exist = true;

            Console.WriteLine("Skriv vänligen in namnet på personen som du vill ta bort");
            input = Console.ReadLine();

            for (int i = 0; i < l.Count(); i++)
            {
                temp = l[i];
                if (input.Equals(temp.Name))
                {
                    Console.WriteLine($"{temp.Name} har blivit borttagen från gruppen, hur kunde du?!");
                    l.Remove(temp);
                    exist = false;
                    break;
                }

            }

            if (exist)
            {
                Console.WriteLine("Personen finns inte i gruppen, kanske bäst att inte ta bort hen?");
            }
        }

    }

    class Meny
    {

        public void Startup ()
        {
            BasGrupp B = new BasGrupp();
            List<BasGrupp> listBaseGroup = new List<BasGrupp>();
            B.FillGroupInfo(listBaseGroup);

            Console.WriteLine("Hej och välkommen till hemligheternas kammare, skriv vänligen in lösenordet");
            String input;
            bool keepGoing = false;

            while (true)
            {


                input = Console.ReadLine();


                if (input == "coffencode")
                {
                    keepGoing = true;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("du skrev fel lösenord, vänligen pröva igen");
                }

            }

            Console.WriteLine("Snyggt jobbat! Du är inne i hemligheternas kammare");


            while (keepGoing)
            {

                Console.WriteLine("1. Skriv ut namnet på alla i din grupp");
                Console.WriteLine("2. Information om varje deltagare");
                Console.WriteLine("3. Sammanlagda åldern av alla deltagare");
                Console.WriteLine("4. Ta bort en i din grupp");
                Console.WriteLine("q. Avsluta programmet");
                Console.WriteLine("\n" + "INFORMATION: Tryck enter för att rensa fönstret");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        B.AllNamesGroup(listBaseGroup);
                        break;
                    case "2":
                        B.DecisionGroupInfo(listBaseGroup);
                        break;
                    case "3":
                        B.TotalAgeGroup(listBaseGroup);
                        break;
                    case "4":
                        B.RemoveMember(listBaseGroup);
                        break;
                    case "":
                        Console.Clear();
                        break;
                    case "q":
                        keepGoing = false;
                        break;

                }



            }

        }

       

    

        

    }

    class Program
    {
        static void Main(string[] args)

        {
            Meny M = new Meny();
            M.Startup();     

        }
    }
}
