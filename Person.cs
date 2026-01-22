using System;
using System.Collections.Generic;
using System.Text;

namespace A_2_3_1
{
    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

    }
}
