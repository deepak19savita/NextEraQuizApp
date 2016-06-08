using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans6 { get; set; }
        public string Ans5 { get; set; }
        public string Ans4 { get; set; }
        public string Ans3 { get; set; }
        public bool Correct6 { get; set; }
        public bool Correct5 { get; set; }
        public bool Correct4 { get; set; }
        public bool Correct3 { get; set; }
        public bool Correct2 { get; set; }
        public bool Correct1 { get; set; }
        public string Note { get; set; }
        public AnswerType AnswerType { get; set; }
        public string Marks { get; set; }
        public Subject Subject { get; set; }
        public Course Course { get; set; }
    }
}
