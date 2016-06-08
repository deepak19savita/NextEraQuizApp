using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiztest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new QuizAppContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Subject { SubjectName = name };
                db.Subjects.Add(blog);
                db.SaveChanges();
                
                // Display all Blogs from the database 
                var query = from b in db.Subjects
                            orderby b.SubjectName
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.SubjectName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 
        }
    }
}
