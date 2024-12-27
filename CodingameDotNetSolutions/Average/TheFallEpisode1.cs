namespace CodingameDotNetSolutions.Average;

class TheFallEpisode1
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // number of columns
        int H = int.Parse(inputs[1]); // number of rows

        int[,] map = new int[W, H];

        // Read the map of rooms
        for (int i = 0; i < H; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < W; j++)
            {
                map[j, i] = int.Parse(values[j]);
            }
        }

        int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

        // Game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int XI = int.Parse(inputs[0]);
            int YI = int.Parse(inputs[1]);
            string POS = inputs[2];

            var (addX, addY) = GetNextPosition(map[XI, YI], POS);

            Console.WriteLine($"{XI + addX} {YI + addY}");
        }
    }

    private static (int addX, int addY) GetNextPosition(int type, string enterPos)
    {
        return type switch
        {
            1 => (0, 1),
            2 => enterPos == "LEFT" ? (1, 0) : (enterPos == "RIGHT" ? (-1, 0) : (0, 0)),
            3 => enterPos == "TOP" ? (0, 1) : (0, 0),
            4 => enterPos == "TOP" ? (-1, 0) : (enterPos == "RIGHT" ? (0, 1) : (0, 0)),
            5 => enterPos == "TOP" ? (1, 0) : (enterPos == "LEFT" ? (0, 1) : (0, 0)),
            6 => enterPos == "LEFT" ? (1, 0) : (enterPos == "RIGHT" ? (-1, 0) : (0, 0)),
            7 => enterPos == "TOP" || enterPos == "RIGHT" ? (0, 1) : (0, 0),
            8 => enterPos == "LEFT" || enterPos == "RIGHT" ? (0, 1) : (0, 0),
            9 => enterPos == "TOP" || enterPos == "LEFT" ? (0, 1) : (0, 0),
            10 => enterPos == "TOP" ? (-1, 0) : (0, 0),
            11 => enterPos == "TOP" ? (1, 0) : (0, 0),
            12 => enterPos == "RIGHT" ? (0, 1) : (0, 0),
            13 => enterPos == "LEFT" ? (0, 1) : (0, 0),
            _ => (0, 0)
        };
    }
}
