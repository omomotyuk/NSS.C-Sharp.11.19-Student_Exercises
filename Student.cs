using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Student
    {
        // You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time
        /*
            First name
            Last name
            Slack handle
            The student's cohort
            The collection of exercises that the student is currently working on
        */
        public string FirstName {get;}
        public string LastName {get;}
        public string SlackHandle {get;}
        public string Cohort {get;}
        public List<Exercise> Exercises = new List<Exercise>();

        public Student( string firstName, string lastName, string slackHandle, string cohort )
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

    }
}
