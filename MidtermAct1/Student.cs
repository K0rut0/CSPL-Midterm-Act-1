using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MidtermAct1
{
    public class Student
    {
        public string StudentName { get; set; }
        public double PrelimGrade { get; set; }
        public double MidtermGrade { get; set; }
        public double FinalsGrade { get; set; }

        public Student(string name, double prelim, double midterm, double finals) 
        {
            this.StudentName = name;
            this.PrelimGrade = prelim;
            this.MidtermGrade = midterm;
            this.FinalsGrade = finals;
        }
    }
}
