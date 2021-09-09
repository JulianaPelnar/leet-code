namespace LeetCode.Exercises
{
    /*
     Exercise:
      Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

      You may assume that each input would have exactly one solution, and you may not use the same element twice.

      You can return the answer in any order.

     Result:
      Runtime: 384 ms, faster than 32.35% of C# online submissions for Two Sum.
      Memory Usage: 32.5 MB, less than 66.11% of C# online submissions for Two Sum.
     */
    public class TwoSum
    {
        public TwoSum() { }
        public int[] Solution(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Count(); i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    result[1] = i;
                    result[0] = dic.GetValueOrDefault(target - nums[i]);
                    return result;
                }
                dic.TryAdd(nums[i], i);
            }
            return result;
        }
    }
}
