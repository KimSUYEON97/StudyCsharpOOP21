using System;

namespace ClassTestApp
{
    class Animal
    {
        private int UniqueID { get; set; }//상속안됨
        protected string Name { get; set; }
        public void Eat(string meal)
        {
            Console.WriteLine($"{this.Name} eats {meal}");
        }

        public virtual void Sleep()//virtual 붙일 경우 override가능,  virtual없으면 override불가능 -> 상속시 override!
        {
            Console.WriteLine($"{this.Name} is sleeping");
        }
    }
}
