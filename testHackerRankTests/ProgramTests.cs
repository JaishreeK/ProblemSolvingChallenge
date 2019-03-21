using Microsoft.VisualStudio.TestTools.UnitTesting;
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


        //[TestMethod()]
        //public void diagonalDifferenceTest()
        //{
        //    int Value = Program.diagonalDifference(new int[3,3] {
        //        { 11, 2, 4 },
        //        { 4, 5, 6 },
        //        { 10, 8, -12 }  });

        //}

        //[TestMethod()]
        //public void plusMinusTest()
        //{
        //    Program.plusMinus(new int[6] { -4, 3, -9, 0, 4, 1 });
        //}

        //[TestMethod()]
        //public void birthdayCakeCandlesTest()
        //{
        //    Program.birthdayCakeCandles(new int[4] { 3, 2, 1, 3 });
        //    //Assert.Fail();
        //}

        [TestMethod()]
        public void breakingRecordsTest()
        {
            Program.breakingRecords(new int[4] {12, 24, 10, 24});
            //Assert.Fail();
        }

        //[TestMethod()]
        //public void countApplesAndOrangesTest()
        //{
        //    Tuple<int, int> retCount = new Tuple<int, int>(0, 0);
        //    retCount = Program.countApplesAndOranges(7, 11, 5, 15, 3, 2, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
        //    //Assert.Fail();
        //    Assert.IsTrue(retCount.Item1 == 1);
        //    Assert.IsTrue(retCount.Item2 == 1);
        //}

        //[TestMethod()]
        //public void kangarooTest()
        //{
        //    //Assert.Fail();
        //    string ret = Program.kangaroo(4523, 8092, 9419, 8076);
        //    Assert.AreEqual(ret, "Yes");
        //}
    }
}