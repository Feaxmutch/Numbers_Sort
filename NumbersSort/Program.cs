namespace NumbersSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 50;
            int[] numbers = new int[20];
            int numberBuffer = 0;
            bool isSorted = false;

            Console.WriteLine("Числа без сортировки:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber + 1);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\n\n" + "Числа отсортированые по возрастанию:");

            while (isSorted == false)
            {
                isSorted = true;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        isSorted = false;
                        numberBuffer = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = numberBuffer;
                    }
                }

                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        isSorted = false;
                        numberBuffer = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = numberBuffer;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.ReadKey();
        }
    }
}
