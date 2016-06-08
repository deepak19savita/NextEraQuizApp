using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class QuizAppContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerType> AnswerTypes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
    } 
}
