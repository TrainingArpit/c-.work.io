using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits =new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Peach");
            fruits.Add("Kiwi");

            Console.WriteLine("Fruits in the list");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("\nFirst fruit: " + fruits[0]);
            Console.WriteLine("\nTotal fruits : " + fruits.Count);

            fruits.Remove("Banana");
            Console.WriteLine("\nTotal fruits after removal : " + fruits.Count);

            if (fruits.Contains("Mango"))
            {
                Console.WriteLine("\nMango is in the list.\n");
            }
        }
    }
}
