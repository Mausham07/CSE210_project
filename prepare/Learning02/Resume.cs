using System;
using System.Reflection;


public class Resume{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void ResumeDisplay(){
        Console.WriteLine($"Name: {_name}\nJobs:");

        foreach(Job job in _jobs){
            job.Display();
        }
    }

}