using System;

namespace The_Heigan_Dance
{
    class TheHeiganDance
    {
        static void Main(string[] args)
        {
            int playerRow = 7;

            int playerCol = 7;

            var playerHP = 18500;
            double heiganHP = 3000000;

            var lair = new string[15, 15];

            var playerDamage = double.Parse(Console.ReadLine());

            string lastSpell = "";

            while (true)
            {
                if (playerHP>=0)
                {
                    heiganHP -= playerDamage;
                }
                if (lastSpell=="Cloud")
                {
                    playerHP -= 3500;
                }
                if (heiganHP<=0 || playerHP<=0)
                {
                    break;
                }
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string currnetSpell = input[0];
                int targetRow = int.Parse(input[1]);

                int targetCol = int.Parse(input[2]);

                if (isInDamageArea(targetRow, targetCol, playerRow, playerCol))
                {
                    if (!isInDamageArea(targetRow, targetCol, playerRow - 1, playerCol) && !isWall(playerRow - 1))
                    {

                        playerRow--;

                        lastSpell = "";

                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol + 1) && !isWall(playerCol + 1))
                    {

                        playerCol++;

                        lastSpell = "";

                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow + 1, playerCol) && !isWall(playerRow + 1))
                    {

                        playerRow++;

                        lastSpell = "";

                    }
                    else if (!isInDamageArea(targetRow, targetCol, playerRow, playerCol - 1) && !isWall(playerCol - 1))
                    {

                        playerCol--;

                        lastSpell = "";

                    }
                    else
                    {
                        if (currnetSpell=="Cloud")
                        {
                            playerHP -= 3500;

                            lastSpell = "Cloud";
                        }
                        else if (currnetSpell== "Eruption")
                        {
                            playerHP -= 6000;

                            lastSpell = "Eruption";
                        }
                    }
                }
            }

            lastSpell = lastSpell.Equals("Cloud") ? "Plague Cloud" : "Eruption";

            string heiganState = heiganHP <= 0 ? "Heigan: Defeated!" : string.Format("Heigan: {0:f2}", heiganHP);
            string playerState = playerHP <= 0 ? string.Format("Player: Killed by {0}", lastSpell) :

                string.Format("Player: {0}", playerHP);
            string playerEndCoordinates = string.Format("Final position: {0}, {1}", playerRow, playerCol);

            Console.WriteLine(heiganState);
            Console.WriteLine(playerState);
            Console.WriteLine(playerEndCoordinates);
        }

        private static bool isWall(int moveCell)
        {
            return moveCell < 0 || moveCell >= 15;
        }

        private static bool isInDamageArea(int targetRow, int targetCol, int moveRow, int moveCol)
        {
            return ((targetRow - 1 <= moveRow && moveRow <= targetRow + 1)

                    && (targetCol - 1 <= moveCol && moveCol <= targetCol + 1));
        }
    }
}
