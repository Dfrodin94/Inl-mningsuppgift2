using System;
using System.Threading.Channels;

namespace Inlämningsuppgift2
{

    class KlassKamrat
    {

        private string name;
        private int age;
        private string housing;
        private string family;
        private string housePet;
        private string latestWork;
        private string hobby;
        private string favoriteFood;
        private string favoriteMusic;
        private string motProg;


        public string Name
        {
            get { return name; }
            set { name = value; }
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

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
