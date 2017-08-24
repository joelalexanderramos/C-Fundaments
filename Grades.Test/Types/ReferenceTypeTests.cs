using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    class ReferenceTypeTests
    {
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
            
            b1 = new GradeBook();
            b1.Name = "Joel Ramos";
            Assert.AreEqual(b1.Name, b2.Name);

        }
    }
}
