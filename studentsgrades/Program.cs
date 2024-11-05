using System;
using System.Collections.Generic;

namespace studentsgrades
{
    internal class Program
    {
        struct student
        {
            public string name;
            public Grade grade;
            public level Level;
            public double average;
        }

        struct Grade
        {
            public int English;
            public int Arabic;
            public int Math;
            public int Programming;
            public int Physics;
        }

        enum level
        {
            Freshman,
            Sophomore,
            Junior,
            Senior
        }

        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            student highStudent = new student();
            double highavg = 0;

            bool addStudent = true;
            while (addStudent)
            {
                student std = new student();
                Grade g = new Grade();
                int sum = 0; 

                
                Console.WriteLine("Enter your Information: \nName:");
                std.name = Console.ReadLine();

                Console.WriteLine("Level => ( Freshman , Sophomore , Junior , Senior ):");
                string inputLevel = Console.ReadLine();
                // make sure the value suitable for the enum compare
                if (Enum.TryParse(inputLevel, true, out level l) && Enum.IsDefined(typeof(level), l))
                {
                    std.Level = l;
                }
                else
                {
                    Console.WriteLine("Invalid Level.");
                    return;
                }

                Console.WriteLine("Enter your Grades:\nEnglish:");
                g.English = Convert.ToInt32(Console.ReadLine());
                sum += g.English;

                Console.WriteLine("Mathematics:");
                g.Math = Convert.ToInt32(Console.ReadLine());
                sum += g.Math;

                Console.WriteLine("Physics:");
                g.Physics = Convert.ToInt32(Console.ReadLine());
                sum += g.Physics;

                Console.WriteLine("Arabic:");
                g.Arabic = Convert.ToInt32(Console.ReadLine());
                sum += g.Arabic;

                Console.WriteLine("Programming:");
                g.Programming = Convert.ToInt32(Console.ReadLine());
                sum += g.Programming;

                std.grade = g;
                std.average = (double)sum / 5;  

                students.Add(std);

                Console.WriteLine("Enter another student (yes OR no)");
                addStudent = Console.ReadLine().ToLower().Trim() == "yes";
            }

            // Find and display the student with the highest average
            foreach (student student in students)
            {
                Console.WriteLine($"\nName: {student.name}");
                Console.WriteLine($"Level: {student.Level}");
                Console.WriteLine($"Average: {student.average}\n");

                if (highavg < student.average)
                {
                    highavg = student.average;
                    highStudent = student;
                }
            }

            Console.WriteLine($"The highest average student is:\nName: {highStudent.name}, Level: {highStudent.Level}, Average: {highStudent.average}");
        }
    }
}
