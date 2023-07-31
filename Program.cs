using AP_Classes;
using System;
using System.Collections.Generic;

namespace AP_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;

            // Print information about class 1A
            Console.WriteLine("Class Name: " + class1A.Name);
            Console.WriteLine("Class Teacher: " + class1A.ClassTeacher.Name);
            Console.WriteLine("Class Teacher's Contact Address: " + class1A.ClassTeacher.ContactAddress);
            Console.WriteLine("Class Teacher's Date of Joining: " + class1A.ClassTeacher.DateOfJoining);

            Console.WriteLine("\nStudents in Class 1A:");
            foreach (Student student in class1A.Students)
            {
                Console.WriteLine("- " + student.Name);
            }

            Console.WriteLine("\nSubjects taught in Class 1A:");
            foreach (Subject subject in class1A.Subjects)
            {
                Console.WriteLine("- " + subject.Name + " (" + subject.ShortName + ")");
            }
        }
    }
}
