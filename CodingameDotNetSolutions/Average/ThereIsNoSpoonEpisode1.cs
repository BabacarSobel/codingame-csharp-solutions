namespace CodingameDotNetSolutions.Average
{
    public class ThereIsNoSpoonEpisode1
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            var grid = new char[height][]; // Use a jagged array for better readability and indexing

            for (int y = 0; y < height; y++)
            {
                grid[y] = Console.ReadLine().ToCharArray();
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (grid[y][x] == '0')
                    {
                        var rightNeighbor = FindNeighbor(x, y, width, height, grid, isHorizontal: true);
                        var bottomNeighbor = FindNeighbor(x, y, width, height, grid, isHorizontal: false);

                        Console.WriteLine($"{x} {y} {rightNeighbor.x} {rightNeighbor.y} {bottomNeighbor.x} {bottomNeighbor.y}");
                    }
                }
            }
        }

        static (int x, int y) FindNeighbor(int x, int y, int width, int height, char[][] grid, bool isHorizontal)
        {
            if (isHorizontal)
            {
                for (int nx = x + 1; nx < width; nx++)
                {
                    if (grid[y][nx] == '0') return (nx, y);
                }
            }
            else
            {
                for (int ny = y + 1; ny < height; ny++)
                {
                    if (grid[ny][x] == '0') return (x, ny);
                }
            }
            return (-1, -1);
        }
    }
}
