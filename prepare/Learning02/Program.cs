using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = "2023";
        job1._endYear = "2027";

        Job job2 = new Job();
        job2._jobTitle = "Web Designer";
        job2._company = "Samsung";
        job2._startYear = "2016";
        job2._endYear = "2018";

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}