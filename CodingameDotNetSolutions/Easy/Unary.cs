using System.Text;

namespace CodingameDotNetSolutions.Easy;

class Unary
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();

        var binaryCode = new StringBuilder();
        foreach (char ch in MESSAGE)
        {
            binaryCode.Append(Convert.ToString(ch, 2).PadLeft(7, '0'));
        }

        var response = new StringBuilder();
        int i = 0;

        while (i < binaryCode.Length)
        {
            char currentChar = binaryCode[i];
            int count = 0;

            while (i + count < binaryCode.Length && binaryCode[i + count] == currentChar)
            {
                count++;
            }

            response.Append(currentChar == '0' ? "00 " : "0 ");
            response.Append(new string('0', count));
            response.Append(" ");

            i += count;
        }

        Console.WriteLine(response.ToString().TrimEnd());
    }
}
