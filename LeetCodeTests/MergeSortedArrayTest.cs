using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems;

namespace LeetCodeTests
{
    [TestClass]
    public class MergeSortedArrayTest
    {
        [TestMethod()]
        public void LeetCode_MergeSortedArray_Test1()
        {
            //Arrange
            var target = new MergeSortedArraySolution();
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            //Act
            target.Merge(nums1, m, nums2, n);

            //Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
        }

    }
}