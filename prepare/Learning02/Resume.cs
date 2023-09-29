using System;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Dislay()
    {
        Console.WriteLine($"Name: {_name}"); 
        Console.WriteLine("Jobs:"); 
    }
} 