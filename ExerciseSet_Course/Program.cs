using ExerciseSet_Course.Entities;
using System;
using System.Collections.Generic;

namespace ExerciseSet_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> studentsA = new HashSet<Students>();
            HashSet<Students> studentsB = new HashSet<Students>();
            HashSet<Students> studentsC = new HashSet<Students>();
 

            Console.Write("how many students for course A? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsA.Add(new Students(id));
            }

            Console.Write("how many students for course B? ");
            int numberB = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberB; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsB.Add(new Students(id));
            }

            Console.Write("how many students for course C? ");
            int numberC = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberC; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsC.Add(new Students(id));
            }
            HashSet<Students> all = new HashSet<Students>(studentsA);

            all.UnionWith(studentsB);
            all.UnionWith(studentsC);

            Console.WriteLine($"Total of students: {all.Count}");


            Console.ReadKey();
        }
    }
}
