namespace CodingameDotNetSolutions.Easy;

public class LaDescente
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            int maxHeight = -1;
            int targetMountain = -1;

            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine());

                if (mountainH > maxHeight)
                {
                    maxHeight = mountainH;
                    targetMountain = i;
                }
            }

            Console.WriteLine(targetMountain);
        }
    }
}