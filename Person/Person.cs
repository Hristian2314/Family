using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string name;
        public int age;

        public void IntroduseYoureSelf()
        {
            Console.WriteLine($" az sum {this.name} i sum na {this.age}");
        }
    }
}
