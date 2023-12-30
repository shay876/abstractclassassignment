using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclassassignment
{   //Create an abstract class called Person with two properties: string firstName and string lastName.

   // Give it the method SayName().


   public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
       
    }
}
