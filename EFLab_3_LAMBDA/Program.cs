using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_3_LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("AJ");
            nameList.Add("Sandra");
            nameList.Add("Theodore");
            nameList.Add("Akwasi");
            nameList.Add("Thommy");
            nameList.Add("AkwasiiJunior");
            nameList.Add("Christina");
            nameList.Add("Millie");
            nameList.Add("Akwasi Junior");
            nameList.Add("Pappa");
            nameList.Add("Kofi");
            nameList.Add("A. Junior");

            Console.WriteLine("1 - View all names");
            Console.WriteLine("2 - View all names that beings with A");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine($"You Selected 1 \r\n");
                nameList.ForEach(name => Console.WriteLine(name));

            }
            else if (userChoice == "2")
            {
                Console.WriteLine("You Selected 2");
                // TODO: här är jag
                nameList.ForEach(name => Console.WriteLine(name));
            }
            System.Threading.Thread.Sleep(9000);

        }
    }
}