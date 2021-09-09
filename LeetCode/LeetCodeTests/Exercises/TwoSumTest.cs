using LeetCode.Exercises;
using Xunit;

namespace LeetCodeTests.Exercises
{
    public class TwoSumTest
    {
        public TwoSum twoSum = new TwoSum();

        [Fact]
        public void Test1()
        {
            int[] nums = { 2, 7, 11, 15 };
            var target = 9;
            int[] response = twoSum.Solution(nums, target);
            int[] expectedResponse = new int[] { 0, 1 };
            Assert.Equal(response, expectedResponse);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 3, 2, 4 };
            var target = 6;
            int[] response = twoSum.Solution(nums, target);
            int[] expectedResponse = new int[] { 1, 2 };
            Assert.Equal(response, expectedResponse);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = { 3, 3 };
            var target = 6;
            int[] response = twoSum.Solution(nums, target);
            int[] expectedResponse = new int[] { 0, 1 };
            Assert.Equal(response, expectedResponse);
        }

        [Fact]
        public void Test4()
        {
            int[] nums = { 3, 2, 3 };
            var target = 6;
            int[] response = twoSum.Solution(nums, target);
            int[] expectedResponse = new int[] { 0, 2 };
            Assert.Equal(response, expectedResponse);
        }

        [Fact]
        public void Test5()
        {
            int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var target = 11;
            int[] response = twoSum.Solution(nums, target);
            int[] expectedResponse = new int[] { 5, 11 };
            Assert.Equal(response, expectedResponse);
        }
    }
}
