namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleHelper.ReadNumber("The size of the array=", 3, 0);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"element[{i}]=", 3, 0);
                array[i] = element;
            }
            int frecventa = ConsoleHelper.ReadNumber("Pentru ce numar doriti sa aflati frecventa: ", 3, 0);

            ConsoleHelper.PrintArray("Array=", array);

            int minValue = ArrayHelper.Min(array);
            int maxValue = ArrayHelper.Max(array);
            int sumValue = ArrayHelper.Sum(array);
            int[] vectorInvers = ArrayHelper.VectorInvers(array);
            int countfrecventa = ArrayHelper.CalculFrecventa(array, frecventa);
            Console.WriteLine($"Min={minValue}");
            Console.WriteLine($"Max={maxValue}");
            Console.WriteLine($"Sum={sumValue}");
            Console.WriteLine($"Vector Invers={string.Join(", ", vectorInvers)}");
            Console.WriteLine($"Frecventa numarului {frecventa} este: {countfrecventa} ");
            Console.ReadLine();  //doar ca sa opresc terminalul
        }
    }
}