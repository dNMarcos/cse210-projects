using System;

public class Resume
{
    public string _personName;
    public List<Job> _listaJ = new List<Job>();
    public void resuDisp()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: ");
        foreach(Job lista in _listaJ)
        {
            lista.jobDisp();
        }
    }

}