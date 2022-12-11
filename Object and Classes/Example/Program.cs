using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
        //{
            //dog.Name = "Sharo";
            //dog.Breed = "PitBull";
            //dog.Age = 12;
        //}
            dog.Name = "Sharo";
            dog.Breed = "PitBull";
            dog.Age = 12;

            Dog dog2 = new Dog();
            
            dog2.Name = "Luki";
            dog2.Breed = "Ulichna Prevuzhodna";
            dog2.Age = 10;
            Random random = new Random();
            int randomNumber = random.Next(0, 10);//EXCLUDING 10

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Breed);
            Console.WriteLine(dog.Age);

            Console.WriteLine(dog2.Name);
            Console.WriteLine(dog2.Breed);
            Console.WriteLine(dog2.Age);
            Console.WriteLine(randomNumber);
        }
    }
}
