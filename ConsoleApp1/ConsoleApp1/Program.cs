
using System;

class Program
{
    static void Main()
    {
        Console.Write("Cümləni daxil et: ");
        string cumle = Console.ReadLine();

        string[] sozler = cumle.Split(' ');
        string enBoyukSoz = "";
        int enBoyukUzunluq = 0;

        for (int i = 0; i < sozler.Length; i++)
        {
            if (sozler[i].Length > enBoyukUzunluq)
            {
                enBoyukUzunluq = sozler[i].Length;
                enBoyukSoz = sozler[i];
            }
        }

        Console.WriteLine("Ən uzun söz:"+ enBoyukSoz);
        Console.WriteLine("Uzunluğu:" + enBoyukUzunluq);
    }
}