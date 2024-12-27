namespace CodingameDotNetSolutions.Average
{
    public class PertesEnBourse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');

            int maxDrop = 0;
            int maxValue = int.Parse(inputs[0]);

            for (int i = 1; i < n; i++)
            {
                int currentValue = int.Parse(inputs[i]);

                if (currentValue < maxValue)
                {
                    maxDrop = Math.Min(maxDrop, currentValue - maxValue);
                }
                else
                {
                    maxValue = currentValue;
                }
            }

            Console.WriteLine(maxDrop);
        }
    }
}