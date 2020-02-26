using System;

namespace code
{


    class Countries
    {
        private string Name;
        private int Pop;
        private bool EU;

        public Countries()
        {
            Name = "Default";
            Pop = 0;
            EU = false;
        }
        public Countries(string name, int pop, bool eu)
        {
            Name = name;
            Pop = pop;
            EU = eu;
        }
        class Program
        {
            static void Main(string[] args)
            {

                Countries Austria = new Countries("Austria", 8822000, true);
                Countries Belgium = new Countries("Belgium", 11400000, true);
                Countries Bulgaria = new Countries("Bulgaria", 7050000, false);
                Countries Croatia = new Countries("Croatia", 4076000, false);
                Countries Cyprus = new Countries("Cyprus", 1170000, true);
                Countries Czech_Republic = new Countries("Czech Republic", 10650000, false);
                Countries Denmark = new Countries("Denmark", 5603000, false);
                Countries Estonia = new Countries("Estonia", 1328000, true);
                Countries Finland = new Countries("Finland", 5513000, true);
                Countries Germany = new Countries("Germany", 82790000, true);
                Countries Greece = new Countries("Greece", 10740000, true);
                Countries Hungary = new Countries("Hungary", 9773000, true);
                Countries Ireland = new Countries("Ireland", 4830000, true);
                Countries Italy = new Countries("Italy", 60480000, true);
                Countries Latvia = new Countries("Latvia", 1920000, true);
                Countries Lithuania = new Countries("Lithuania", 2794000, true);
                Countries Luxembourg = new Countries("Luxembourg", 602005000, true);
                Countries Malta = new Countries("Malta", 493559, true);
                Countries Netherlands = new Countries("Netherlands ", 17180000, true);
                Countries Poland = new Countries("Poland ", 37980000, true);
                Countries Portugal = new Countries("Portugal ", 1029000, true);
                Countries Romania = new Countries("Romania ", 19530000, true);
                Countries Slovakia = new Countries("Slovakia ", 5450000, true);
                Countries Slovenia = new Countries("Slovenia ", 2067000, true);
                Countries Spain = new Countries("Spain ", 46660000, true);
                Countries Sweden = new Countries("Sweden ", 10120000, true);

            }



             public void Selection()
            {
                Console.WriteLine("Are you incluiding all countries or just the Eurozone countries? (All/Euro)");
                string answer = "";
                retry:
                answer = Console.ReadLine().ToUpper();
                if (answer == "ALL")
                {

                }
                else if (answer == "EURO")
                {

                }

                else
                {
                    Console.WriteLine("Your Answer Was Not Valid! Try again");
                    goto retry; 
                }

            }
        }
    }
}

