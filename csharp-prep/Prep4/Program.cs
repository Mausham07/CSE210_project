using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        bool flag = true;
         Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (flag){        
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
            if (num == 0){
                flag = false;
            }
        }

        int sum = 0;
        int largest = 0;
        int smallest_pos = int.MaxValue;
        foreach(int number in numbers){
            sum += number;
            if (number > largest){
                largest = number;
            }
            if (number > 0 && number < smallest_pos){
                smallest_pos = number;
            }
        }
        numbers.Sort();
        int avg = sum/(numbers.Count - 1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest_pos}");
        foreach(int number in numbers){
            Console.WriteLine(number);
        }
    }
}