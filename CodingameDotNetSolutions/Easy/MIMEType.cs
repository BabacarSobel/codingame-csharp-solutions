namespace CodingameDotNetSolutions.Easy;

class MIMEType
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // Populate the dictionary with MIME types
        for (var i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            dic[EXT] = MT;
        }

        for (var i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            var lastDotIndex = FNAME.LastIndexOf('.');

            var extension = (lastDotIndex != -1 && lastDotIndex < FNAME.Length - 1)
                ? FNAME[(lastDotIndex + 1)..]
                : "na";

            var type = dic.GetValueOrDefault(extension, "UNKNOWN");
            Console.WriteLine(type);
        }
    }
}
