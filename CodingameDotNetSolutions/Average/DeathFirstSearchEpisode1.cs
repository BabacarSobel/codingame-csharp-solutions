namespace CodingameDotNetSolutions.Average
{
    public class DeathFirstSearchEpisode1
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
            int L = int.Parse(inputs[1]); // the number of links
            int E = int.Parse(inputs[2]); // the number of exit gateways

            var links = new List<(int node1, int node2, bool isActive, bool isSummit)>();
            var gateways = new HashSet<int>();

            for (int i = 0; i < L; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
                int N2 = int.Parse(inputs[1]);
                links.Add((N1, N2, true, false));
            }

            for (int i = 0; i < E; i++)
            {
                int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
                gateways.Add(EI);

                for (int j = 0; j < links.Count; j++)
                {
                    if (links[j].node1 == EI || links[j].node2 == EI)
                    {
                        links[j] = (links[j].node1, links[j].node2, links[j].isActive, true);
                    }
                }
            }

            // Debug: Print initial link statuses
            foreach (var link in links)
            {
                Console.Error.WriteLine($"{link.node1} {link.node2} {link.isActive} {link.isSummit}");
            }

            // Game loop
            while (true)
            {
                int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Bobnet agent is positioned this turn

                // Find the closest active summit link
                var closerSummit = links.FirstOrDefault(link =>
                    (link.node1 == SI || link.node2 == SI) && link.isActive && link.isSummit);

                // If no immediate summit link, pick any other active summit link
                if (closerSummit == default)
                {
                    closerSummit = links.FirstOrDefault(link => link.isSummit && link.isActive);
                }

                // Sever the chosen link
                if (closerSummit != default)
                {
                    links.Remove(closerSummit);
                    Console.WriteLine($"{closerSummit.node1} {closerSummit.node2}");
                }
            }
        }
    }
}
