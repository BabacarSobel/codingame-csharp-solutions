namespace CodingameDotNetSolutions.Easy;

class MarsLanderEpisode1
{
    static void Main(string[] args)
    {
        string[] inputs;
        int surfaceN = int.Parse(Console.ReadLine()); // Number of points used to draw the surface of Mars

        for (var i = 0; i < surfaceN; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }

        // Game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);       // Current X position of the lander
            int Y = int.Parse(inputs[1]);       // Current Y position of the lander
            int hSpeed = int.Parse(inputs[2]);  // Horizontal speed (m/s)
            int vSpeed = int.Parse(inputs[3]);  // Vertical speed (m/s)
            int fuel = int.Parse(inputs[4]);    // Remaining fuel (liters)
            int rotate = int.Parse(inputs[5]);  // Rotation angle (-90 to 90)
            int power = int.Parse(inputs[6]);   // Thrust power (0 to 4)

            var desiredPower = vSpeed switch
            {
                <= -40 => 4,
                <= -30 => 3,
                <= -20 => 2,
                <= -10 => 1,
                _ => 0
            };

            Console.WriteLine($"0 {desiredPower}");
        }
    }
}
