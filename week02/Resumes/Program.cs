using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Company";
        job1._startDate = "2018";
        job1._endDate = "2020";

        Job job2 = new Job();
        job2._jobTitle = "Data Scientist";
        job2._company = "Data Company";
        job2._startDate = "2020";
        job2._endDate = "2022";

        Resume resume = new Resume();
        resume._name = "John Doe";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}