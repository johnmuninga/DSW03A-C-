using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PlayerRecord
    {
        Player[] player;
        int counter;
        public PlayerRecord()
        {
            player = new Player[4];
            counter= 0;
        }

        public void addPlayer(Player player) 
        {
            if(counter > 4)
            {
                Console.WriteLine("There's no space");

            }
            else
            {
                this.player[counter] = player;
                counter++;
            }
        }

        public void sort()
        {
            // 1 2 3 4 5
            for (int i = 0; i < player.Length; i++)
            {
                //5 4 3 2
                for(int j = i + 1; j <= player.Length - 1; j++)
                {
                    if (player[i].ratePlayer() < player[j].ratePlayer())
                    {
                        Player newPlayers = player[j];
                        player[j] = player[i];
                        player[i] = newPlayers;
                    }
                }
            }
        }

        public Player getPlayerAt(int index)
        {
            if(index >= 0 && index < 4)
            {
                return player[index];
            }
            else
            {
                return null;
            }
        }

    }
}
