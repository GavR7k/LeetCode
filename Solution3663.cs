public class Solution
{
    public int GetLeastFrequentDigit(int n)
    {

        string numValue = n.ToString();

        List<int> nums =  new List<int>(){ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (char value in numValue)
        {
            switch (value)
            {
                case '0':
                    nums[0] = nums[0] + 1;
                    break;
                case '1':
                    nums[1] = nums[1] + 1;
                    break;
                case '2':
                    nums[2] = nums[2] + 1;
                    break;
                case '3':
                    nums[3] = nums[3] + 1;
                    break;
                case '4':
                    nums[4] = nums[4] + 1;
                    break;
                case '5':
                    nums[5] = nums[5] + 1;
                    break;
                case '6':
                    nums[6] = nums[6] + 1;
                    break;
                case '7':
                    nums[7] = nums[7] + 1;
                    break;
                case '8':
                    nums[8] = nums[8] + 1;
                    break;
                case '9':
                    nums[9] = nums[9] + 1;
                    break;
            }

        }
       
        int min = nums.Min();

        List<int> result = new List<int>();
        
        for (int i = 0; i < nums.Count; i++)
        {
            if (min == nums[i])
            {
                result.Add(i);
            }
        }

        return result.Min();

    }
}