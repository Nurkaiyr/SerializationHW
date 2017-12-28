using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHW
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
