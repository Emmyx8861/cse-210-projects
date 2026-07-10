using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Swish Sports";
        job1._jobTitle="Market Lead Generation";
        job1._startYear=2025;
        job1._endYear=2027;

        Job job2 = new Job();
        job2._company= "Fon You";
        job2._jobTitle="Custodian";
        job2._startYear=2025;
        job2._endYear=2027;

        Resume resume = new Resume();
        resume._name= "Adewemimo Emmanuel";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}



