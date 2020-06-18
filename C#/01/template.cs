using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //入力
        var input = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToList();
        var N = input[0];
        var M = input[1];
        var list = new List<string[]>();
        for (var i = 0; i < M; i++)
        {
            list.Add(Console.ReadLine().Split(' ').Select(k => k).ToArray());
        }

        //
        for (var i = 1; i <= 999; i++)
        {
            var str = i.ToString();
            int c = 0;
            string[] arr = new string[str.Count()];
            foreach (char item in str)
            {
                arr[c] = item.ToString();
                c++;
            }
            var num = "";
            var flag = false;
            for (var j = 0; j < M; j++)
            {
                flag = false;
                try
                {
                    num = arr[int.Parse(list[j][0]) - 1];
                }
                catch
                {
                    break;
                }
                if (num != list[j][1])
                {
                    break;
                }
                flag = true;
            }
            if (flag)
            {
                Console.WriteLine(i);
                return;
            }

        }

        //出力
        Console.WriteLine("-1");
        // 文字列の入力
        //string s = Console.ReadLine();

        // 整数の入力
        //long n = long.Parse(Console.ReadLine());
        /*
        // 文字列配列の入力
        string[] inputStrArray = Console.ReadLine().Split(' ');

        // 整数配列の入力
        long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
		*/
        //処理
        //syori

        //出力

    }
}