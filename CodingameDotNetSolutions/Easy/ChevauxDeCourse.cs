namespace CodingameDotNetSolutions.Easy;

class ChevauxDeCourse
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int minDiff = int.MaxValue;

        for (int i = 1; i < N; i++)
        {
            int diff = numbers[i] - numbers[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
            if (minDiff == 0)
            {
                break;
            }
        }

        Console.WriteLine(minDiff);
    }
}
