using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    

    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Create an array of students
            Student[] students = new Student[]
            {
            new Student { Name = "Tina", Score = 99 },
            new Student { Name = "Gracy", Score = 88 },
            new Student { Name = "Chandler", Score = 66 },
            new Student { Name = "Ellen", Score = 44 },
            new Student { Name = "George", Score = 77 }
            };

            Console.WriteLine("Original List of Students:");
            PrintStudents(students);

            // Sort the array using Bubble Sort
            BubbleSort(students);

            Console.WriteLine("\nSorted List of Students (by Score):");
            PrintStudents(students);
        }

        static void BubbleSort(Student[] students)
        {
            int n = students.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Score > students[j + 1].Score)
                    {
                        // Swap the students if they are in the wrong order
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Score}");
            }
        }
    }

}
