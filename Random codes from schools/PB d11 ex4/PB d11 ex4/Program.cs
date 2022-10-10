using System;

namespace PB_d11_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int jurymembers = int.Parse(Console.ReadLine());
            double totalGradeForCourse = 0;
            int lecturesCounter = 0;
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "Finish")
                {
                    break;
                }
                string lecturetitle = command;
                lecturesCounter++;

                double totalGradeForLecture = 0;
                for (int i = 1; i <= jurymembers; i++)
                {
                    double gradeForLecture = double.Parse(Console.ReadLine());
                    totalGradeForLecture += gradeForLecture;
                }
                double averageForLecture = totalGradeForLecture / jurymembers;
                Console.WriteLine($"{lecturetitle} - {averageForLecture:f2}.");
                totalGradeForCourse += averageForLecture;
            }
            double averageForCourse = totalGradeForCourse / lecturesCounter;
            Console.WriteLine($"Student's final assessment is {averageForCourse:f2}.");
        }
    }
}
