using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_4_Crud
{
    public static class DBHelper
    {
        public static List<Author> GetAuthors()
        {
            using (var db = new BooksDB())
            {
                var authors = db.Authors;
               

                return authors.ToList();
            }
        }

        public static List<Author> GetAuthorByChar(string userInput)
        {
            using (var db = new BooksDB())
            {
                var authors = db.Authors.Where(a => a.FirstName.StartsWith(userInput) || a.LastName.StartsWith(userInput));

                return authors.ToList();
            }
                
        }
    }
}
