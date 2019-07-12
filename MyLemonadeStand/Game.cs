using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Game
    {


        //member variables (Has A)
        
        public string instructions;
        List<Day> week = new List<Day>();
        public Random gnr;
        

        //Constructor (Spawner)
        public Game()
        {

            gnr = new Random();


        }



        //Member methods (Can Do)
        public void GenerateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(gnr);
                week.Add(day);
                
            }
        }


        public void DisplayInstructions()
        {

            Console.WriteLine("The objective of the lemonade stand is to take the initial money and develop a profitable lemonade stand. You will spend money on lemons, ice, and sugar. You can customize the recipe how you would like. If customers like it you'll receive more profit, if they dont you wont get as many customers. Try to gain as much profit as possible. ");
            Console.ReadKey();
        }

        public void GetPlayerName()
        {
            Player player = new Player();
            Console.WriteLine("Enter Player name");
            player.playerName = Console.ReadLine();
        }

        public void GetInventory()
        {
            Inventory inventory = new Inventory();
        }

        public void RunGame()
        {
            GetPlayerName();
            DisplayInstructions();
            GenerateDays();
            for (int i = 0; i < week.Count; i++)
            {
                Console.WriteLine("Today's Forecast");

                int test = week[i].weather.temperature;
                Console.WriteLine(test);

                string condition = week[i].weather.currentCondition;
                Console.WriteLine(condition);

            }

        }
    }
   
}
