using System;

class Program
{
    static void Main()
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };
        int shortStringCount = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                shortStringCount++;
            }
        }
        string[] shortStrings = new string[shortStringCount];
    }
}