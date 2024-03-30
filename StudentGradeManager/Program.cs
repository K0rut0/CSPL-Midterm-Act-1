using MidtermAct1;
using static MidtermAct1.OverallStats;
using static MidtermAct1.Student;

static void GetStudentInfo(List<Student> students)
{
    using(var reader = new StreamReader(@"../cspls.csv"))
    {
        while(!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');
            string StudentName = values[0];
            double PrelimGrade = double.Parse(values[1]);
            double MidtermGrade = double.Parse(values[2]);
            double FinalsGrade = double.Parse(values[3]);
            Student NewStudent = new Student(StudentName, PrelimGrade, MidtermGrade, FinalsGrade);
            students.Add(NewStudent);
        }
    }
}

List<Student> Students = new List<Student>();
GetStudentInfo(Students);
OverallStats OverallManager = new OverallStats();
IndividualStats IndividualManager = new IndividualStats();

Console.WriteLine("\t\t\tPrelim\t\tMidterm\t\tFinals");
//Mean
Console.WriteLine(
    "Mean\t\t\t"+
    Math.Round(OverallManager.GetPrelimMean(Students), 2)+
    "\t\t"+
    Math.Round(OverallManager.GetMidtermMean(Students),2)+
    "\t\t"+
    Math.Round(OverallManager.GetFinalsMean(Students), 2)
    );
//Median
Console.WriteLine(
    "Median\t\t\t"+
    Math.Round(OverallManager.GetPrelimMedian(Students),2)+
    "\t\t"+
    Math.Round(OverallManager.GetMidtermMedian(Students),2)+
    "\t\t"+
    Math.Round(OverallManager.GetFinalsMedian(Students), 2)
    );
//Mode
string pr, mt, fs;
pr = OverallManager.GetPrelimMode(Students).ToString();
mt = OverallManager.GetMidtermMode(Students).ToString();
fs = OverallManager.GetFinalMode(Students).ToString();

if(pr == "-1")
{
    pr = "No Mode";
}
if(mt == "-1")
{
    mt = "No Mode";
}
if(fs == "-1")
{
    fs = "No Mode";
}
Console.WriteLine(
    "Mode\t\t\t"+pr+"\t\t"+mt+"\t\t"+fs
    );
//Variance
Console.WriteLine(
    "Variance\t\t"+
    Math.Round(OverallManager.GetPrelimVariance(Students), 2) +
    "\t\t"+
    Math.Round(OverallManager.GetMidtermVariance(Students), 2) +
    "\t\t"+
    Math.Round(OverallManager.GetFinalVariance(Students), 2)
    );
//Standard Deviation
Console.WriteLine(
    "Standard Deviation\t"+
    Math.Round(OverallManager.GetPrelimStDev(Students),2) +
    "\t\t"+
    Math.Round(OverallManager.GetMidtermStDev(Students), 2) +
    "\t\t"+
    Math.Round(OverallManager.GetFinalsStDev(Students), 2)
    );
//Range
Console.WriteLine(
    "Range\t\t\t"+
    Math.Round(OverallManager.GetPrelimRange(Students), 2)+
    "\t\t"+
    Math.Round(OverallManager.GetMidtermRange(Students), 2)+
    "\t\t"+
    Math.Round(OverallManager.GetFinalsRange(Students), 2)
    );
Console.WriteLine();
Console.WriteLine("Student Name\t\tPrelim\t\tMidterm\t\tFinals\t\tFinal Average");
foreach( var student in Students)
{
    Console.WriteLine(
        student.StudentName+
        "\t\t"+
        Math.Floor(student.PrelimGrade)+
        "\t\t"+
        Math.Floor(student.MidtermGrade)+
        "\t\t"+
        Math.Floor(student.FinalsGrade)+
        "\t\t"+
        IndividualManager.GetFinalAverage(student)
        );
}
