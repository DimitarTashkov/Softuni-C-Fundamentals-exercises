using System;
using System.Collections.Generic;
using System.Text;

namespace test1234
{
    class Human
    {
        public String name;
        public int age;
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Pro
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Mitko", 15);
            Human h2 = new Human("az", 12);

        }
    }

}
