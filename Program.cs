using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace deleteMe
{
    class Program
    {        
        static Queue<int> deck0 = new Queue<int>();
        static Queue<int> deck1 = new Queue<int>();
        static Queue<int> warDeck0 = new Queue<int>();
        static Queue<int> warDeck1 = new Queue<int>();

        static bool endGame = false;
        static int winPlayer = 1;

        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                string nCardsPlayer0 = Console.ReadLine();
                deck0.Enqueue(FindPowerOfCard(nCardsPlayer0));
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string nCardsPlayer1 = Console.ReadLine();
                deck1.Enqueue(FindPowerOfCard(nCardsPlayer1));
            }
            int gameLap = 0;
            do
            {
                gameLap += 1;

                int lastDeck0 = deck0.Dequeue();
                int lastDeck1 = deck1.Dequeue();

                warDeck0.Enqueue(lastDeck0);
                warDeck1.Enqueue(lastDeck1);

                CheckBigerCard(lastDeck0, lastDeck1);

                warDeck0.Clear();
                warDeck1.Clear();
            } while (endGame == false);

            if (winPlayer == 0) Write("PAT");

            else if (winPlayer == 1)
            {
                Write(1 + ", ");
                WriteLine(gameLap);
            }

            else
            {
                Write(2 + ", ");
                WriteLine(gameLap);
            }
        }
        static void CheckBigerCard(int playerCard0,int playerCard1)
        {
            if(playerCard0 > playerCard1)
            {
                AddCardToDeck(1);
                if(deck1.Count == 0)
                {
                    endGame = true;
                    winPlayer = 1;
                }
            }

            if(playerCard0 < playerCard1)
            {
                AddCardToDeck(2);
                if (deck0.Count == 0)
                {
                    endGame = true;
                    winPlayer = 2;
                }
            }

            if(playerCard0 == playerCard1)
            {
                if(deck0.Count < 4 || deck1.Count < 4)
                {
                    endGame = true;
                    winPlayer = 0;
                }
                else
                {
                    warDeck0.Enqueue(deck0.Dequeue());
                    warDeck0.Enqueue(deck0.Dequeue());
                    warDeck0.Enqueue(deck0.Dequeue());
                    warDeck1.Enqueue(deck1.Dequeue());
                    warDeck1.Enqueue(deck1.Dequeue());
                    warDeck1.Enqueue(deck1.Dequeue());

                    playerCard0 = deck0.Dequeue();
                    playerCard1 = deck1.Dequeue();

                    warDeck0.Enqueue(playerCard0);
                    warDeck1.Enqueue(playerCard1);
                       
                    CheckBigerCard(playerCard0, playerCard1);
                }
            }
        }
        static void AddCardToDeck(int number)
        {
            int warDeckCount = warDeck0.Count;
            if(number == 1)
            {
                for (int i = 0; i < warDeckCount; i++)
                    deck0.Enqueue(warDeck0.Dequeue());

                for (int i = 0; i < warDeckCount; i++)
                    deck0.Enqueue(warDeck1.Dequeue());
            }
            else
            {
                for (int j = 0; j < warDeckCount; j++)
                    deck1.Enqueue(warDeck0.Dequeue());

                for (int j = 0; j < warDeckCount; j++)
                    deck1.Enqueue(warDeck1.Dequeue());
            }
        }

        static int FindPowerOfCard(string count)
        {
            string countValue = count.Substring(0, count.Length - 1);

            return countValue switch
            {
                "J" => 11,
                "Q" => 12,
                "K" => 13,
                "A" => 14,
                _ => int.Parse(countValue)
            };
        }
    }
}
