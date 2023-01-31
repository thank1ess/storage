public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums = new int[nums1.Length + nums2.Length];
        nums1.CopyTo(nums, 0);
        nums2.CopyTo(nums, nums1.Length);
        Array.Sort(nums);
        
        if(nums.Length % 2 == 0)
            return (double) (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2;
        
        return (double) nums[nums.Length / 2];
    }
}