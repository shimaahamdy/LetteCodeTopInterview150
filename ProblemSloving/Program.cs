
// 88 - merged sorted array 
void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int Pm = 0, Pn = 0, pnums = 0;
    int[] nums = new int[m + n];
    while (pnums <= m + n)
    {
        if ((Pm < m && Pn < n && nums1[Pm].CompareTo(nums2[Pn]) <= 0) || (Pm < m && Pn >= n))
        {
            nums[pnums] = nums1[Pm];   
            Pm++;
        }
        else if ((Pm < m && Pn < n && nums1[Pm].CompareTo(nums2[Pn]) > 0) || (Pn < n && Pm >= m))
        {
            nums[pnums] = nums2[Pn];
            Pn++;
        }

        pnums++;

    }
    int i = 0;
    foreach(int item in nums)
    {
        nums1[i++] = item;
    }


}





