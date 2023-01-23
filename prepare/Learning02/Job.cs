
using System;
// A code template for the category of things known as Job. The
// responsibility of a Person is to hold and display the Job information
public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    public void jobsDisp()
    {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    /*internal void DispResume()
    {
        throw new NotImplementedException();
    }*/
}