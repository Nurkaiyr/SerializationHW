using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> listBooks = new List<Book>()
            {
                new Book
                {
                    Name= "Джейн Эйр",
                    Price = 1500,
                    Author = "Шарлотта Бронте",
                    Year = 2011,
                }
            };

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(@"C\:books.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, listBooks);
            }

            using (FileStream stream = new FileStream(@"C:\books.txt", FileMode.OpenOrCreate))
            {
                var bookList = formatter.Deserialize(stream) as List<Book>;
            }

        }
    }
}
