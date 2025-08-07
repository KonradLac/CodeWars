namespace FindUnique
{
    internal class Program
    {
        /// <summary>
        /// Find a unique int in a collection with only one unique value.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        internal static int GetUnique(IEnumerable<int> numbers)
        {
            List<int> numberList = numbers.ToList();
            if (numberList.Count < 3)
            {
                return 0;
            }
            for(int i = 1; i < numberList.Count - 1; i++)
            {
                if (numberList[i] != numberList[i - 1] && numberList[i] != numberList[i + 1])
                {
                    return numberList[i];
                }
            }
            if (numberList[0] != numberList[1])
            {
                return numberList[0];
            }
            if (numberList[numberList.Count-1] != numberList[numberList.Count - 2])
            {
                return numberList[numberList.Count-1];
            }
            return 0;
        }

        static void Main(string[] args)
        {
            List<int> testList = [8, 8, 8, 8, 7];
            Console.WriteLine(GetUnique((testList)));
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Code Wars\nFind Unique\n6 kyu\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No Main implemented, nothing to see here!");
            Console.ForegroundColor = originalColor;
            Console.ReadKey();
        }
    }
}
