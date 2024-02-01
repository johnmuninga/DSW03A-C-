using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        char[] name;
        int gamesPlayed;
        int goals;
        static Random rnd = new Random();
        public Player()
        {
            name = null;
            gamesPlayed = 0;
            goals = 0;
        }

        public void setPlayer(char[] name)
        {
            this.name = name;
            gamesPlayed = rnd.Next(2, 21);
            goals = rnd.Next(0, 11);

        }
        public double ratePlayer()
        {
            if(gamesPlayed == 0)
            {
                return 0.0;
            }
            return (double)goals / gamesPlayed;
        }
        public string getName()
        {
            string displayNames = "";
            foreach(var item in name)
            {
                displayNames += item;
            }
            return displayNames;
        }
        public int getGames() 
        {
            return gamesPlayed;
        }
        public int getGoals()
        {
            return goals;
        }
    }
}
