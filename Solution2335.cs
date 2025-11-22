public class Solution
{
    public int FillCups(int[] amount)
    {
        int counterSeconds = 0;

        List<int> list = new List<int>();

        list.Add(amount[0]);
        list.Add(amount[1]);
        list.Add(amount[2]);
        list.Sort();

      

        bool pass = true;

        while (pass)
        {

            if (list[0] == 0 && list[1] == 0 && list[2] == 0)
            {
                return counterSeconds;
            }

            if (list[2] > 0 && list[1] > 0)
            {
                counterSeconds++;
                list[2] = list[2] - 1;
                list[1] = list[1] - 1;
            }
            else
            {
                counterSeconds++;
                list[2] = list[2] - 1;

                if (list[2] == 0)
                    pass = false;
            }

          
          
            list.Sort();
        }
        return counterSeconds;

    }
}