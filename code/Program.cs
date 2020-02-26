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
                Countries Finland = new Countries("Finland", 1328000, true);
                Countries France = new Countries("France", 1328000, true);
                Countries Germany = new Countries("Germany", 1328000, true);
                Countries Greece = new Countries("Greece", 1328000, true);
                Countries Hungary = new Countries("Hungary", 1328000, true);
                Countries Ireland = new Countries("Ireland", 1328000, true);
                Countries Italy = new Countries("Italy", 1328000, true);
                Countries Latvia = new Countries("Latvia", 1328000, true);
                Countries Lithuania = new Countries("Lithuania", 1328000, true);
                Countries Luxembourg = new Countries("Luxembourg", 1328000, true);
                Countries Malta = new Countries("Malta", 1328000, true);
                Countries Netherlands = new Countries("Netherlands ", 1328000, true);
                Countries Poland = new Countries("Poland ", 1328000, true);
                Countries Portugal = new Countries("Portugal ", 1328000, true);
                Countries Romania = new Countries("Romania ", 1328000, true);
                Countries Slovakia = new Countries("Slovakia ", 1328000, true);
                Countries Slovenia = new Countries("Slovenia ", 1328000, true);
                Countries Spain = new Countries("Spain ", 1328000, true);
                Countries Sweden = new Countries("Sweden ", 1328000, true);

            }
        }
    }
}

