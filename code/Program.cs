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
                Countries France = new Countries("france", 1000, true);

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

