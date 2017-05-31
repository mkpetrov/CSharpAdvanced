using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var playersCards=new Dictionary<string,HashSet<string>>();

            while (inputLine!="JOKER")
            {
                var inputParts = inputLine.Split(':').ToArray();
                var name = inputParts[0];
                var cards = inputParts[1];
                var cardsList = cards.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!playersCards.ContainsKey(name))
                {
                    playersCards[name]=new HashSet<string>();
                }
                foreach (var card in cardsList)
                {
                    playersCards[name].Add(card);
                }

                inputLine = Console.ReadLine();
            }

            var output=new Dictionary<string,int>();

            foreach (var player in playersCards)
            {
                var playerName = player.Key;
                var playerCards = player.Value;

                if (!output.ContainsKey(playerName))
                {
                    output[playerName] = 0;
                }
                
                foreach (var card in playerCards)
                {
                    var pointsToAdd = 0;
                    if (card.Length==3)
                    {
                        pointsToAdd += 10;

                        var type = card[2];

                        switch (type)
                        {
                            case 'S':
                                pointsToAdd *= 4;
                                break;
                            case 'H':
                                pointsToAdd *= 3;
                                break;
                            case 'D':
                                pointsToAdd *= 2;
                                break;
                            case 'C':
                                pointsToAdd *= 1;
                                break;
                        }
                        output[playerName] += pointsToAdd;

                    }
                    else
                    {
                        var power = card[0];
                        var type = card[1];

                        if (power >= 50 && power <= 57)
                        {
                            pointsToAdd += int.Parse(power.ToString());
                        }
                        else
                        {
                            if (power=='J')
                            {
                                pointsToAdd += 11;
                            }
                            else if (power=='Q')
                            {
                                pointsToAdd += 12;
                            }
                            else if (power=='K')
                            {
                                pointsToAdd += 13;
                            }
                            else if (power=='A')
                            {
                                pointsToAdd += 14;
                            }
                        }

                        switch (type)
                        {
                            case 'S':
                                    pointsToAdd *= 4;
                                break;
                            case 'H':
                                pointsToAdd *= 3;
                                break;
                            case 'D':
                                pointsToAdd *= 2;
                                break;
                            case 'C':
                                pointsToAdd *= 1;
                                break;
                        }
                        output[playerName] += pointsToAdd;
                    }
                }
                
            }

            foreach (var entry in output)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
