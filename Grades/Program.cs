using System;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            NewMethod(book);
        }

        private static void NewMethod(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }

            book.WriteGrades(Console.Out);
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");

        }

        // DELEGATES 
        // book.NameChanged += OnNameChanged;

        // 1) HOW TO USE PARAMS
        //WriteResult("Lowest", stats.LowestGrade, 2, 3, 4);
        //static void WriteResult(string description, params float[] result)

        // 2)
        //Console.WriteLine(description + ": " + result);
        //Console.WriteLine("{0}: {1}", description, result);

        // 3)
        //static void WriteResult(string description, int result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}

        // 4)
        //static void OnNameChanged(object sender, NameChangedEventArgs args)
        // {
        //     Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        // }
    }
}
