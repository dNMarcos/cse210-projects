using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle ="Software Engineer";
        job1._company ="Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2002;
        job2._jobTitle = "Manager";
        job2._company ="Apple";
        job2._startYear = 1999;
        job2._endYear = 2005;
        job1.jobsDisp();
        job2.jobsDisp();

        /*Console.WriteLine("Hello Learning02 World!");*/
    }
}