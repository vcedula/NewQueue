/*/Skompilujte a spustite implementáciu frontu pomocou zreťazeného zoznamu queue.cs. Pozrite si implementáciu a pochopte ju.
Modifikujte front (queue.cs) tak, aby bolo do neho možné vkladať objekty typu osoba. Vytvorte 3 osoby a vložte a vyberte ich z frontu.
Modifikujte front (queue.cs) tak, aby bolo do neho možné vkladať ľubovoľné prvky (generický front). Demonštrujte na dvoch prikladoch (front osôb a front integer-ov).
Doplňte generický front tak, aby keď sa nad prázdnym frontom zavolá “get”m vyhodí sa výnimku typu “FrontEmptyException”. Demonštrujte na príklade.
Doplňte do generickýho frontu s výnimkou indexer, ktorý umožní prístup k ľubovoľnému prvku frontu cez index (zápis, čítanie). Ak nie je index platný, vyhodí sa výnimka “IndexOutOfBoundsException”. Demonštrujte na príklade.
/*/

using System;
using System.Collections.Generic;

namespace NewQueue
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //QUEUE<Osoba> q1 = new QUEUE<Osoba>(new
            //    string[] { "one", "two", "three", "four", "five" });

            //QUEUE<Osoba> q1 = new QUEUE<Osoba>();
            //var names = new string[] {"one", "two", "three", "four", "five"};
            //foreach (var name in names)
            //{
            //    Osoba osoba = new Osoba(name);
            //    q1.put(osoba);
            //}

            //TestQueueInt();

            //TestQueueOsoba();

            TestQueueGeneric();

            Console.ReadKey();
        }

        private static void TestQueueInt()
        {
            try
            {
                QUEUEInt qInt = new QUEUEInt();
                qInt.put(1);
                qInt.put(2);
                qInt.put(3);

                while (!qInt.isempty())
                {
                    int item = qInt.get();
                    Console.WriteLine("Item from queue: {0}", item);
                }

                //toto vrati exception
                qInt.get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestQueueOsoba()
        {
            try
            {
                QUEUEOsoba qOsoba = new QUEUEOsoba();

                qOsoba.put(new Osoba("one"));
                qOsoba.put(new Osoba("two"));
                qOsoba.put(new Osoba("three"));
                qOsoba.put(new Osoba("four"));
                qOsoba.put(new Osoba("five"));

                while (!qOsoba.isempty())
                {
                    Osoba item = qOsoba.get();
                    Console.WriteLine("Item from queue: {0}", item.Meno);
                }

                //toto vrati exception
                qOsoba.get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestQueueGeneric()
        {
            QUEUE<int> qInt = new QUEUE<int>();
            qInt.put(1);
            qInt.put(2);
            qInt.put(3);

            QUEUE<Osoba> qOsoba = new QUEUE<Osoba>();
            qOsoba.put(new Osoba("one"));
            qOsoba.put(new Osoba("two"));
            qOsoba.put(new Osoba("three"));
            qOsoba.put(new Osoba("four"));
            qOsoba.put(new Osoba("five"));

            //get index 25
            try
            {
                var indexX = qOsoba[25];
                Console.WriteLine(indexX.Meno);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //set index 3
            try
            {
                qOsoba[3] = new Osoba("index3");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                while (!qInt.isempty())
                {
                    int item = qInt.get();
                    Console.WriteLine("Item from queue: {0}", item);
                }

                qInt.get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                while (!qOsoba.isempty())
                {
                    Osoba item = qOsoba.get();
                    Console.WriteLine("Item from queue: {0}", item.Meno);
                }

                qOsoba.get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}