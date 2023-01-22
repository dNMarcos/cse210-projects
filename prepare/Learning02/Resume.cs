using System;
//git add prepare/Learning02/Program.cs
//git commit -m "Create the member variable for the list of Jobs" prepare/Learning02/Resume.cs
//prepare/Learning02/Job.cs
//prepare/Learning02/Progra.cs
//git commit -m "Befor of create the member variable, create the method or function to acces the variable" prepare/Learning02/Resume.cs
public class Resume
{
    public string _personName = "";
    public List<Job> _lJobs = new List<Job>();
    public void DispResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: {_lJobs}");

        foreach(Job ListJob in _lJobs)
        {
            Console.WriteLine(ListJob);
        }
    }






}