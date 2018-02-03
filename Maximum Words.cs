using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    static void Main(String[] args)
    {
        String s = Console.ReadLine();

        int cnt = solution(s);

        Console.WriteLine(cnt);
        Console.ReadKey();
    }

    public static int solution(string S)
    {
        int max = 0;
        //Split senytence iusing cnhatacers
        if (S.Trim().Length > 0)

        {
            char[] seperator = new char[] { '.', ',', '?', '!' };
            string[] sentencelst = S.Split(seperator);

            for (int i = 0; i < sentencelst.Length; i++)
            {
                if(sentencelst[i].Contains("  "))
                {
                    sentencelst[i] = sentencelst[i].Replace("  ", " ");
                }
                sentencelst[i] = sentencelst[i].Trim();

                int wrd = (sentencelst[i]).Split(' ').Length;
                if (max < wrd)
                {
                    max = wrd;
                }
            }
        }

        return max;
    }
}

