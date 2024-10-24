Console.Write("Please enter your string: ");
string inputString = Console.ReadLine();
Console.Write("Please enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
string output = "";
int counter = 0;
for (int i = 0; i < inputString.Length; i++)
{
    output += inputString[i];
    counter++;
    int num = inputString.Length;
    if ((i + 1) % n == 0)
    {
        output += ", ";
        num -= 4;
    }
    if (num-n<=0)
    {
        break;
    }
}
if (inputString.Length % n != 0)
{
    for (int i = 0; i < inputString.Length - counter; i++)
    {
        output += ", " + inputString[inputString.Length - 1 - counter];
        counter++;
    }
}
//string lastoutput = output.Remove(output.Length - 1, 1);
Console.WriteLine($"The output is: {output}");