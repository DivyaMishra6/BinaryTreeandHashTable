﻿namespace BinaryTreeAndHashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree And Hash Tree ");
            Code<int> obj = new Code<int>(56);
            obj.Add(30);
            obj.Add(70);
            obj.Add(22);
            obj.Add(40);
            obj.Add(60);
            obj.Add(95);
            obj.Add(11);
            obj.Add(65);
            obj.Add(3);
            obj.Add(16);
            obj.Add(63);
            obj.Add(67);

            obj.Size();
            obj.Display();
        }
    }
}