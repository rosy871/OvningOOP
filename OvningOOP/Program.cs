using System;
using System.Collections.Generic;
using System.Text;

namespace OvningOOP
{
    class Program
    {
        //F: 3.2.13 om samtliga fåglar behover ett nytt attribut vi ska lägga det i Bird class
        //F: 3.2.14 om all djur behöver nya attributet let skulle ve lägga i Animal class
        public static PersonHandler ph = new PersonHandler();
          public static Person per = new();

        static void Main(string[] args)
        {
            do
            {
                MenuOption();
                MenuOperation();
                
            } while (true);

        }

        private static void MenuOperation()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("inkapsling..3.1 börjar");
                    InkapslingSolution1();
                    InkapslingSolution2();
                    InkapslingSolution3();
                    break;

                case "2":
                    Console.WriteLine("\n\nPolymorfism.. 3.3 börjar\n");
                    PolymorfismSolution1();
                    break;
                case "3":
                    Console.WriteLine("\n\n Polymorfism.. 3.4 börjar\n");
                    PolymorfismSolution2();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("invalid num type again");
                    break;
            }
        }

        private static void MenuOption()
        {
            Console.WriteLine("\nPress 1 for Inkapsling 'Person' project");
            Console.WriteLine("Press 2 for Arv och Polymorfism 'Animal' project ");
            Console.WriteLine("Press 3 for Inkapsling 'UserError' project");
            Console.WriteLine("Press 0 for Exit");
        }


        //solution 3.4
        private static void PolymorfismSolution2()
        {
            var nie = new NumericInputError();
            var tie = new TextInputError();
            //tre egna error class
            var oe = new OutofRangeError();
            var ne = new NullInputError();
            var de = new DivideByZeroError();
            
            var errorlist = new List<UserError>();
            errorlist.Add(nie);
            errorlist.Add(tie);
            errorlist.Add(oe);
            errorlist.Add(ne);
            errorlist.Add(de);

            foreach (var errors in errorlist)
            {
                Console.WriteLine(errors.UEMessage());
            }
            
            //F: 3.4.11. för att förstå oo-programmering är det mycket viktigt att ha en stark begrepp av polymorfism.
                       

            //F: 3.4.12. vi måste fostår hur polymorfism tillåter dig att anropa metoder av subklass från  basklassreferens.
            //           polymorfism hjälpar  för klasser att tillhandahålla olika implementeringar av metoder  med samma namn.


            //F: 3.4.13. 1.En Abstract klass kan ha båda abstrakt metoder som overides i subklass och vanlig metoder men
            //              ett Interface class kan bara definiera metoder som måte användas i subclasses.
            //           2. Interface tillåt mutiple interface men abstract tillåt den inte.
        }



        //solutions for 3.3
        private static void PolymorfismSolution1()
        {
            var dog = new Dog("doggy", 2, 6, true,"Sam");
            var worm = new Worm("Earthworm", 1, 0.002, false);
            var horse = new Horse("Horsy", 4, 40, 156);
            var hedgehog = new Hedgehog("spiky hedgehog", 2, 5, 2000);
            var wolf = new Wolf("wolfy", 15, 56, true);
            var bird = new Bird("birdie", 2, 1.3, 46);
            var wolfman = new Wolfman("Alfa wolf", 22, 60, false);
            var dog2 = new Dog("chihua", 3, 2, true, "Sam");
            var dog3 = new Dog("fredo", 5, 12, false, "");

            var animal = new List<Animal>();
            animal.Add(dog);
            animal.Add(worm);
            animal.Add(horse);
            animal.Add(hedgehog);
            animal.Add(wolf);
            animal.Add(bird);
            animal.Add(wolfman);

            foreach (var item in animal)
            {
                Console.WriteLine($"Name: {item.Name} , Age: {item.Age}, Weight: {item.Weight}.");
                item.DoSound();
                if (item is IPerson person)
                {
                    Console.WriteLine(person.Talk());
                }
                //F: 3.3.16 . Nej,det åt inte metoden 'Shelter()' som skriver  i dog i animal listan 
                //F: 3.3.17 . för att dog arvar från animal men animal inte arvar från dog
                //        och den methoden bara tillåt från Dog class object eller class obj som arvar från dog
                if(item is Dog dog1)
                {
                    Console.WriteLine(dog1.Shelter());
                }
                Console.WriteLine();

            }
            
                      
            var doglist = new List<Dog>();
            doglist.Add(dog2);
            doglist.Add(dog3);
            // doglist.Add(horse);F: 3.3.9.  horse och dog är objekt som är från olika class
            //                            som har ingen koppling so vi  kan inte covert horse till dog

            // F: 3.3.10. listan måste vara Animal typ for att kunn lagras tillsammans 

            foreach (var d in doglist)
            {
                Console.WriteLine($"{d.Name} is of age {d.Age} weights {d.Weight} kg {d.Stats()}");
            }

        }




        //solution for 3.1.3 to 3.1.5
        private static void InkapslingSolution3()
        {
            var persons = new List<Person>();
            persons.Add(ph.CreatePerson(33,"Gary","lolita",155,49));
            persons.Add(ph.CreatePerson(31,"lary","lwwolita",159,65));
            persons.Add(ph.CreatePerson(33,"mary","loyyta",165,66));

            foreach (var item in persons)
            {
                string vote = ph.Vote(item.Age);
                
                //Console.WriteLine(item.ToString() + $" {vote}");
               
                var res = new StringBuilder();
                res.Append(item.ToString());
                res.Append(vote);

                Console.WriteLine(res);
            }

           

        }


        //solution for 3.1.2
        private static void InkapslingSolution2()
        {
            ph.SetAge(per, 30);
            Console.WriteLine($"age: {per.Age}");
        }

            

        //solution for 3.1.1
        public static void InkapslingSolution1()
        {
            try
            {
                 //per.Age = 0;
                per.Age = 20;
                //per.Fname = "mo";
                //per.Fname = "checktengreater";
                per.Fname = "Tom";
               // per.Lname = "tin";
                //per.Lname = "checkfifteengreater";
                per.Lname = "Karlsson";
                per.Height = 168;
                per.Weight = 65;

                Console.WriteLine($"{per.Fname} {per.Lname} is {per.Age} old and is {per.Height}cm tall and weights {per.Weight}kg");
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


               

        }

             

    }
               
}
              

           




               

            






           



