using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ThirtiseventhApplication.ConsoleApp
{
    class Program
    {
        const string path = @"C:\Users\bekManOfSteal\Downloads\Text1.txt";
        static void Main(string[] args)
        {
            var perfomanceList = GetPerfomanceList();
            var perfomanceLinkedList = GetPerfomanceLinkedList();

            var result = $"insert speed list : {perfomanceList} - insert speed linked list {perfomanceLinkedList}";
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static long GetPerfomanceList()
        {
            var list = new List<string>();
            var data = File.ReadAllLines(path).ToList();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach (var item in data)
            {
                list.Add(item);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        private static long GetPerfomanceLinkedList()
        {
            var list = new LinkedList<string>();
            var data = File.ReadAllLines(path).ToList();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach (var item in data)
            {
                list.AddLast(item);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
