using System.Text;

namespace CodingameDotNetSolutions.Average;

public class SuiteDeConway
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());

        string currentLine = $"{R}";
        for (int i = 1; i < L; i++)
        {
            currentLine = BuildNextLine(currentLine);
        }

        Console.WriteLine(currentLine);
    }

    static string BuildNextLine(string line)
    {
        StringBuilder newLine = new StringBuilder();
        int count = 0;
        string[] values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string previous = values[0];

        foreach (var value in values)
        {
            if (value == previous)
            {
                count++;
            }
            else
            {
                newLine
                    .Append(count).Append(' ')
                    .Append(previous).Append(' ');
                previous = value;
                count = 1;
            }
        }

        if (count > 0)
        {
            newLine
                .Append(count).Append(' ')
                .Append(previous);
        }

        return newLine.ToString();
    }
}