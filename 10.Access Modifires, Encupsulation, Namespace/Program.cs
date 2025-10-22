// using System;
// class Program
// {
//     static void Main()
//     {
//         string input = "I am Backend DEVELOPER I LEARN C#";
//         char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
//         Console.WriteLine("Sait hərflər:");
//         foreach (var ch in input)
//         {
//             if(Array.Exists(vowels, v==ch))
//             Console.Write(v + " ");
//         }
//     }
// }
  //task2
// using System;

// class Program
// {
//     static void Main()
//     {
//         string input = "I am Backend DEVELOPER I LEARN C#";
//         string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//         Console.WriteLine("Sözlərin sayı: " + words.Length);
//     }
// }

//task3
// using System;
// class Program
// {
//     static void Main()
//     {
//         string input = "I am Backend DEVELOPER I LEARN C#";
//         string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//         string longestWord = words.OrderByDescending(w => w.Length).First();

//         Console.WriteLine("Ən uzun söz: " + longestWord);
//     }
// }
//task4
// using System;
// class Program
// {
//     static void Main()
//     {
//         string input = "I am Backend DEVELOPER I LEARN C#";
//         string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//         string longestWord = words.OrderByDescending(w => w.Length).First();

//         Console.WriteLine("Ən uzun söz: " + longestWord);
//     }
// }
//task5
using System;
class Program
{
    static void Main()
    {
        string input = "I am Backend DEVELOPER I LEARN C#";
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("2-dən artıq böyük hərfi olan sözlər:");
        foreach (var word in words)
        {
            int upperCount = word.Count(char.IsUpper);
            if (upperCount > 2)
            {
                Console.WriteLine(word);
            }
        }
    }
}


    