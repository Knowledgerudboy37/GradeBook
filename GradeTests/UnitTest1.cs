using GradeBook;
using System;
using Xunit;

namespace GradeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            GradeClass objgradeClass = new GradeClass("");
            //act (
            objgradeClass.AddGrade(89.1);
            objgradeClass.AddGrade(90.5);
            objgradeClass.AddGrade(77.3);

            var result = objgradeClass.GetStatistics();
            //assert
            Assert.Equal(85.6, result.avg,1);
        }
    }
}
