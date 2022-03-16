using System;

namespace classtraining.models
{
    internal class Person
    {


        public string name;
        public string surname;
        public int age;
        public int weight;
        public string profession;

        public void fullname()
        {
            Console.WriteLine($"{name} { surname} ");

        }
        public int wght()
        {

            return weight;
        }
        public Person(string name) 
        {
            this.name = name;
        }
        public Person(string name, int age, int weight):this(name)
        {
            
            this.age = age;
            this.weight = weight;
        }

    }
}


