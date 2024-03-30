using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermAct1
{
    public class OverallStats
    {
        public double GetPrelimMean(List<Student> StudentInfo)
        {
            double CumulativeSum = 0;
            foreach (Student student in StudentInfo)
            {
                CumulativeSum += student.PrelimGrade;
            }
            double Mean = CumulativeSum / StudentInfo.Count;
            return Mean;
        }

        public double GetMidtermMean(List<Student> StudentInfo)
        {
            double CumulativeSum = 0;
            foreach (Student student in StudentInfo)
            {
                CumulativeSum += student.MidtermGrade;
            }
            double Mean = CumulativeSum / StudentInfo.Count;
            return Mean;
        }

        public double GetFinalsMean(List<Student> StudentInfo)
        {
            double CumulativeSum = 0;
            foreach (Student student in StudentInfo)
            {
                CumulativeSum += student.FinalsGrade;
            }
            double Mean = CumulativeSum/StudentInfo.Count;
            return Mean;
        }

        public double GetPrelimMedian(List<Student> StudentInfo)
        {
            List<double> PrelimGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                PrelimGrades.Add(student.PrelimGrade);
            }
            PrelimGrades.Sort();
            if(PrelimGrades.Count%2 == 0)
            {
                int First = PrelimGrades.Count/2 - 1;
                int Second = PrelimGrades.Count / 2;
                double Median = (PrelimGrades[First] + PrelimGrades[Second])/2;
                return Median;
            } else
            {
                int Index = (int)Math.Floor((double)PrelimGrades.Count / 2);
                return (PrelimGrades[Index]);
            }
        }
        
        public double GetMidtermMedian(List<Student> StudentInfo)
        {
            List<double> MidtermGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                MidtermGrades.Add(student.MidtermGrade);
            }
            MidtermGrades.Sort();
            if(MidtermGrades.Count%2==0)
            {
                int First = MidtermGrades.Count / 2 - 1;
                int Second = MidtermGrades.Count / 2;
                double Median = (MidtermGrades[First] + MidtermGrades[Second]) / 2;
                return Median;
            } else
            {
                int Index = (int)Math.Floor((double)MidtermGrades.Count / 2);
                return (MidtermGrades[Index]);
            }
        }

        public double GetFinalsMedian(List<Student> StudentInfo)
        {
            List<double> FinalsGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                FinalsGrades.Add(student.FinalsGrade);
            }
            FinalsGrades.Sort();
            if (FinalsGrades.Count % 2 == 0)
            {
                int First = FinalsGrades.Count /2 - 1;
                int Second = FinalsGrades.Count / 2;
                double Median = (FinalsGrades[First] + FinalsGrades[Second]) / 2;
                return Median;
            } else
            {
                int Index = (int)Math.Floor((double)FinalsGrades.Count / 2);
                return (FinalsGrades[Index]);
            }
        }
        
        public double GetPrelimMode(List<Student> StudentInfo)
        {
            List<double> PrelimGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                PrelimGrades.Add(student.PrelimGrade);
            }
            double mode = 0;
            if(PrelimGrades.Count != 0)
            {
                var n = PrelimGrades.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key);
                if(n.Any(x => x.Count() > 1))
                {
                    mode = n.Select(x => x.Key).FirstOrDefault();
                } else
                {
                    return -1;
                }
            } else
            {
                return -1;
            }
            return mode;
        }

        public double GetMidtermMode(List<Student> StudentInfo)
        {
            List<double> MidtermGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                MidtermGrades.Add(student.MidtermGrade);

            }
            double mode = 0;
            if(MidtermGrades.Count != 0)
            {
                var n = MidtermGrades.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key);
                if(n.Any(x => x.Count() > 1))
                {
                    mode = n.Select(x=>x.Key).FirstOrDefault();
                } else
                {
                    return -1;
                }

            }
            else
            {
                return -1;
            }
            return mode;
        }

        public double GetFinalMode(List<Student> StudentInfo)
        {
            List<double> FinalsGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                FinalsGrades.Add(student.FinalsGrade);
            }
            double mode = 0;
            if (FinalsGrades.Count != 0)
            {
                var n = FinalsGrades.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key);
                if (n.Any(x => x.Count() > 1))
                {
                    mode = n.Select(x => x.Key).FirstOrDefault();
                }
                else
                {
                    return -1;
                }

            }
            else
            {
                return -1;
            }
            return mode;
        }

        public double GetPrelimVariance(List<Student> StudentInfo)
        {
            List<double> PrelimGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                PrelimGrades.Add(student.PrelimGrade);
            }
            double mean = PrelimGrades.Average();
            return PrelimGrades.Average(x => Math.Pow((x - mean), 2));
        }

        public double GetMidtermVariance(List<Student> StudentInfo)
        {
            List<double> MidtermGrades = new List<double>();
            foreach (Student student in StudentInfo)
            {
                MidtermGrades.Add(student.MidtermGrade);
            }
            double mean = MidtermGrades.Average();
            return MidtermGrades.Average(x => Math.Pow((x - mean), 2));
        }
        public double GetFinalVariance(List<Student> StudentInfo)
        {
            List<double> FinalsGrades = new List<double>();
            foreach (Student student in StudentInfo)
            {
                FinalsGrades.Add(student.FinalsGrade);
            }
            double mean = FinalsGrades.Average();
            return FinalsGrades.Average(x => Math.Pow((x - mean), 2));
        }

        public double GetPrelimStDev(List<Student> StudentInfo)
        {
            return Math.Sqrt(GetPrelimVariance(StudentInfo));
        }
        public double GetMidtermStDev(List<Student> StudentInfo)
        {
            return Math.Sqrt(GetMidtermVariance(StudentInfo));
        }
        public double GetFinalsStDev(List<Student> StudentInfo)
        {
            return Math.Sqrt(GetFinalVariance(StudentInfo));
        }
        public double GetPrelimRange(List<Student> StudentInfo)
        {
            List<double> PrelimGrades = new List<double>();
            foreach (Student student in StudentInfo)
            {
                PrelimGrades.Add(student.PrelimGrade);
            }
            PrelimGrades.Sort();
            return PrelimGrades[PrelimGrades.Count() - 1] - PrelimGrades[0];
        }

        public double GetMidtermRange(List<Student> StudentInfo)
        {
            List<double> MidtermGrades = new List<double>();
            foreach (Student student in StudentInfo)
            {
                MidtermGrades.Add(student.MidtermGrade);
            }
            MidtermGrades.Sort();
            return MidtermGrades[MidtermGrades.Count() - 1] - MidtermGrades[0];
        }

        public double GetFinalsRange(List<Student> StudentInfo)
        {
            List<double> FinalsGrades = new List<double>();
            foreach(Student student in StudentInfo)
            {
                FinalsGrades.Add(student.FinalsGrade);
            }
            FinalsGrades.Sort();
            return FinalsGrades[FinalsGrades.Count() - 1] - FinalsGrades[0];
        }
    }
    
}
