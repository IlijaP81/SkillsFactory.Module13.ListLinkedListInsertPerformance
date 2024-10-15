using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = ReadFile();
            TimeByToList(words);
            TimeToListByFor(words);
            TimeToListByForeach(words);
            TimeToLinkedListByFor(words);
            TimeToLinkedListByForeach(words);
        }

        /// <summary>
        /// Reads file content from path to string
        /// </summary>
        private static string[] ReadFile()
        {
            string text = File.ReadAllText("C:\\CSharp\\SF\\Module13\\ListLinkedListInsertPerformance\\Text1.txt");
            // keep delimeters to separate words
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            // separate string from file by delimeters
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        /// <summary>
        /// Estimates time to write string array by using of ToList() method
        /// </summary>
        /// <param name="words"></param>

        private static void TimeByToList(string[] words)
        {
            List<string> list = new List<string>();
            var stopWatch = Stopwatch.StartNew();
            list = words.ToList();
            Console.WriteLine($"Время, затраченное для вставки в List с использованием метода ToList: " +
                              $"{stopWatch.Elapsed.Milliseconds} мс");
        }

        /// <summary>
        /// Estimates time to write string array to List by using of For loop
        /// </summary>
        /// <param name="words"></param>
        private static void TimeToListByFor(string[] words)
        {
            List<string> list = new List<string>();
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i]);
            }
            Console.WriteLine($"Время, затраченное для вставки в List с использованием цикла For: " +
                              $"{stopWatch.Elapsed.Milliseconds} мс");
        }

        /// <summary>
        /// Estimates time to write string array to List by using of Foreach loop
        /// </summary>
        /// <param name="words"></param>
        private static void TimeToListByForeach(string[] words)
        {
            List<string> list = new List<string>();
            Stopwatch stopWatch = Stopwatch.StartNew();
            foreach (string w in words)
            {
                list.Add(w);
            }
            Console.WriteLine($"Время, затраченное для вставки в List с использованием цикла Foreach: " +
                              $"{stopWatch.Elapsed.Milliseconds} мс");
        }

        /// <summary>
        /// Estimates time to write string array to LinkedList by using of For loop
        /// </summary>
        /// <param name="words"></param>
        private static void TimeToLinkedListByFor(string[] words)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < words.Length; i++)
            {
                linkedList.AddFirst(words[i]);
            }
            Console.WriteLine($"Время, затраченное для вставки в LinkedList с использованием цикла For: " +
                              $"{stopWatch.Elapsed.Milliseconds} мс");
        }

        /// <summary>
        /// Estimates time to write string array to LinkedList by using of Foreach loop
        /// </summary>
        /// <param name="words"></param>
        private static void TimeToLinkedListByForeach(string[] words)
        {
            LinkedList<string> linledList = new LinkedList<string>();
            Stopwatch stopWatch = Stopwatch.StartNew();
            foreach (string w in words)
            {
                linledList.AddFirst(w);
            }
            Console.WriteLine($"Время, затраченное для вставки в LinkedList с использованием цикла Foreach: " +
                              $"{stopWatch.Elapsed.Milliseconds} мс");
        }
    }
}

