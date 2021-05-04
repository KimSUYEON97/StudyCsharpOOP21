using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        //public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { /*...*/ } // 사실상 만들어 줄 필요 없음

        public Cat(string name,string color,int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age; //initialization
            
        }

        public Cat(string name,string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public Cat(string color,int age)
        {
            this.Color = color;
            this.Age = age;
        }

        public void Meow() 
        {
            //Console.WriteLine("{0} {1}, 야옹", this.Color,this.Name);//{0}은 ',' 뒤의 0번째(배열 처럼)부터 집어 넣는다.
            Console.WriteLine($"{this.Color} {this.Name}, 야옹");
        }


        /*public override void Sleep()
        {
            base.Sleep();//base는 내가 상속한 부모의 sleep 함수
        }//override 입력후  ctrl+space+tap 시 자동 생성됨*/

        public override void Sleep()//virtual 붙일 경우 override가능,  virtual없으면 override불가능 -> 상속시 override!
        {
            //base.Sleep();
            Console.WriteLine($"{this.Color} Cat {this.Name} is zzz... sleeping");
        }
    }//alt shift enter - 전체 화면 변환
}
