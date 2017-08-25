using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrades(float grade);

        GradeStatistics ComputeStatistics();

        void WriteGrades(TextWriter destionation);

        string Name { get; set; }
    }
}