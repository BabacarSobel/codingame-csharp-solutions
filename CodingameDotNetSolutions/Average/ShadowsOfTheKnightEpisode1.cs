namespace CodingameDotNetSolutions.Average
{
    public class ShadowsOfTheKnightEpisode1
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);

            int minX = 0, minY = 0; // Minimum bounds
            int maxX = W, maxY = H; // Maximum bounds

            // Game loop
            while (true)
            {
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

                // Update bounds based on bomb direction
                if (bombDir.Contains("U")) maxY = Y0 - 1;
                if (bombDir.Contains("D")) minY = Y0 + 1;
                if (bombDir.Contains("L")) maxX = X0 - 1;
                if (bombDir.Contains("R")) minX = X0 + 1;

                // Calculate new position
                X0 = (minX + maxX) / 2;
                Y0 = (minY + maxY) / 2;

                // the location of the next window Batman should jump to.
                Console.WriteLine($"{X0} {Y0}");
            }
        }
    }
}