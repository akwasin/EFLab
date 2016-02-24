using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_4_Crud
{
    class Program
    {


        public static void ListAuthors()
        {
            List<Author> authors = DBHelper.GetAuthors();

            foreach (var author in authors)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName}");
            }
            // skapar en metod med namnet i dbhelper
            //Program p = new Program();
            //int i = p.NyMetod("AJ", 35);
        }

        private static void ListAuthorsByChar()
        {
            Console.Write("Enter a name: ");
            string userInput = Console.ReadLine();
            List<Author> authors = DBHelper.GetAuthorByChar(userInput);

            authors.ForEach(a => Console.WriteLine($"{a.FirstName} {a.LastName}"));
        }
        
        private static void SearchAuthorID()
        {
            Console.WriteLine("Enter a ID");
            string userInput = Console.ReadLine();
            List<Author> authors = DBHelper.GetAuthorByChar(userInput);


        }

        private int NyMetod(string s, int y)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            bool looper = true;
            Console.WriteLine("1 - List all authors");
            Console.WriteLine("2 - Find author by character");
            Console.WriteLine("3 - Search authors ID");
            Console.WriteLine("4 - Edit author");
            Console.WriteLine("5 - Add author");
            Console.WriteLine("6 - Update author");
            Console.WriteLine("7 - Find author by name");
            Console.WriteLine("8 - Remove author");
            Console.WriteLine("9 - Update author age");
            Console.WriteLine("10 - Exit");

            while (looper)
            {
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ListAuthors();
                        break;
                    case "2":
                        ListAuthorsByChar();
                        break;
                    case "3":
                        // hejhej
                        break;
                    case "4":
                        // hejhej
                        break;
                    case "5":
                        // hejhej
                        break;
                    case "6":
                        // hejhej
                        break;
                    case "7":
                        // hejhej
                        break;
                    case "8":
                        // hejhej
                        break;
                    case "9":
                        // hejhej
                        break;
                    case "10":
                        looper = false;
                        Console.WriteLine("Quitting..");
                        System.Threading.Thread.Sleep(2000);
                        return;
                }
            }

            /*
            Skapa	en	ny	Konsol	Applikation
                • Du	ska	använda	Separation	of	concerns	I	applkationen
                • Din	konsol	App	ska	kunna	göra	följande
                o Visa	en	lista	på	alla	Författare
                o Kunna	hitta	en	författare	som	startar	på	en	viss	sträng.	Den	ska	söka	både	I	
                förnamn	och	efternamn.
                o Hitta	en	författare	baserat	på	ID
                o Lägga	till en	ny	författare.
                o Uppdatera	en	författares	Namn
                § Hitta	en	författare	genom	att	skriva	in	bade	förnamn	och	efternamn.
                § Om	fler	en	en	författare	hittas	ge	då	ett	meddelande	om	detta.
                § När	författaren	hittats	be	om	både	för	och efternamn	och	uppdatera	
                detta	i Databasen.
                o Ta	bort	en	författare (Hur	vill	du	kunna	hitta	honom??)
                o Uppdatera	en	författares	ålder
                • Din	app	ska	innehålla	felhantering /statusmeddelanden.
                o Dvs	om	t	ex	något	inte	hittas	ska	det	komma	ett	meddelande	om	detta
                o Programmet	ska	inte	krascha	om	man	matar	in	t	ex	ett	id	som	inte	finns.
            */
        }

        
    }
}
