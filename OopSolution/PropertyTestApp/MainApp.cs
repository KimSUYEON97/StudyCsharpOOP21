using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Dog backgu = new Dog();
            //backgu.SetAge(5);
            backgu.Age = 2500;
            backgu.Name = "backgu";

            //Console.WriteLine($"backcu's age is {backgu.GetAge()}");
            Console.WriteLine($"{backgu.Name}'s age is {backgu.Age}");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}'s color is {streetDog.Color}");

            Dog dog1 = new Dog();
            dog1.Name = "hwanggu"; dog1.Color = "yellow"; dog1.Age = 5;

            Dog dog2 = new Dog()
            {
                Name = "ggamjangi",
                Age = 5,
                Color = "black"
            };//property

            var myInstance = new { Name = "william", Age = 27 };//무명선언
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);
        }
    }
}
