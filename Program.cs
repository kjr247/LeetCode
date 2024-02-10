public class Solution
{
    // simple first attempt solution
    // time: O(n sqrd) space: O(n)
    public int[] TwoSum(int[] nums, int target)
    {
        int[] results = [];
        int idx1 = 0;
        int idx2 = 1;
        // what if there are numbers in the array that are greater than the target, ignore them
        // start by sorting them, then truncate anything equal to or greater than the target
        // while sorting can be asdf of N time complexity. We can use something more efficient, like storage when the values are low
        foreach (int num in nums)
        {
            foreach (int num2 in nums)
            {
                if (nums[idx2] == target - nums[idx1])
                {
                    results = [idx1, idx2];
                    return results;
                }
                else if (idx2 >= nums.Length)
                {
                    return [];
                }
                idx2++;

            }
            idx1++;
        }
        Console.WriteLine("target: ", target);
        Console.WriteLine("results: ", results);
        return results;
    }

    // a hashmap can get rid of the case of duplicates
    // and you know which number you are looking for based on the information you have in each try
    // you have an entry and the target, so just attempt to pick out the difference as a key
    // time: O(n) space: O(n)
    // public int[] TwoSum(int[] nums, int target) {
    //     int[] results = [];
    //     int idx = 0;
    //      Hashtable hashtable = new Hashtable();
    //     foreach(int num in nums)
    //     {
    //         var val = target - num;
    //         hashtable.Add(num, idx);
    //         var idx2 = nums.IndexOf(nums, val);
    //         if (idx2 > -1) {
    //             results = [idx, idx2];
    //             return results;
    //         }
    //         idx++;
    //     }
    //     return results;
    // }
}