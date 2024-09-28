using System;

class Program
{
    //public string _givenName = "";
    //public string _familyName = "";
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        //Person person = new Person();
        //person._givenName = "Joseph";
        //person._familyName = "Smith";
        //person.ShowWesternName();
        //person.ShowEasternName();
        //Console.WriteLine();

        //Person person1 = new Person();
        //person1._givenName = "Isaac";
        //person1._familyName = "Brito";
        //person1.ShowEasternName();
        //person1.ShowWesternName();
        //Console.WriteLine();

        //Person person2 = new Person();
        //person2._givenName = "Emma";
        //person2._familyName = "Smith";
        //person2.ShowWesternName();
        //person2.ShowEasternName();
        Job job = new Job();
        job._companyName = "Microsoft";
        job._jobTitle = "Software Engineer";
        job._startYear = 2019;
        job._endYear = 2022;

        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Software Development";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._companyName = "Aton Technology";
        job2._jobTitle = "Project Management professional";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._companyName = "Digitel Telecommunication";
        job3._jobTitle = "System Engineer";
        job3._startYear = 2015;
        job3._endYear = 2018;

        Job job4 = new Job();
        job4._companyName = "LEGO Company";
        job4._jobTitle = "Fullstack Developer";
        job4._startYear = 2019;
        job4._endYear = 2022;

        Job job5 = new Job();
        job5._companyName = "EduTech";
        job5._jobTitle = "Telecommunication Engineer";
        job5._startYear = 2023;
        job5._endYear = 2024;

        Job job6 = new Job();
        job6._companyName = "American Airlines";
        job6._jobTitle = "Senior Programmer";
        job6._startYear = 2012;
        job6._endYear = 2014;

        Job job7 = new Job();
        job7._companyName = "Net.com";
        job7._jobTitle = "Database Programmer";
        job7._startYear = 2015;
        job7._endYear = 2017;

        Job job8 = new Job();
        job8._companyName = "USA Embassy-Uganda";
        job8._jobTitle = "Project Engineer";
        job8._startYear = 2018;
        job8._endYear = 2023;

        Resume resume = new Resume();
        resume._personName = "Allison Rose";

        Resume resume1 = new Resume();
        resume1._personName = "Alejandro Pérez";

        Resume resume2 = new Resume();
        resume2._personName = "Ryan Smith";

        resume.DisplayInformationPersonal();
        job.DisplayJobDetails();
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        resume1.DisplayInformationPersonal();
        job3.DisplayJobDetails();
        job4.DisplayJobDetails();
        job5.DisplayJobDetails();
        resume2.DisplayInformationPersonal();
        job6.DisplayJobDetails();
        job7.DisplayJobDetails();
        job8.DisplayJobDetails();
    }
}
//public Person()
//{
//
//}

//public void ShowEasternName()
//{
//    Console.WriteLine($"{_familyName}, {_givenName}");
//}

//public void ShowWesternName()
//{
//    Console.WriteLine($"{_givenName} {_familyName}");
//}
//}

//public class Blind
//{
//    public double _width;
//    public double _height;
//    public string _color;
//
//    public Blind()
//    {
//        Blind kitchen = new Blind();
//        kitchen._width = 60;
//        kitchen._height = 48;
//        kitchen._color = "white";
//        Console.WriteLine(kitchen._width);
//
//    }






