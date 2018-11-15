using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesGradeF()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(50);
            book.AddGrade(40);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("F", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesGradeD()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(61);
            book.AddGrade(64);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("D", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesGradeC()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(70);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("C", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesGradeB()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(80);
            book.AddGrade(81);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesGradeA()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(96);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("A", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }

    }
}
