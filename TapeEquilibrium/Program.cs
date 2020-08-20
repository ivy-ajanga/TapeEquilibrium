using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 1, 2, 4, 3 };
        Console.WriteLine(solution(arr));
    }
    public static int solution(int[] arr)
    {
        //if arraylength is 2 return the absolute diff of two elements
        //loop through the array
        //find abs diff head- tail
        //head is sum of all arrays tail is subtr of all arrays each step
        //compare abs diff with min diff
        if (arr.Length == 2) return Math.Abs(arr[0] - arr[1]);
        else
        {
            int head = arr[0];
            int tail = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                tail += arr[i];
            }
            int minimumdiff = Math.Abs(head - tail);
            for (int i = 1; i < arr.Length; i++)
            {
                head += arr[i];
                tail -= arr[i];
                if (Math.Abs(head - tail) < minimumdiff)
                {
                    minimumdiff = Math.Abs(head - tail);
                }
            }
            return minimumdiff;
        }

    }
}