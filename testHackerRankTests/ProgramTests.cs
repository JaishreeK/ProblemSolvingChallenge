﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using testHackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHackerRank.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        //[TestMethod()]
        //public void gradingStudentsTest()
        //{
        //    Program.gradingStudents(new int[] { 73, 67, 38, 33 });
        //    //Assert.AreEqual(new int[]{75,67,40,33},Program.gradingStudents(new int[] { 73, 67, 38, 33 }));
        //}


        [TestMethod()]
        public void diagonalDifferenceTest()
        {
            Program.diagonalDifference(new int[][] {11, 2, 4, 4, 5, 6, 10, 8, -12 });
            //Assert.AreEqual(new int[]{75,67,40,33},Program.gradingStudents(new int[] { 73, 67, 38, 33 }));
        }

        [TestMethod()]
        public void countApplesAndOrangesTest()
        {
            Tuple<int, int> retCount = new Tuple<int, int>(0, 0);
            retCount = Program.countApplesAndOranges(7, 11, 5, 15, 3, 2, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
            //Assert.Fail();
            Assert.IsTrue(retCount.Item1 == 1);
            Assert.IsTrue(retCount.Item2 == 1);
        }

        [TestMethod()]
        public void kangarooTest()
        {
            //Assert.Fail();
            string ret = Program.kangaroo(4523, 8092, 9419, 8076);
            Assert.AreEqual(ret, "Yes");
        }
    }
}