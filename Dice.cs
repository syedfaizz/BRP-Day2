using System;
class program
{
    static int findWays(int N)
    {
        if (N == 0)
        {
            return 1;
        }

        int cnt = 0;

        for (int i = 1; i <= 6; i++)
        {
            if (N - i >= 0)
            {
                cnt = cnt + findWays(N - i);
            }
        }

        return cnt;
    }
    public static void Main()
    {
        int N = 4;

        Console.Write(findWays(N));
    }
}