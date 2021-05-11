using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestApp
{
    class Test5
    {
        interface IAnimal
        {
            int Age { get; set; }
            string Name { get; set; }
            void Eat();
            void Sleep();
            void Sound();
        }

        class Dog : IAnimal
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"Dog {this.Name} is eating lunch");
            }

            public void Sleep()
            {
                Console.WriteLine($"{this.Age}살 {this.Name} 강아지는 자고 있다.");
            }

            public void Sound()
            {
                Console.WriteLine($"Dog {this.Name} Barks WangWang");
            }
        }

        class Cat : IAnimal
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public void Eat()
            {
                Console.WriteLine($"Cat {this.Name}는 츄르를 먹는 중 이다");

            }

            public void Sleep()
            {
                Console.WriteLine($"{this.Age}살 {this.Name} 고양이는 자고 있다.");
            }

            public void Sound()
            {
                Console.WriteLine($"Cat {this.Name} MeowMeow");

            }
        }

        class Horse : IAnimal
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public void Eat()
            {
                Console.WriteLine($"Horse {this.Name} eats straw");
            }

            public void Sleep()
            {
                Console.WriteLine($"{this.Age}살 {this.Name} 말은 자고 있다.");
            }

            public void Sound()
            {
                Console.WriteLine($"Horse {this.Name} is neighing");
            }
        }

        static void Main(string[] args)
        {
            IAnimal doggy = new Dog {Name = "바둑이",Age=5};
            IAnimal kitty = new Cat {Name = "나비",Age=4};
            IAnimal horsy = new Horse {Name = "얼룩말",Age=7};

            doggy.Eat();
            doggy.Sleep();
            doggy.Sound();
            Console.WriteLine();

            kitty.Eat();
            kitty.Sleep();
            kitty.Sound();
            Console.WriteLine();

            horsy.Eat();
            horsy.Sleep();
            horsy.Sound();

        }
    }
}
