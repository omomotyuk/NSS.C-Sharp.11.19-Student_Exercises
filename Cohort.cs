using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Cohort
    {
        // You must define a type for representing a cohort in code
        public string Name {get;}
        // The collection of students in the cohort
        public List<Student> Students = new List<Student>();
        // The collection of instructors in the cohort
        public List<Instructor> Instructors = new List<Instructor>();
        public Cohort( string name )
        {
            Name = name;
        }
    }
}
