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
        private decimal _Height;
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
                //internal to the property, incoming data will be placed in a common variable called value
                //a property is associated with a single data member
                if (string.IsNullOrEmpty(value))
                {
                    _Manufacturer = null;
                }

                else
                {
                    _Manufacturer = value;
                }

                //alternate code for IF statements **only if the true/false is a single value (not a path)
                // _Manufacturer = string.IsNullOrEmpty(value) ? null : value;

            }
        }

        //example for an AUto Implemented property
        //auto implemented properties can be used when there is NO NEED for additional processing against the incoming data
        //NO internal private data member is required for this property
        //the system will internally generate a storage area for the data
        //access to the stored data (getting or setting) CAN ONLY be done via the property
        public decimal Width { get; set; }

        //let's fuly implement Height with a criteria of being > 0
        public decimal Height
        {
            get
            {
                return _Height;
            }

            set
            {
                //the m indicates the value is async decimal
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0.");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        //Why do we not need to fully implement a nullable numeric?
        //Numerics have a default of zero
        //Numerics can only store a numeric unless nullable.
        //Numerics can be null if declared as nullable
        //IF the numeric has additional criteria/limitations, then you can code the property as a fully implemented property
        public int? NumberOfPanes { get; set; }

        //Constructors
        //a constructor is "a method" that guarantees that the newly created isntance of this class will ALWAYS be created in a known state.

        //constructors are optional, but IF  a class DOES NOT have a constructor, then the system will generate the class instance using the datatype defaults.
        //this situation of no constructors uses what is referred to as a "System constructor"

        //If you code a constructor, you MUST code anya nd all constructors needed by your class.

        //constructors CAN receive a list of parameters,
        //two common constructors for classes are the Default and the Greedy constructor

        //Default constructor
        //this version of the constructor takes NO parameters
        //this usually similates the system constructor, but we have to code this one if we have coded the greedy one.
        //you CAN if you wish, assign values to your class data members/properties that are NOT the system default for that data type
        //NO RETURN DATATYPE
        //This "method" is called on your behalf when an instance of the class is requested by the outside user.
        //You CAN NOT call this "method" directly
        public Window()
        {
            //default constructor

            NumberOfPanes = 1;
            Height = 0.9m;
        }

        //Greedy constructor
        //takes in a value for each data member/property in the class
        //each data member/property is assigned the incoming parameter value

        public Window(decimal width, decimal height, int? numberofpanes, string manufacturer)
        {
            Width = width;
            Height = height;
            Manufacturer = manufacturer;
            NumberOfPanes = numberofpanes;
        }

        //Behaviors (method)
        //Optional

        //Area of a window
        public decimal WindowArea()
        {
            return Width * Height;
        }
        //Perimeter of a Window
        public decimal WindowPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
