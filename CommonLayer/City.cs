using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class City
    {
        private string airPort;
        public string name;
        public string AirPort
        {
            get
            {
                return airPort;
            }
            set
            {

                airPort = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
            }
        }
        public City(string name, string airPort)
        {
            Name = name;
            AirPort = airPort;
 
        }
    }
}
