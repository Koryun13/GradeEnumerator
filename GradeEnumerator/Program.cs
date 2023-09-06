using System;

namespace GradeEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Names = {
            "Alice",
            "Bob",
            "Charlie",
            "David",
            "Ella",
            "Frank",
            "Grace",
            "Henry",
            "Ivy",
            "Jack",
            "Kate",
            "Liam",
            "Mia",
            "Noah",
            "Olivia",
            "Paul",
            "Quinn",
            "Ryan",
            "Sophia",
            "Tyler"
        };

            int[] Grades = GenerateRandomIntArray(20, 0, 20);

            List<Student> students = InitStudents(Names, Grades);

            ClassRoom classRoom = new ClassRoom(students);

            foreach (Student student in classRoom) 
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Grade);
            }

        }

        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] randomArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            return randomArray;
        }

        static List<Student> InitStudents(string[] names, int[] grades)
        {
            List<Student> studnets = new List<Student>();

            for(int i = 0; i < names.Length; i++)
            {
                Student student = new Student
                {
                    Name = names[i],
                    Grade = grades[i]
                };

                studnets.Add(student);

            }

            return studnets;
        }
    }
}
