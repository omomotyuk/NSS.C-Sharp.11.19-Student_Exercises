using System;
using System.Collections.Generic;

namespace __11._19_Student_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instructor> instructors = new List<Instructor>();
            List<Student> students = new List<Student>();
            List<Cohort> cohorts = new List<Cohort>();
            List<Exercise> exercises = new List<Exercise>();

            // Create 3, or more, instructors and assign them to one of the cohorts
            instructors.Add(new Instructor("First", "Mayor", "First Mayor", "Cohort N1"));
            instructors.Add(new Instructor("Second", "Big", "Second Big", "Cohort N2"));
            instructors.Add(new Instructor("Third", "Small", "Third Small", "Cohort N3"));

            // Create 4, or more, students and assign them to one of the cohorts
            students.Add(new Student("Bil", "Bilson", "Bil Bilson", "Cohort N1"));
            students.Add(new Student("Bob", "Bobson", "Bob Bobson", "Cohort N2"));
            students.Add(new Student("Kim", "Kimson", "Kim Kimson", "Cohort N3"));
            students.Add(new Student("Rob", "Robson", "Rob Robson", "Cohort N3"));

            // Create 3, or more, cohorts
            cohorts.Add(new Cohort("Cohort N1"));
            cohorts.Add(new Cohort("Cohort N2"));
            cohorts.Add(new Cohort("Cohort N3"));

            // Create 4, or more, exercises
            exercises.Add(new Exercise("Daily Journal", "HTML"));
            exercises.Add(new Exercise("Celebrity Tribute", "CSS"));
            exercises.Add(new Exercise("Nutshell", "JavaScript"));
            exercises.Add(new Exercise("Tracking Student Exercises", "C#"));

            // Have each instructor assign 2 exercises to each of the students.
            Assignment(instructors, "First", students, "Bil", exercises, "Daily Journal");
            Assignment(instructors, "First", students, "Bil", exercises, "Celebrity Tribute");
            Assignment(instructors, "Second", students, "Bob", exercises, "Nutshell");
            Assignment(instructors, "Third", students, "Kim", exercises, "Tracking Student Exercises");
            Assignment(instructors, "Third", students, "Rob", exercises, "Tracking Student Exercises");

            // Generate a report that displays which students are working on which exercises
            Console.Write(
                "List of Students Exercises:\n" +
                "---------------------------\n");
            foreach (Student student in students)
            {
                student.GetExercises();
                Console.Write("\n");
            }

            /*
            // Print list of instructors
            Console.WriteLine("List of Instructors:\n");
            foreach (Instructor instructor in instructors)
            {
                instructor.GetInfo();
                Console.Write("\n");
            }
            */
        }

        static void Assignment(
            List<Instructor> instructors, string instructor,
            List<Student> students, string student,
            List<Exercise> exercises, string exercise)
        {
            instructors.Find(person => person.FirstName == instructor).AssignTo(students, student, exercises, exercise);
        }
    }
}