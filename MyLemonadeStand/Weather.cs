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


        public string weatherTypes;

        public int temperature;



        //constructor(Spawner)
        public Weather()
        {
            temperature = Random.next(50-100);
            weatherTypes = List < Weather > Conditions = new List<Weather>("rain", "hazy", "cloudy", "sunny", "hot");
        }
        //member methods(Can Do)
        
         public void GenerateWeather()
        {
            
            Weather weather = new weatherTypes();

            if (temperature >= 75)
            {
                Console.WriteLine("hot and sunny");

            }
            else if(temperature <=69)
            {
                Console.WriteLine("cloudy");
            }
            else(temperature <= 59)
            {
                Console.WriteLine("rain and hazy");
            }
        }
        

    }
}
