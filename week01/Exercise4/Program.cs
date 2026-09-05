using System.Collections.Generic;

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int number = -1;

while (number != 0)
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine();
    number = int.Parse(input);

    if (number != 0)
    {
        numbers.Add(number);
    }
}

// Calculate the sum
int sum = 0;

foreach (int item in numbers)
{
    sum += item;
}

// Calculate the average
double average = (double)sum / numbers.Count;

// Find the largest number
int largest = numbers[0];

foreach (int item in numbers)
{
    if (item > largest)
    {
        largest = item;
    }
}

Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");
Console.WriteLine($"The largest number is: {largest}");