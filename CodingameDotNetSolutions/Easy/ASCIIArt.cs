using System.Text;

namespace CodingameDotNetSolutions.Easy;

class ASCIIArt
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();

        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?".ToCharArray();
        var asciiArt = new Dictionary<char, List<string>>();

        for (int i = 0; i < H; i++)
        {
            var ROW = Console.ReadLine();
            for (int j = 0; j < alphabet.Length; j++)
            {
                char character = alphabet[j];
                if (!asciiArt.ContainsKey(character))
                {
                    asciiArt[character] = new List<string>();
                }
                asciiArt[character].Add(ROW.Substring(j * L, L));
            }
        }

        var response = new StringBuilder[H];
        for (var i = 0; i < H; i++)
        {
            response[i] = new StringBuilder();
        }

        foreach (var c in T)
        {
            char key = asciiArt.ContainsKey(c) ? c : '?';
            for (var i = 0; i < H; i++)
            {
                response[i].Append(asciiArt[key][i]);
            }
        }

        foreach (var line in response)
        {
            Console.WriteLine(line.ToString());
        }
    }
}
