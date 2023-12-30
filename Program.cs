using System;

namespace abstractclassassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.

            Employee sam = new Employee() { firstName = "sample", lastName = "student" };

            //call SayName() method on object

            sam.SayName();


            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittable = new Employee();
            quittable.Quit(sam);

            Console.ReadLine();
        }
    }
}
