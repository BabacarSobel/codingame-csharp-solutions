namespace CodingameDotNetSolutions.Easy;

class PowerOfThorEpisode1
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // The X position of the light of power
        int lightY = int.Parse(inputs[1]); // The Y position of the light of power
        int initialTx = int.Parse(inputs[2]);  // Thor's starting X position
        int initialTy = int.Parse(inputs[3]);  // Thor's starting Y position

        // Game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());

            var direction = "";

            if (initialTy < lightY)
            {
                direction += "S";
                initialTy++;
            }
            else if (initialTy > lightY)
            {
                direction += "N";
                initialTy--;
            }

            if (initialTx < lightX)
            {
                direction += "E";
                initialTx++;
            }
            else if (initialTx > lightX)
            {
                direction += "W";
                initialTx--;
            }

            Console.WriteLine(direction);
        }
    }
}
