using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string color;
        public int speed;
        public Car(string color,int speed) {
            this.color = color;
            this.speed = speed;
        }

        public string getColor() {
            return this.color;
        }

        public int getSpeed(){
            return this.speed;
        }
    }
}
