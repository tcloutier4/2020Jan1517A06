using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Door
    {
        private string _Material;
        private decimal _Height;
        private string _RightOrLeft;
        private decimal _Width;
        //fields Height, Width, Material (nullable), RightORLeft

        public string Material
        {
            get
            {
                return _Material;
            }

            set
            {
                //null if true, value if false
                _Material = string.IsNullOrEmpty(value) ? null : value;
            }
        }

        public string RightOrLeft
        {
            get
            {
                return _RightOrLeft;
            }
            set
            {
                if (value.ToUpper().Equals("R") || value.ToUpper().Equals("L"))
                {
                    _RightOrLeft = value.ToUpper();
                }
                else
                {
                    throw new Exception("Door opening direction must be R or L");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return _Height;
            }

            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Height must be more than 0");
                }

                else
                {
                    _Height = value;
                }
            }

        }
        public decimal Width
        {
            get
            {
                return _Width;
            }

            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Width must be more than 0");
                }

                else
                {
                    _Width = value;
                }
            }

        }

        public Door()
        {
            //This is the default constructor
            //Instead of using the system defaults, we have supplied our own defaults.
            Width = 0.8m;
            Height = 1.9m;
            RightOrLeft = "R";
        }

        public Door(decimal width, decimal height, string rightorleft, string material)
        {
            //This is the greedy constructor
            Width = width;
            Height = height;
            RightOrLeft = rightorleft;
            Material = material;
        }
    }
}
