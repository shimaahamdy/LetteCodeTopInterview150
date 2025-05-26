
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
    foreach (int item in nums)
    {
        nums1[i++] = item;
    }


}


//https://leetcode.com/problems/remove-element/
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



//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
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


int RemoveDuplicatesV2(int[] nums)
{

    int orignialIndex = 0, dublicationPointer = 0, dublications = 1;
    while (dublicationPointer < nums.Length)
    {
        //last cell
        if (dublicationPointer + 1 == nums.Length)
            checkinkDublications(nums, ref dublications, ref orignialIndex, dublicationPointer);

        //another dublication happend
        else if (nums[dublicationPointer] == nums[dublicationPointer + 1])
            dublications++;
        else checkinkDublications(nums, ref dublications, ref orignialIndex, dublicationPointer);

        dublicationPointer++;
    }

    return orignialIndex;
}

void checkinkDublications(int[] nums, ref int dublications, ref int orignialIndex, int dublicatioPointer)
{
    if (dublications >= 2)
    {
        nums[orignialIndex] = nums[orignialIndex + 1] = nums[dublicatioPointer];
        orignialIndex += 2;
    }
    else
    {
        nums[orignialIndex] = nums[dublicatioPointer];
        orignialIndex += 1;
    }
    dublications = 1;

}

int MajorityElement(int[] nums)
{

    Array.Sort(nums);

    return nums[nums.Length / 2];
}

void Rotate(int[] nums, int k)
{
    int[] Rotatednums = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        Rotatednums[(i + k) % nums.Length] = nums[i];
    }
    Array.Copy(Rotatednums, nums, nums.Length);
}

//O(1) space solution
void RotateV2(int[] nums, int k)
{
    k %= nums.Length;
    Array.Reverse(nums);
    Array.Reverse(nums, 0, k);
    Array.Reverse(nums, k, nums.Length - k);
}

int MaxProfit(int[] prices)
{
    int minPoint = 0;
    int maxPoint = 1;

    int maxProfit = 0;
    while (maxPoint < prices.Length)
    {
        if (prices[maxPoint] < prices[minPoint])
            minPoint = maxPoint;
        else maxProfit = Math.Max(maxProfit, prices[maxPoint] - prices[minPoint]);
        maxPoint++;
    }
    return maxProfit;

}

int MaxSubArray(int[] nums)
{
    int sum = nums[0], max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        sum = Math.Max(sum + nums[i], nums[i]);
        max = Math.Max(sum, max);
    }
    return max;

}

int MaxProfitV2(int[] prices)
{

    int maxProfit = 0;
    for (int i = 0, j = 1; j < prices.Length; ++i, ++j)
    {
        if (prices[j] - prices[i] > 0)
            maxProfit += prices[j] - prices[i];
    }
    return maxProfit;

}




