using System.Text;

namespace BuildTower
{
    internal static class Program
    {
        /// <summary>
        /// A method drawing a pyramid tower based on the provided number of floors.
        /// </summary>
        /// <param name="nFloors"></param>
        /// <returns></returns>
        internal static string[] TowerBuilder(int nFloors)
        {
            if(nFloors == 0)
            {
                return [];
            }
            int lowestFloorLength = 2 * (nFloors - 1) + 1;
            int middleIndex = lowestFloorLength / 2;
            string[] drawnFloors = new string[nFloors];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nFloors; i++)
            {
                int currentFloorAsterisk = 2 * i + 1;
                for (int j = 0; j < lowestFloorLength; j++)
                {
                    if (j < (middleIndex - currentFloorAsterisk / 2) || j > (middleIndex + currentFloorAsterisk / 2))
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append("*");
                    }
                }
                drawnFloors[i] = sb.ToString();
                sb.Clear();
            }
            return drawnFloors;
        }

        /// <summary>
        /// A method displaying TowerBuilder() tower
        /// </summary>
        /// <param name="tower"></param>
        internal static void DisplayTower(string[] tower)
        {
            foreach (string i in tower)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Code Wars\nBuild Tower\n6 kyu\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No Main implemented, nothing to see here!");
            Console.ForegroundColor= originalColor;
            Console.ReadKey();
        }
    }
}
