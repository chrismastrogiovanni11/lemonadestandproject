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
        List<Day> week = new List<Day>("Monday" , "Tuesday" , "Wednesday" , "Thursday" , "Friday" , "Saturday" , "Sunday");
        

        //Constructor (Spawner)

        //Member methods (Can Do)
        public void GenerateDays()
        {
            for (int i = 0; i < week.length; i++)
            {
                Day day = new Day();
                week.Add(day);
            }
        }

        public void CreateForecast()
        {

        }
    }
}
