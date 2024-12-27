namespace CodingameDotNetSolutions.Easy;

class Températures
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // The number of temperatures to analyze
        string[] inputs = Console.ReadLine().Split(' ');
        int closestTemp = 0;

        if (n > 0)
        {
            closestTemp = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(inputs[i]);
                int absT = Math.Abs(t);
                int absClosestTemp = Math.Abs(closestTemp);

                if (absT < absClosestTemp || (absT == absClosestTemp && t > closestTemp))
                {
                    closestTemp = t;
                }
            }
        }

        Console.WriteLine(closestTemp);
    }
}