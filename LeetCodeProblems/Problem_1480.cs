/* 
Problem 1480:
Running Sum of 1d Array 

Given an array nums. 
We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums. 

Example 1:
Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4]. 

Constraints:
1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6
*/

using System.Data;
using System.Runtime.InteropServices;

namespace LeetCodeProblems
{
    public class Problem_1480
    {
        public void Run()
        {
            Console.WriteLine("--- Running Sum of 1D array ---");
            Console.WriteLine("Input Array: [1, 2, 3, 4, 5]");

            int[] input = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Output: " + string.Join(",", RunningSum(input)));

            Console.ReadLine();
        }

        private int[] RunningSum(int[] nums)
        {
            int[] result = nums;

            result[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] + nums[i];
            }

            return result;
        }
    }
}