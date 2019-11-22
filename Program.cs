using System;
using System.Collections.Generic;
using System.Linq;

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
            students.Add(new Student("Yan", "Yanson", "Yan Yanson", "Cohort N3"));

            // Create 3, or more, cohorts
            cohorts.Add(new Cohort("Cohort N1"));
            cohorts.Add(new Cohort("Cohort N2"));
            cohorts.Add(new Cohort("Cohort N3"));

            // Create 4, or more, exercises
            exercises.Add(new Exercise("Daily Journal", "HTML"));
            exercises.Add(new Exercise("Celebrity Tribute", "CSS"));
            exercises.Add(new Exercise("Nutshell", "JavaScript"));
            exercises.Add(new Exercise("Tracking Student Exercises", "C#"));

            Part1(instructors, students, cohorts, exercises);
            Part2(instructors, students, cohorts, exercises);
        }

        static void Assignment(
            List<Instructor> instructors, string instructor,
            List<Student> students, string student,
            List<Exercise> exercises, string exercise)
        {
            instructors.Find(person => person.FirstName == instructor).AssignTo(students, student, exercises, exercise);
        }

        static void Part1(List<Instructor> instructors, List<Student> students, List<Cohort> cohorts, List<Exercise> exercises)
        {
            Console.WriteLine("Part 1 of practice.\n");

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
            Console.Write("\n");
        }

        static void Part2(List<Instructor> instructors, List<Student> students, List<Cohort> cohorts, List<Exercise> exercises)
        {
            Console.WriteLine("Part 2 of practice.\n");

            // 2-1. List exercises for the JavaScript language by using the Where() LINQ method
            Console.WriteLine("List of exercises for the JavaScript language:");

            List<Exercise> language = exercises.Where(exercise => exercise.Language == "JavaScript").ToList();
            foreach (Exercise exercise in language)
            {
                Console.WriteLine($"{exercise.Name} {exercise.Language}");
            }
            Console.Write("\n");

            // 2-2.List students in a particular cohort by using the Where() LINQ method
            Console.WriteLine("List of students in a particular cohort:");

            foreach (Cohort cohort in cohorts)
            {
                Console.WriteLine($"For {cohort.Name}:");
                foreach (Student student in students.Where(person => person.Cohort == cohort.Name).ToList())
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} ({student.Cohort})");
                }
            }
            Console.Write("\n");

            // 2-3. List instructors in a particular cohort by using the Where() LINQ method
            Console.WriteLine("List of instructors in a particular cohort:");

            foreach (Cohort cohort in cohorts)
            {
                Console.WriteLine($"For {cohort.Name}:");
                foreach (Instructor instructor in instructors.Where(person => person.Cohort == cohort.Name).ToList())
                {
                    Console.WriteLine($"{instructor.FirstName} {instructor.LastName} ({instructor.Cohort})");
                }
            }
            Console.Write("\n");

            // 2-4. Sort the students by their last name
            Console.WriteLine("List of students sorted by their last name:");

            foreach (Student student in students.OrderBy(person => person.LastName).ToList())
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName} ({student.Cohort})");
            }
            Console.Write("\n");

            // 2-5. Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Console.WriteLine("List of students haven't any exercises:");

            foreach (Student student in students.Where(person => person.Exercises.Count == 0).ToList())
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName} ({student.Cohort}) has {student.Exercises.Count} exercises.");
            }
            Console.Write("\n");

            // 2-6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            Console.WriteLine("Students, who are working on the most exercises:");

            int maxNumberOfExercises = students.OrderByDescending(person => person.Exercises.Count).First().Exercises.Count;
            foreach (Student student in students.Where(person => person.Exercises.Count == maxNumberOfExercises).ToList())
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName} ({student.Cohort}) has {student.Exercises.Count} exercises.");
            }
            Console.Write("\n");

            // 2-7. How many students in each cohort?
        }
    }
}