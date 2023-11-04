using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        private string color;
        private string model;

        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
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
            StringBuilder seat = new StringBuilder();
            seat.Append($"{Color()} Seat {Model()} ");
            seat.AppendLine();
            seat.AppendLine(Start());
            seat.Append(Stop());
            return seat.ToString();
        }
    }
}
