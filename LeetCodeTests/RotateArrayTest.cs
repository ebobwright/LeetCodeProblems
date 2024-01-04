using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems;

namespace LeetCodeTests
{
    [TestClass]
    public class RotateArrayTest
    {
        [TestMethod()]
        public void LeetCode_RotateArray_Test1()
        {
            //Arrange
            var target = new RotateArraySolution();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            //Act
            target.Rotate(nums, k);

            //Assert                        
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 1, 2, 3, 4 }, nums);
        }

        [TestMethod()]
        public void LeetCode_RotateArray_Test2()
        {
            //Arrange
            var target = new RotateArraySolution();
            int[] nums = { -1, -100, 3, 99 };
            int k = 2;

            //Act
            target.Rotate(nums, k);

            //Assert                        
            CollectionAssert.AreEqual(new int[] { 3, 99, -1, -100 }, nums);
        }

        [TestMethod()]
        public void LeetCode_RotateArray_Test3()
        {
            //Arrange
            var target = new RotateArraySolution();
            int[] nums = { 1, 2 };
            int k = 3;

            //Act
            target.Rotate(nums, k);

            //Assert                        
            CollectionAssert.AreEqual(new int[] { 2,1 }, nums);
        }
    }
}
