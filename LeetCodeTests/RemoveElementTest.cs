using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems;
using System.Linq;

namespace LeetCodeTests
{
    [TestClass]
    public class RemoveElementTest
    {
        [TestMethod()]
        public void LeetCode_RemoveElement_Test1()
        {
            //Arrange
            var target = new RemoveElementSolution();
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            
            //Act
            var k = target.RemoveElement(nums, val);

            //Assert            
            Assert.AreEqual(2, k);
            CollectionAssert.AreEqual(new int[] { 2, 2 }, nums.Skip(0).Take(k).ToArray());
        }

        [TestMethod()]
        public void LeetCode_RemoveElement_Test2()
        {
            //Arrange
            var target = new RemoveElementSolution();
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            //Act
            var k = target.RemoveElement(nums, val);

            //Assert            
            Assert.AreEqual(5, k);
            CollectionAssert.AreEqual(new int[] { 0, 0, 1, 3, 4 }, nums.Skip(0).Take(k).ToArray());
        }
    }
}
