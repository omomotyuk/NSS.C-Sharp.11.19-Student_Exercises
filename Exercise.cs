using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Exercise
    {
        // You must define a type for representing an exercise in code. An exercise can be assigned to many students
        public string Name {get;}
        // Language of exercise (JavaScript, Python, CSharp, etc.)
        public string Language {get;}
        public Exercise( string name, string language )
        {
            Name = name;
            Language = language;
        }
    }
}
