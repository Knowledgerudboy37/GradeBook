using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           GradeClass ObjGradeBook = new GradeClass("knowledge");

            //alowing user to input values
            Console.WriteLine("how many student do u want to enter");
            int NumberOfStud = int.Parse(Console.ReadLine());
            double score = 0.0;
            for(int i=0; i < NumberOfStud; i++)
            {
                Console.WriteLine($"enter Score for Student{i+1}:");
                score = double.Parse(Console.ReadLine());
                ObjGradeBook.AddGrade(score);
            }
            //ObjGradeBook.AddGrade(55.26);
            //ObjGradeBook.AddGrade(87.27);
            //ObjGradeBook.AddGrade(66.00);
            //ObjGradeBook.AddGrade(44.25);
            //ObjGradeBook.AddGrade(55.26);
           var result=ObjGradeBook.GetStatistics();
          
            Console.WriteLine($"The average is:{result.avg:N2}");
            Console.WriteLine($"Congrats your grade is:{result.LetterGrade}");
            Console.WriteLine($"The highest is:{result.highestGrade}");
            Console.WriteLine($"The lowest is:{result.lowestGrade}");
            
        }
    }
}
