using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems;


namespace LeetCodeTests
{
    [TestClass]
    public class TrappingRainWaterTest
    {
        [TestMethod()]
        public void LeetCode_TrappingRainWater_Test1()
        {
            //Arrange
            var target = new TrappingRainWaterSolution();
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            

            //Act
            var ret = target.Trap(height);

            //Assert
            Assert.AreEqual(6, ret);
        }

        [TestMethod()]
        public void LeetCode_TrappingRainWater_Test2()
        {
            //Arrange
            var target = new TrappingRainWaterSolution();
            int[] height = { 4, 2, 0, 3, 2, 5 };


            //Act
            var ret = target.Trap(height);

            //Assert
            Assert.AreEqual(9, ret);
        }
    }
}
