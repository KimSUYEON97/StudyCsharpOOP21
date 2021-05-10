using System;
using System.Reflection;

namespace DynCreationTestApp
{
    class Profile
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name} - {PhoneNumber}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //일반적 선언
            Profile profile1 = new Profile();
            profile1.Name = "Park chan Ho";
            profile1.PhoneNumber = "010-9975-5511";

            profile1.Print();

            //reflection 객체 생성 방식
            Type type = typeof(Profile);
            Object profile2 = Activator.CreateInstance(type);
            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phoneNumber = type.GetProperty("PhoneNumber");
            name.SetValue(profile2, "Ryu Hyun Jin", null);
            phoneNumber.SetValue(profile2, "010-0000-0000", null);

            MethodInfo print = type.GetMethod("Print");
            print.Invoke(profile2, null);
            Console.WriteLine("Hello World!");
        }
    }
}
