using System;

namespace массивы
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[20] { 54, -21, 18, -19, 25, 60, 63, -49, -31, 75, 49, -66, 58, -2, -43, -77, 53, 32, 78, 1 };

            int min = int.MaxValue;
            for (int i = 0, i < nums.Length; i++) 
            {
                int i = 0;
                if (nums[i] < min)
                    min = nums[i];
            } 

            int max = int.MinValue;
            for (int i = 0, i < nums.Length; i++) 
            {
                int i = 0;
                if (nums[i] > max)
                    max = nums[i];
            } Console.WriteLine(max);

            max = int.MinValue;
            int max_pos = int.MinValue;
            for (int i = 0, i <nums.Length; i++)
            {
                if (nums[i] > max) { max = nums[i]; max_pos = 1; }
            } 


            min = int.MaxValue;
            int min_pos = int.MaxValue;
            for (int i = 0, i < nums.Length; i++)
            {
                if (nums[i] < min) { min = nums[i]; min_pos = 1; }
            } 

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(max_pos);
            Console.WriteLine(min_pos);
            //я не доделала еще
            //и не разобралось с рандомом 
        }
    }
}
