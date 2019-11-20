using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create 4, or more, exercises.
                Create 3, or more, cohorts.
                Create 4, or more, students and assign them to one of the cohorts.
                Create 3, or more, instructors and assign them to one of the cohorts.
            */
            List<Instructor> instructors = new List<Instructor>();
            List<Student> students = new List<Student>();
            List<Cohort> cohorts = new List<Cohort>();
            List<Exercise> exercises = new List<Exercise>();

            instructors.Add( new Instructor("First","Mayor","First Mayor","Cohort N1"));
            instructors.Add( new Instructor("Second","Big","Second Big","Cohort N2"));
            instructors.Add( new Instructor("Third","Small","Third Small","Cohort N3"));

            students.Add( new Student("Bil","Bilson","Bil Bilson","Cohort N1"));
            students.Add( new Student("Bob","Bobson","Bob Bobson","Cohort N2"));
            students.Add( new Student("Kim","Kimson","Kim Kimson","Cohort N3"));
            students.Add( new Student("Rob","Robson","Rob Robson","Cohort N3"));

            cohorts.Add( new Cohort("Cohort N1"));
            cohorts.Add( new Cohort("Cohort N2"));
            cohorts.Add( new Cohort("Cohort N3"));

            exercises.Add( new Exercise("Daily Journal","HTML"));
            exercises.Add( new Exercise("Celebrity Tribute","CSS"));
            exercises.Add( new Exercise("Nutshell","JavaScript"));
            exercises.Add( new Exercise("Tracking Student Exercises","C#"));

            //
            Console.WriteLine("List of Instructors:\n");
            foreach(Instructor instructor in instructors )
            {
                instructor.GetInfo();
                Console.Write("\n");
            }

            // Have each instructor assign 2 exercises to each of the students.
        }
    }
}
