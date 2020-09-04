using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoniqueApi.Models
{

    //prop tab tab creates a property
    public class Pizza
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; }
    }
}
