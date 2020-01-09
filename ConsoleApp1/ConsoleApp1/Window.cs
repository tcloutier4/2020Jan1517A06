using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //a class represents the defined characteristics of an item
    //an item can be a physical thing (cellphone), concept (student), collection of data
    //visual studio creates your class without a specific access type
    //the default type for a class is private
    //code outside of a private class cannot use the content of the private class
    //for the class to be used by an outside user, it must be public
    public class Window
    {
        //the class can have data that is open to the user by defining it as a public datatype variablename
        //the class can have data that is restricted from the user by defining it as a private datatype variablename
        //the class can create a property that can be used to interface between the user and the private data the property will have public access

        //private data member
        private string _Manufacturer;

        //properties can be implemented in 2 ways
        //1) Fully implemented property: used because there is additional code/logic used in processing the data
        //2) Auto implemented property: used when there is no need for additional code/logic, when the data is simply saved.
        public string Manufacturer
        {
            //assume the manufacturer is a nullable string
            //that gives 3 possibilities
            //  1) there are characters
            //  2) string has no data (null)
            //  3) there is a string BUT no characters
            //there will be additional code to ensure only the first two options exists for the data
            //this requires a private data member to hold the data and property to manage the data content
            get
            {
                //returns data via the property to the outside user of the property
                return _Manufacturer;
            }

            set
            {
                //the set takes the incoming data and places that data into the private data member


            }
        }
    }
}
