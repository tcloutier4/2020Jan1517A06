using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the window class using the default constructor.
            //program NEVER calls a constructor directly
            //hte new will use the suggested constructor
            //the actual call to the constructor is done by new
            Window window = new Window();

            //to place data within the new instance of the class (object), use the properties.
            //to reference a property within an instance use the dot operator
            Console.WriteLine($"Width {window.Width}; height {window.Height}; Panes {window.NumberOfPanes}; Manufacturer {window.Manufacturer}");
            window.Manufacturer = "All weather";
            window.Width = .9m;
            window.NumberOfPanes = 2;

            Console.WriteLine($"Width {window.Width}; height {window.Height}; Panes {window.NumberOfPanes}; Manufacturer {window.Manufacturer}");

            Window gWindow = new Window(2.6m, 1.75m, 12, "Fancy Windows");
            Console.WriteLine($"Width {gWindow.Width}; height {gWindow.Height}; Panes {gWindow.NumberOfPanes}; Manufacturer {gWindow.Manufacturer}");

            Door door = new Door();
            Console.WriteLine($"Width {door.Width}; height {door.Height}; Panes {door.RightOrLeft}; Manufacturer {door.Material}");

            Door gDoor = new Door(1.2m, 1.9m, "L", "Wood");
            Console.WriteLine($"Width {gDoor.Width}; height {gDoor.Height}; Panes {gDoor.RightOrLeft}; Manufacturer {gDoor.Material}");

            Console.WriteLine($"Default window area:{window.WindowArea()};" +
                $"\nDefault window perimeter {window.WindowPerimeter()}");

            Console.WriteLine($"Greedy window area:{gWindow.WindowArea()};" + 
                $"\nGreedy window perimeter {gWindow.WindowPerimeter()}");

            Console.WriteLine($"Default door area:{door.DoorArea()};" +
                $"\nDefault door perimeter {door.DoorPerimeter()}");

            Console.WriteLine($"Greedy door area:{gDoor.DoorArea()};" +
            $"\nGreedy door perimeter {gDoor.DoorPerimeter()}");

        }
    }
}


