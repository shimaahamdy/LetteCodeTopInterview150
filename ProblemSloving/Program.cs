
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


int RemoveElement(int[] nums, int val)
{
    List<int> expectednums = new();
    int k = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            k++;
            expectednums.Add(nums[i]);
        }

    }

    for (int i = 0; i < expectednums.Count; i++)
    {
        nums[i] = expectednums[i];
    }
    return k;

}

int RemoveDuplicates(int[] nums)
{
    int dublicateIndex = 0;
    int originalIndex = 0;
    int k = 0;

    while (dublicateIndex + 1 <= nums.Length)
    {
        if (dublicateIndex + 1 == nums.Length)
            nums[originalIndex] = nums[dublicateIndex];
        else if (nums[dublicateIndex] != nums[dublicateIndex + 1])
        {
            nums[originalIndex] = nums[dublicateIndex];
            originalIndex++;
        }
        dublicateIndex++;
    }
    k = originalIndex + 1;
    return k;
}




