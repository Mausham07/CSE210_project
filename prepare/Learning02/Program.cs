using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Machine Learning Engineer";
        job1._company = "Microsoft";
        job1._startYear = "09/12/2021";
        job1._endYear = "12/09/2022";

        Job job2 = new Job();
        job2._jobTitle = "Architecture";
        job2._company = "Mausham PVT LTD";
        job2._startYear = "09/12/2020";
        job2._endYear = "12/09/2021";

        Resume person1 = new Resume();
        person1._name = "Mausham Bista";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.ResumeDisplay();

        

    }
}