using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Weather
    {
        //member variables (Has A)


        public List<string> weatherTypes;

        public int temperature;
        public string currentCondition;
        private Random rng;



        //constructor(Spawner)
        public Weather()
        {
            rng = new Random();
            weatherTypes = new List<string> { "rain", "hazy", "cloudy", "sunny", "hot" };
            GenerateWeather();
        }
        //member methods(Can Do)
        
        public void GenerateWeather()
        {
            temperature = rng.Next(50, 100);
            currentCondition = weatherTypes[rng.Next(0,6)];
     
        }
        

    }
}
