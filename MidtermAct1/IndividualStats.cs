using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermAct1
{
    public class IndividualStats { 
    
        public int GetFinalAverage(Student StudentInfo)
        {
            double total = 0;
            double PrelimWeight = Math.Floor(StudentInfo.PrelimGrade) * 0.3;
            double MidtermWeight = Math.Floor(StudentInfo.MidtermGrade) * 0.3;
            double FinalsWeight = Math.Floor(StudentInfo.FinalsGrade) * 0.4;
            total = PrelimWeight + MidtermWeight + FinalsWeight;
            return (int) Math.Ceiling(total);
        }

    }
}
