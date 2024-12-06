//Example 1 Start:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i < number)
                {
                    Console.Write(", ");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
//Example 1 End:






//Example 2 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.Write(number * i);
            if (i < 12)
            {
                Console.Write(", ");
            }
        }
    }
}

//Example 2 End:









//Example 3 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if (i < number - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

//Example 3 End:










//Example 4 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base number: ");
        int baseNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        int result = (int)Math.Pow(baseNumber, exponent);
        Console.WriteLine($"Result: {result}");
    }
}

//Example 4 End:










//Example 5 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine($"Reversed string: {reversedString}");
    }
}

//Example 5 End:







//Example 6 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        Console.WriteLine($"Reversed number: {reversedNumber}");
    }
}
//Example 6 End:







//Example 7 Start:
using System;

class Program
{
    static void Main()
    {
        int[] array = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3, 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

        int maxDistance = 0;
        int firstIndex = -1;
        int secondIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    int distance = j - i - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        firstIndex = i;
                        secondIndex = j;
                    }
                }
            }
        }

        Console.WriteLine($"The longest distance between two identical elements is {maxDistance} cells, between elements at index {firstIndex} and {secondIndex}.");
    }
}

//Example 7 End:









//Example 8 Start:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        int maxDistance = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (firstOccurrence.ContainsKey(array[i]))
            {
                int distance = i - firstOccurrence[array[i]] - 1;
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                }
            }
            else
            {
                firstOccurrence[array[i]] = i;
            }
        }

        Console.WriteLine($"The longest distance between two identical elements is {maxDistance} cells.");
    }
}

//Example 8 End:









//Example 9 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string reversedSentence = string.Join(" ", words);

        Console.WriteLine($"Reversed sentence: {reversedSentence}");
    }
}

//Example 9 End: