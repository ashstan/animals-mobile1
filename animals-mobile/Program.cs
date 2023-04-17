using System;
using System.Collections;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;

namespace animals_mobile
{
    internal class Program
    {
        private static FileOutput outFile = new FileOutput("animals.txt");
        private static FileInput inFile = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            CreateAnimal createAnimal = new CreateAnimal();

            createAnimal.CreateNewPet();
            zoo.Add(new CreateAnimal());


            zoo.Add(new Dog("Bean", true));
            zoo.Add(new Cat("Charlie", 9));
            zoo.Add(new Teacher("Stacy Read", 44));

            foreach (ITalkable thing in zoo)
            {
                PrintOut(thing);
            }
            outFile.fileClose();
            inFile.fileRead();
            inFile.fileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.fileReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            //foreach (ITalkable thing in zoo)
            //{
            //    Console.WriteLine(thing.GetName() + " says=" + thing.Talk());
            //    outFile.fileWrite(thing.GetName() + " | " + thing.Talk());
            //}

        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            outFile.fileWrite(p.GetName() + " | " + p.Talk());
        }
        
    }
    }
