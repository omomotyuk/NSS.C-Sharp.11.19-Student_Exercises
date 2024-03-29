using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Student : NSSPerson
    {
        // You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time
        // The collection of exercises that the student is currently working on
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string firstName, string lastName, string slackHandle, string cohort):
            base(firstName, lastName, slackHandle, cohort) { }

        public void AddExercise(List<Exercise> exercises, string practice)
        {
            Exercises.Add(exercises.Find(exercise => exercise.Name == practice));
        }

        public void GetExercises()
        {
            if (Exercises.Count != 0)
            {
                Console.Write($"Student {FirstName} {LastName} has following exercises:\n");
                foreach (Exercise exercise in Exercises)
                {
                    Console.Write($"{exercise.Name} in {exercise.Language}\n");
                }
            }
            else
            {
                Console.Write($"Student {FirstName} {LastName} has not exercises.");
            }
        }
    }
}