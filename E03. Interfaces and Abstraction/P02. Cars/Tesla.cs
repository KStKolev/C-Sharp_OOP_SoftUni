using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricBattery
    {
        private string color;
        private string model;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            this.model = model;
            this.color = color;
            this.battery = battery;
        }

        public int Battery()
        {
            return battery;
        }

        public string Color()
        {
            return $"{color}";
        }

        public string Model()
        {
            return $"{model}";
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder tesla = new StringBuilder();
            tesla.Append($"{Color()} Tesla {Model()} with {Battery()} Batteries ");
            tesla.AppendLine();
            tesla.AppendLine(Start());
            tesla.Append(Stop());
            return tesla.ToString();
        }
    }
}
