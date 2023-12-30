using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclassassignment
{ //Create another class called Employee and have it inherit from the Person class.

   // Implement the SayName() method inside of the Employee class.
    public class Employee : Person, IQuittable //Have your Employee class inherit interface interface implement the Quit() method in any way you choose.
    {   
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //implement the Quit() method 
        public void Quit(Employee employee)
        {
            Console.WriteLine("An employee has quit");
        }
       

    }
}
