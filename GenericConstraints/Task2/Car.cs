using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        private string name;
        private int age;
        public Car(string carname, int age)
        {
            name = carname;
            this.age = age;
        }
        public override string ToString()
        {
            return name + "-" + age;
        }
    }
}
