using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of Player {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            // record object
            PlayerRecord record = new PlayerRecord();

            foreach (string playerNames in names)
            {
                Player obj = new Player();
                obj.setPlayer(playerNames.ToCharArray());
                record.addPlayer(obj);
            }
            Console.WriteLine();
            Console.WriteLine($"Name \t Played \t Goals \t Rating");
            Console.WriteLine($"==== \t ====== \t ===== \t ======");
            for(int i = 0; i < 4; i++)
            {
                Player objplayer = record.getPlayerAt(i);
                Console.WriteLine($"{objplayer.getName()}\t{objplayer.getGames()}\t\t  {objplayer.getGoals()}\t {objplayer.ratePlayer()}%");
            }
            
            Console.WriteLine();
            Console.WriteLine("After sorting ");
            record.sort();
            Console.WriteLine($"Name \t Played \t Goals \t Rating");
            Console.WriteLine($"==== \t ====== \t ===== \t ======");
            for (int i = 0; i < 4; i++)
            {
                Player player = record.getPlayerAt(i);
                Console.WriteLine($"{player.getName()}\t{player.getGames()}\t\t  {player.getGoals()}\t {player.ratePlayer()}%");
            }

            Console.ReadKey();

        }
    }
}
