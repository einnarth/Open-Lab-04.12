using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            nums.ToList();
            var list = nums;
            var result = Enumerable.Range(0, 10).Except(nums);
            return result;
            
        }
        
    }
}
