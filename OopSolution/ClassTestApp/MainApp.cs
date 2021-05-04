using System;

namespace ClassTestApp
{
    //ctrl shift /
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Catobject 생성");
            /*Cat kitty = new Cat();
            kitty.Name = "Kitty";*/
            Animal kitty = new Cat("Kitty", 3);//protected일 경우 초기화 방식
            /*kitty.Age = 3;
            kitty.Color = "white";//alt+enter 하면 nero 처럼 변형 가능

            kitty.Meow();*/

            /*Cat nero = new Cat
            {
                Name = "Nero",
                Age = 12,
                Color = "black"
            };*/
            Cat nero = new Cat("Nero", "black", 12);

            nero.Meow();

            Cat mimi = new Cat("Mimi","yellow",3);

            mimi.Meow();

            Cat coco = new Cat("Coco", "threecolor");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("Nyangi","silver",10);
            //noname.Name = "nyaongi";
            noname.Meow();
            noname.Sleep();

            /*var list = ("Cat", "Dog", "Pig","Bird", 55);
            Console.WriteLine($"tuple 1th object: {list.Item1}");//문장 끝에서 ctrl c v 하면 자동 복붙
            Console.WriteLine($"tuple 2th object: {list.Item2}");
            Console.WriteLine($"tuple 3th object: {list.Item3}");
            Console.WriteLine($"tuple 4th object: {list.Item4}");//item1,2,3,4 는 동적,묵시적으로 자동 생성됨
            Console.WriteLine($"tuple 5th object: {list.Item5}");//type상관 없이 설정 가능*/

            var list = (First : "Cat",Second: "Dog",Third : "Pig", "Bird", 55);
            Console.WriteLine($"tuple 1th object: {list.First}");
            Console.WriteLine($"tuple 2th object: {list.Second}");
            Console.WriteLine($"tuple 3th object: {list.Third}");//id 지정함, item1과 함께 사용 가능
            Console.WriteLine($"tuple 4th object: {list.Item4}");
            Console.WriteLine($"tuple 5th object: {list.Item5}");

        }
    }
}
