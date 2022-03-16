using classtraining.models;
using System;


namespace classtraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pp1 = new Person("alim", 25, 26);
            pp1.name = "Fuad";
            pp1.surname = "Rasulzade";
            pp1.age = 28;
            pp1.weight = 75;
            pp1.profession = "sales";
            pp1.fullname();
            pp1.wght();


         //   Console.WriteLine(pp1.wght());









        }
    }


}





