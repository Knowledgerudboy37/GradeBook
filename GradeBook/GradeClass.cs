using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class GradeClass
    {
        public List<double> grades;
        public string name;
        public GradeClass() {

            grades = null;

        }
        public GradeClass(string name)
        {
            this.name = name;
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            } else
            {
                Console.WriteLine("invalid score!!! please enter score between 1-100");
            }

        }
        
        public Statistics GetStatistics()
            {
                var result = new Statistics();
                result.highestGrade = Double.MinValue;
                result.lowestGrade = Double.MaxValue;
                result.avg = 0.0;


                foreach (var grade in grades)
                {
                    result.avg += grade;
                    result.highestGrade = Math.Max(grade, result.highestGrade);
                    result.lowestGrade = Math.Min(grade, result.lowestGrade);
                }
                result.avg /= grades.Count;
            switch ((result.avg)
)
            {
                case var res when result.avg >= 90.0:
                    result.LetterGrade = 'A';
                    break;
                case var res when result.avg >= 80.0:
                    result.LetterGrade = 'B';
                    break;
                case var res when result.avg >= 70.0:
                    result.LetterGrade = 'C';
                    break;
                case var res when result.avg >= 60.0:
                    result.LetterGrade = 'D';
                    break;
                case var res when result.avg < 50.0:
                    result.LetterGrade = 'F';
                    break;
                default:
                    break;
            }

            return result;
            }
        
    }
}