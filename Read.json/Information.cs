using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Read.json
{
    public class Information
    {
        public School school { get; set; }
    }
    public class School
    {
        public Introduce Introduce { get; set; }

        public Region Region { get; set; }

        public List<Detailed_address> Detailed_address { get; set; }

    }
    public class Introduce
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Number { get; set; }
    }

    public class Region
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
    public class Detailed_address
    {
        public string Address { get; set; }
    }
}

