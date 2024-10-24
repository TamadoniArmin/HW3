using System;
Console.Write("Please enter your number: ");
string number = Console.ReadLine();
string output = "";
int counter = 0;
for (int i = 0; i < number.Length; i++)
{
	counter++;
	int temp = int.Parse(number[i].ToString());
	if (i == number.Length - 1)
	{
        if (counter == 1)
        {
            output += temp.ToString()+'*';
            continue;
        }
        else
            if (counter > 1)
        {
            output += temp.ToString() + '^' + counter+'*';
            continue;
        }
	}
	if (number[i] == number[i + 1])
	{
		continue;
	}
	if (number[i] != number[i + 1])
	{
		if (counter == 1)
		{
			output += temp.ToString() + '*';
			counter = 0;
			continue;
		}
		else
			if (counter > 1)
		{
			output += temp.ToString() + '^' + counter + '*';
			counter = 0;
			continue;
		}

	}
}

string y = deleting(output);
Console.WriteLine($"The new form of your number is: {y}");
string deleting (string x)
{
	string opp = x.Remove(x.Length-1, 1);
	return opp;
}