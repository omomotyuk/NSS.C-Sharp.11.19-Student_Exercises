using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Instructor
    {
        /*
            // You must define a type for representing an instructor in code.
            First name
            Last name
            Slack handle
            The instructor's cohort
            The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
            A method to assign an exercise to a student
        */
        public string FirstName {get;}
        public string LastName {get;}
        public string SlackHandle {get;}
        public string Cohort {get;}
        public string Specialty {get;}

        public Instructor(){

        }
        public Instructor( string firstName, string lastName, string slackHandle, string cohort )
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        public void GetInfo()
        {
            Console.WriteLine(
                $"First name: {FirstName}\n" +
                $"Last name: {LastName}\n" +
                $"Slack: {SlackHandle}\n" +
                $"Cohort: {Cohort}"
                );
        }
    }
}
