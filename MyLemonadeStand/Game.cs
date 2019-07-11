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
        public string Player;
        public string instructions;
        List<Day> week = new List<Day>();

        //Constructor (Spawner)
        public Game()
        {
            



        }



        //Member methods (Can Do)
        public void GenerateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                week.Add(day);
            }
        }

        public void CreateForecast()
        {

        }

        public void DisplayInstructions()
        {

            Console.WriteLine("The objective of the lemonade stand is to take the initial money and develop a profitable lemonade stand. You will spend money on lemons, ice, and sugar. You can customize the recipe how you would like. If customers like it you'll receive more profit, if they dont you wont get as many customers. Try to gain as much profit as possible. ");
            Console.ReadKey();
        }

        public void GetPlayerName()
        {
            Console.WriteLine("Enter player name");
            Console.ReadLine();
        }


        public void RunGame()
        {
            GetPlayerName();
            DisplayInstructions();
            GenerateDays();
            CreateForecast();

        }
    }
   
}
