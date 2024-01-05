using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems;

namespace LeetCodeTests
{
    [TestClass]
    public class RotateArrayTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [DataRow(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        [DataRow(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
        public void LeetCode_RotateArray_DDT(int[] nums, int k, int[] exp)
        {
            //Arrange
            var target = new RotateArraySolution();
          
            //Act
            target.Rotate(nums, k);

            //Assert                        
            CollectionAssert.AreEqual(exp, nums);
        }
    }
}
