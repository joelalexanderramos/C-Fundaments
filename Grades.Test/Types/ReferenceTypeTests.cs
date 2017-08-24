using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
            
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "joel";
            name = name.ToUpper();

            Assert.AreEqual("JOEL", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);           

        }

        private void IncrementNumber(ref int number)
        {
             number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            book2.Name = "A GradeBook 1";
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook 2", book1.Name);
        }

        private void GiveBookAName(GradeBook b2)
        {
            b2.Name = "A GradeBook 2";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "Scott";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCulture);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook b1 = new GradeBook();
            GradeBook b2 = b1;
            
            //b1 = new GradeBook();
            b1.Name = "Joel Ramos";
            Assert.AreEqual(b1.Name, b2.Name);

        }
    }
}
