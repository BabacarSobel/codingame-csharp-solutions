namespace CodingameDotNetSolutions.Average
{
    public class DontPanicEpisode1
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int nbFloors = int.Parse(inputs[0]); // number of floors
            int width = int.Parse(inputs[1]); // width of the area
            int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
            int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
            int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
            int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
            int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
            int nbElevators = int.Parse(inputs[7]); // number of elevators

            var elevatorPositions = new Dictionary<int, int>();
            for (int i = 0; i < nbElevators; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
                int elevatorPos = int.Parse(inputs[1]); // position of the elevator on its floor
                elevatorPositions[elevatorFloor] = elevatorPos;
            }

            // Add exit position for the exit floor to the dictionary for unified logic
            elevatorPositions[exitFloor] = exitPos;

            // Game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
                int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
                string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT

                if (cloneFloor == -1 || clonePos == -1 || direction == "NONE")
                {
                    Console.WriteLine("WAIT");
                    continue;
                }

                int targetPos = elevatorPositions[cloneFloor];
                bool shouldBlock = ShouldBlock(clonePos, targetPos, direction);

                Console.WriteLine(shouldBlock ? "BLOCK" : "WAIT");
            }
        }

        static bool ShouldBlock(int clonePos, int targetPos, string direction)
        {
            // Determine if the clone needs to be blocked
            return (targetPos < clonePos && direction == "RIGHT") ||
                   (targetPos > clonePos && direction == "LEFT");
        }
    }
}