using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList;
        numberList = new();

        int input = -1;

        while (input != 0)
        {
            Console.WriteLine("Enter Input: ");
            string inputString = Console.ReadLine();
            input = int.Parse( inputString );
            numberList.Add(input);
        }

        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("Hello Sandbox World!");
    }
}