using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<StudentData> students = new List<StudentData>()
        {
            new StudentData("Alice", new List<int> { 90, 80, 70 }),
            new StudentData("Bob", new List<int> { 60, 75, 85 }),
            new StudentData("Charlie", new List<int> { 100, 90, 95 }),
            new StudentData("Daisy", new List<int> { 50, 40, 30 }),
        };

        PrintStudentReport(students);
    }

    static void PrintStudentReport(List<StudentData> students)
    {
        Console.WriteLine("Avg: " + CalculateClassAverage(students));
        Console.WriteLine("Top: " + GetTopStudent(students).Name);
        Console.WriteLine("Pass: " + CountPassingStudents(students));

        Console.WriteLine("\nInfo:");
        foreach (var student in students)
        {
            Console.WriteLine(student.Name + " -> " + student.CalculateAverage() + " (" + GetLetterGrade(student.CalculateAverage()) + ")");
        }
    }

    static double CalculateClassAverage(List<StudentData> students)
    {
        double total = 0;

        foreach (var student in students)
        {
            total += student.CalculateAverage();
        }

        return total / students.Count;
    }

    static StudentData GetTopStudent(List<StudentData> students)
    {
        StudentData topStudent = students[0];

        foreach (var student in students)
        {
            if (student.CalculateAverage() > topStudent.CalculateAverage())
            {
                topStudent = student;
            }
        }

        return topStudent;
    }

    static int CountPassingStudents(List<StudentData> students)
    {
        int count = 0;

        foreach (var student in students)
        {
            if (IsPassing(student.CalculateAverage()))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsPassing(double grade)
    {
        if (grade >= 60)
        {
            return true;
        }

        return false;
    }

    static string GetLetterGrade(double grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
}