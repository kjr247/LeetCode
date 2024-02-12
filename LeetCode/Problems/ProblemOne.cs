using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ProblemOne
    {
        // simple first attempt
        // time: O(nsqrd) space: O(1)
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    int[] results = [];
        //    for (int i = 0; i < nums.Length-1; i++)
        //    {
        //        var num1 = nums[i];
        //        for (int idx2 = 0; idx2 <= nums.Length-1; idx2++)
        //        {
        //            var num2 = nums[idx2];
        //            if (i == idx2) { continue; }
        //            if (num1 == target - num2)
        //            {
        //                results = [i, idx2];
        //                return results;
        //            }
        //        }
        //    }
        //    return results;
        //}

        // what if there are numbers in the array that are greater than the target, ignore them
        // start by sorting them, then truncate anything equal to or greater than the target
        // while sorting can be asdf of N time complexity. We can use something more efficient, like storage when the values are low
        // a hashmap can get rid of the case of duplicates
        // and you know which number you are looking for based on the information you have in each try
        // you have an entry and the target, so just attempt to pick out the difference as a key
        // time: O(n) space: O(n)
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] results = [];
            int idx = 0;
            Hashtable hashtable = new Hashtable();

            foreach (int num in nums)
            {
                
                var val = target - num;
                // check to see if we've seen that value before
                if (hashtable.Contains(val))
                {
                    if (idx == (int)hashtable[val]) { continue; } // skip if the same index, that doesn't count
                    return [(int)hashtable[val], idx];
                }
                // if not then throw our num in the map
                hashtable.Add(num, idx);
                idx++;
            }
            return results;
        }
    }
}
