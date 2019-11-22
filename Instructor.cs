using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    public class Instructor : NSSPerson
    {
        // You must define a type for representing an instructor in code.
        // The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        public string Specialty { get; }

        public Instructor(string firstName, string lastName, string slackHandle, string cohort):
            base(firstName, lastName, slackHandle, cohort) { }

        // A method to assign an exercise to a student
        public void AssignTo(List<Student> students, string firstName, List<Exercise> exercises, string exercise)
        {
            students.Find(student => student.FirstName == firstName).AddExercise(exercises, exercise);
        }

        public void GetInfo()
        {
            Console.WriteLine(
                $"First name: {FirstName}\n" +
                $"Last name: {LastName}\n" +
                $"Slack: {SlackHandle}\n" +
                $"Cohort: {Cohort}");
        }
    }
}