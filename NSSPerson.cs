using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class NSSPerson
    {
        // You must define a type for representing a NSS person in code. A person can only be in one cohort at a time.
        public string FirstName {get;}
        public string LastName {get;}
        public string SlackHandle {get;}
        public string Cohort {get;}

        public NSSPerson( string firstName, string lastName, string slackHandle, string cohort )
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }
    }
}
