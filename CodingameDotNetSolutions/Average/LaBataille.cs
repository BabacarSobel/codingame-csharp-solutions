namespace CodingameDotNetSolutions.Average;

class LaBataille
{
    static void Main(string[] args)
    {
        var stackP1 = new Queue<int>();
        var stackP2 = new Queue<int>();

        var cardPowers = new Dictionary<string, int>
        {
            { "2", 0 }, { "3", 1 }, { "4", 2 }, { "5", 3 }, { "6", 4 }, { "7", 5 },
            { "8", 6 }, { "9", 7 }, { "10", 8 }, { "J", 9 }, { "Q", 10 }, { "K", 11 }, { "A", 12 }
        };

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string card = Console.ReadLine();
            stackP1.Enqueue(cardPowers[card[..^1]]);
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string card = Console.ReadLine();
            stackP2.Enqueue(cardPowers[card[..^1]]);
        }

        int round = 0;

        while (stackP1.Count > 0 && stackP2.Count > 0)
        {
            round++;

            var battleCardsP1 = new List<int>();
            var battleCardsP2 = new List<int>();

            while (true)
            {
                if (stackP1.Count == 0 || stackP2.Count == 0)
                {
                    Console.WriteLine("PAT");
                    return;
                }

                int cardP1 = stackP1.Dequeue();
                int cardP2 = stackP2.Dequeue();

                battleCardsP1.Add(cardP1);
                battleCardsP2.Add(cardP2);

                if (cardP1 > cardP2)
                {
                    AddCardsToWinner(stackP1, battleCardsP1, battleCardsP2);
                    break;
                }
                else if (cardP2 > cardP1)
                {
                    AddCardsToWinner(stackP2, battleCardsP1, battleCardsP2);
                    break;
                }
                else
                {
                    if (stackP1.Count < 4 || stackP2.Count < 4)
                    {
                        Console.WriteLine("PAT");
                        return;
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        battleCardsP1.Add(stackP1.Dequeue());
                        battleCardsP2.Add(stackP2.Dequeue());
                    }
                }
            }
        }

        string winner = stackP1.Count > 0 ? "1" : "2";
        Console.WriteLine($"{winner} {round}");
    }

    private static void AddCardsToWinner(Queue<int> winnerDeck, List<int> battleCardsP1, List<int> battleCardsP2)
    {
        foreach (var card in battleCardsP1) winnerDeck.Enqueue(card);
        foreach (var card in battleCardsP2) winnerDeck.Enqueue(card);
    }
}
