using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestApp
{
    class Boiler
    {
        private byte voltage;
        private int temperature;
        public string Brand { get; set; }
        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                if (value == 110 || value == 220)
                {
                    this.voltage = value;
                }
                else
                {

                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value <= 5)
                {
                    this.temperature = 5;
                }
                else if (value >= 70)
                {
                    this.temperature = 70;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"{Brand}, {Voltage}, {Temperature}");
        }
    }

    /*class Test2
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 115, Temperature = 0 };
            kitturami.PrintAll();
        }
    }*/
}
