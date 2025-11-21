public class Solution
{
	public int ReturnToBoundaryCount(int[] nums)
	{
		int counterOfBoundary = 0;
		int currentPosition = 0;

		foreach (int x in nums)
		{
			currentPosition += x;

			if (currentPosition == 0)
			{
				counterOfBoundary++;
			}
		}

		return counterOfBoundary;
	}