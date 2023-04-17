using System;
using System.Collections.Generic;

namespace animals_mobile
{
    public class CreateAnimal
    {
        /*public Pet CreateNewAnimal() {
        Console.WriteLine("What type of animal do you want to create? ");
        Console.Write("Press 1 for cat, 2 for Dog => ");
        int animalType = Convert.ToInt32(Console.ReadLine());
        string animalName;
        int mousesKilled;
        bool isFriendly;
            if (animalType == 1)
        {
            Console.Write("Name of cat? => ");
            animalName = Console.ReadLine();
            Console.Write("Number of mouses killed? => ");
            mousesKilled = Convert.ToInt32(Console.ReadLine());
            return new Cat(animalName, mousesKilled);
        } else if (animalType == 2)
        {
            Console.Write("Name of dog? => ");
            animalName = Console.ReadLine();
            Console.Write("Is friendly? (y/n) => ");
            string dogIsFriendly = Console.ReadLine();
            if (dogIsFriendly == "y")
            {
                isFriendly = true;
            }
            else
            {
                isFriendly = false;
            }
            return new Dog(animalName, isFriendly);
        }
        else
        {
            Console.Write("Invalid selection");
            return null;
        }
        }*/
        

        public void CreateNewPet()
        {
            Console.WriteLine("What type of animal do you want to create? ");
            Console.Write("Press 1 for cat, 2 for Dog => ");
            int animalType = Convert.ToInt32(Console.ReadLine());
            if (animalType == 1)
            {
                createCat();
            } else if (animalType == 2)
            {
                createDog();
            }
            else
            {
                Console.Write("Invalid selection");
            }
        }

        public Cat createCat()
        {
            string animalName;
            int mousesKilled;
            Console.Write("Name of cat? => ");
            animalName = Console.ReadLine();
            Console.Write("Number of mouses killed? => ");
            mousesKilled = Convert.ToInt32(Console.ReadLine());
            return new Cat(animalName, mousesKilled);
        }

        public Dog createDog()
        {
            string animalName;
            bool isFriendly;
            Console.Write("Name of dog? => ");
            animalName = Console.ReadLine();
            Console.Write("Is friendly? (y/n) => ");
            string dogIsFriendly = Console.ReadLine();
            if (dogIsFriendly == "y")
            {
                isFriendly = true;
            }
            else
            {
                isFriendly = false;
            }
            return new Dog(animalName, isFriendly);
        }
        
    }
}