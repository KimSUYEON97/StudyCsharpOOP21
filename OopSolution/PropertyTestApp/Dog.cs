using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        //private string name;
        //private string color;
        //color 생략

        public string Name { get; set; } = "Noname";//noname이 초기값
        public string Color { get; set; } = "brown";//brown이 초기값
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;//
                }
                
            }
        }

        /*public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;//
            }
        }*/

        /*public string GetAge()
        {
            return $"{this.age}";
        }
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = 1;
            }
            else if (age > 15)
            {
                this.age = 15;
            }
            else 
            {
                this.age = age;
            }
        }

        public string GetName() { return this.name; }

        public void SetName(string name) { this.name = name; }

        //Eat,Sleep,Bark() 생략*/
    }
}
