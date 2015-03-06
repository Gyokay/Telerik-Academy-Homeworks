using System;

class Program
{
    static void Main()
    {
        string asd = "12 32 2 32";
        string[] txt = asd.Split(' ');
        int sum = 0;
        for (int i = 0; i < txt.Length; i++)
        {
          sum += int.Parse(txt[i]);
        }

        Console.WriteLine(sum);
    }
}

