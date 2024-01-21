using System.Transactions;

namespace lab0task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a low number");
            int lowNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a high number");
            int highNumber = Convert.ToInt32(Console.ReadLine());

            int[] numbersArray = new int[highNumber - lowNumber + 1];
            for (int i = lowNumber, j = 0; i <= highNumber; i++, j++)
            {
                numbersArray[j] = i;
            }

            Array.Reverse(numbersArray);
            // file path here would be in bin/Debug/net8.0/numbers.txt
            string filePath = Path.Combine(Environment.CurrentDirectory, "numbers.txt");

            using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
            foreach (int number in numbersArray)
            {
                writer.WriteLine(number);
            }
                Console.WriteLine($"File created successfully at: {filePath}");
            }

        }
    }
    }
