using System;
Console.Write("Please enter your binary number: ");
string binary = Console.ReadLine();
int answer =bin()

 int bin (string x)
{
    int number = 0;
    int num = binary.Length - 1;
    for (int i = 0; i < binary.Length; i++)
    {
        int temp = int.Parse(binary[i].ToString());
        if (temp == 1)
        {
            number += (int)Math.Pow(2, num);

        }
        num -= 1;
    }
    return number;
}