using System;
using System.IO;
using System.Collections.Generic;

namespace code
{


    class Countries
    {
        public string Name;
        public int Pop;
        public bool EU;
        public string Vote;

        public Countries()
        {
            Name = "Default";
            Pop = 0;
            EU = false;
            Vote = "YES";
        }
        public Countries(string name, int pop, bool eu, string vote)
        {
            Name = name;
            Pop = pop;
            EU = eu; 
            Vote = vote;
        }
        public void changeVote(string newVote)
        {
            Vote = newVote; 
        }
        public void printDetails()
        {
            Console.WriteLine($"Name = {Name}\tPopulation = {Pop}\tVote  = {Vote} ");
        }

    }
    class Program
    {
        Countries AUSTRIA = new Countries("Austria", 8822000, true, "Yes" );
        Countries BELGIUM = new Countries("Belgium", 11400000, true, "Yes");
        Countries BULGARIA = new Countries("Bulgaria", 7050000, false, "Yes");
        Countries CROATIA = new Countries("Croatia", 4076000, false, "Yes");
        Countries CYPRUS = new Countries("Cyprus", 1170000, true, "Yes");
        Countries CZECHREPUBLIC = new Countries("Czech Republic", 10650000, false, "Yes");
        Countries DENMARK = new Countries("Denmark", 5603000, false, "Yes");
        Countries ESTONIA = new Countries("Estonia", 1328000, true, "Yes");
        Countries FINLAND = new Countries("Finland", 5513000, true, "Yes");
        Countries FRANCE = new Countries("France", 66990000, true, "Yes");
        Countries GERMANY = new Countries("Germany", 82790000, true, "Yes");
        Countries GREECE = new Countries("Greece", 10740000, true, "Yes");
        Countries HUNGARY = new Countries("Hungary", 9773000, false, "Yes");
        Countries IRELAND = new Countries("Ireland", 4830000, true, "Yes");
        Countries ITALY = new Countries("Italy", 60480000, true, "Yes");
        Countries LATVIA = new Countries("Latvia", 1920000, true, "Yes");
        Countries LITHUANIA = new Countries("Lithuania", 2794000, true, "Yes");
        Countries LUXEMBOURG = new Countries("Luxembourg", 602005000, true, "Yes");
        Countries MALTA = new Countries("Malta", 493559, true, "Yes");
        Countries NETHERLANDS = new Countries("Netherlands", 17180000, true, "Yes");
        Countries POLAND = new Countries("Poland", 37980000, false, "Yes");
        Countries PORTUGAL = new Countries("Portugal", 1029000, true, "Yes");
        Countries ROMANIA = new Countries("Romania", 19530000, false, "Yes");
        Countries SLOVAKIA = new Countries("Slovakia", 5450000, true, "Yes");
        Countries SLOVANIA = new Countries("Slovenia", 2067000, true, "Yes");
        Countries SPAIN = new Countries("Spain", 46660000, true, "Yes");
        Countries SWEDEN = new Countries("Sweden", 10120000, false, "Yes");
        List<Countries> list = new List<Countries>();



        public void Selection()
        {
            Console.WriteLine("Are you incluiding all countries or just the Eurozone countries? (All/Euro)");
            string answer = "";
        retry:
            answer = Console.ReadLine().ToUpper();
            if (answer == "ALL")
            {
                bool Selection = true;
                

            }
            else if (answer == "EURO")
            {
                bool Selection = false;
                
            }


            else
            {
                Console.WriteLine("Your Answer Was Not Valid! Try again");
                goto retry;
            }

        }


        public void display()
        {

        }




        static void Main(string[] args)
        {
            Program p = new Program();

            p.list.Add(p.AUSTRIA);
            p.list.Add(p.BELGIUM);
            p.list.Add(p.BULGARIA);
            p.list.Add(p.CROATIA);
            p.list.Add(p.CYPRUS);
            p.list.Add(p.CZECHREPUBLIC);
            p.list.Add(p.DENMARK);
            p.list.Add(p.ESTONIA);
            p.list.Add(p.FINLAND);
            p.list.Add(p.FRANCE);
            p.list.Add(p.GERMANY);
            p.list.Add(p.GREECE);
            p.list.Add(p.HUNGARY);
            p.list.Add(p.IRELAND);
            p.list.Add(p.ITALY);
            p.list.Add(p.LATVIA);
            p.list.Add(p.LITHUANIA);
            p.list.Add(p.LUXEMBOURG);
            p.list.Add(p.MALTA);
            p.list.Add(p.NETHERLANDS);
            p.list.Add(p.POLAND);
            p.list.Add(p.PORTUGAL);
            p.list.Add(p.ROMANIA);
            p.list.Add(p.SLOVAKIA);
            p.list.Add(p.SLOVANIA);
            p.list.Add(p.SPAIN);
            p.list.Add(p.SWEDEN);
          


            p.menu();
        }
        public void EditVote()
        {
            Console.WriteLine("Which Countries Vote Do You Want To Change?");
            string Choice = Console.ReadLine().ToUpper();
            foreach (Countries name in list)
            {

                if (name.Name.ToUpper() == Choice)
                {
                    Console.Write("Your Choice Was: ");
                    Console.WriteLine(name.Name);
                    Console.WriteLine("What Would You Like To Change There Vote Too? (Y/N/A)");
                    reanswer:
                    Choice = Console.ReadLine().ToUpper();
                    if (Choice == "Y")
                    {
                        name.Vote = "Yes";
                    }
                    else if (Choice == "N")
                    {
                        name.Vote = "No";
                    }
                    else if (Choice == "A")
                    {
                        name.Vote = "Abstrain";
                    }
                    else 
                    {
                        Console.WriteLine("Invalid Input, Try Again.");
                        goto reanswer;
                    }
                }
                
            }
        }
        public void menu()
        {
            display();
            Console.WriteLine("          Voting Calculator");
            Console.WriteLine("***************************************");
            Console.WriteLine("Your options:");
            Console.WriteLine("Enter 1 To Edit A Countries Vote.");
            Console.WriteLine("Enter 2 To Edit The Voting Rule.");
            Console.WriteLine("Enter 3 To Edit Countries Participating");
            Console.WriteLine("Enter 4 To Quit.");
            Console.WriteLine("***************************************");
            input:
            string Response = Console.ReadLine();
            if (Response == "4")
            {
                return;
            }
            else if (Response == "3")
            {
                Selection();
            }
            else if (Response == "1")
            {
                EditVote();
            }
             


            else
            {
                Console.WriteLine("That input Is Not Valid, Try Again.");
                goto input; 
            }
        }

    }

       
    
}

