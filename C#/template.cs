using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);
        // 文字列の入力
        string s = Console.ReadLine();

        // 整数の入力
        long n = long.Parse(Console.ReadLine());

        // 文字列配列の入力
        string[] inputStrArray = Console.ReadLine().Split(' ');

        // 整数配列の入力
        long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

        //処理
        //syori

        //出力
        Console.WriteLine("hle");
        Console.Out.Flush();
    }
}