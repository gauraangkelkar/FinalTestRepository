using System;

namespace FinalTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] objects = new Object[2];
            Adult adult = new Adult();
            Child child = new Child();

            objects[0] = adult;
            objects[1] = child;

            foreach(var item in objects)
            {
                if(item is Adult)
                {
                    Console.WriteLine("Printing Adult Class Properties");
                    Console.WriteLine(((Adult)item).FirstName);
                    Console.WriteLine(((Adult)item).LastName);
                }
                else
                {
                    Console.WriteLine("Printing Child Class Properties");
                    Console.WriteLine(((Child)item).FirstName);
                    Console.WriteLine(((Child)item).LastName);
                }
                
            }
        }
    }
}
