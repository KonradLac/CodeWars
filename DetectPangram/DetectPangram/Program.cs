namespace DetectPangram
{
    internal class Program
    {
        /// <summary>
        /// Detects if a give string is a pangram, so if it contains all characters of the standard English alphabet.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal static bool IsPangram(string s)
        {
            if (s.Length < 26 || string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            // Can check it all without checking for both lower and upper case, with just getting the s either to upper or to lower case, the intent was different, though.
            char[] alphabetTable = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<char> dividedString = s.ToCharArray().ToList();
            for (int i = 0; i < alphabetTable.Length; i++)
            {
                if (dividedString.Contains(alphabetTable[i]) || dividedString.Contains(alphabetTable[i].ToString().ToUpper().ToCharArray()[0]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Code Wars\nDetect Pangram\n6 kyu\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No Main implemented, nothing to see here!");
            Console.ForegroundColor = originalColor;
            Console.ReadKey();
        }
    }
}
