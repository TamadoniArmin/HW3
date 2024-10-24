using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.Write("Please enter your binary number: ");
string binary = Console.ReadLine();
int answer = binarynumber(binary);
Console.WriteLine($"The answer is: {answer}");
int binarynumber (string x)
{
    int number = 0;
    int num = x.Length - 1;
    for (int i = 0; i < x.Length; i++)
    {
        int temp = int.Parse(x[i].ToString());
        if (temp == 1)
        {
            number += (int)Math.Pow(2, num);

        }
        num -= 1;
    }
    return number;
}