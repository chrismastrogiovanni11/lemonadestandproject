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
        public int actualTemperature;
        public string actualConditions;
        private Random gnr;



        //constructor(Spawner)
        public Weather(Random rand)
        {
            rng = rand;
            temperature = 0;
            currentCondition = null;
            weatherTypes = new List<string> { "rain", "hazy", "cloudy", "sunny", "hot" };
            actualTemperature = 0;
            actualConditions = null;
            GenerateForecast();
            ActualWeather();

            
        }
        //member methods(Can Do)

        public void GenerateForecast()
        {
            temperature = rng.Next(50, 100);
            //tempResult = temperature;
            currentCondition = weatherTypes[rng.Next(0, 5)];
            //currentResult = currentCondition;

            
            //console.readline both tempResult and currentResult;
            

        }

        public void ActualWeather()
        {
            actualTemperature = temperature + rng.Next(-5, 5);
            //if statement to range conditions between sunny and hot [3,4] if actualTemperature is <71
            //else to range conditions between [0,1,2] if actualTemperature is >70
            actualConditions = weatherTypes[rng.Next(0, 5)];
            //consoleReadLine actualConditions and actualTemperature

        }
        

    }
}
