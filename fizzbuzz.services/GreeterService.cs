using System;

namespace fizzbuzz.services
{
    public class GreeterService
    {
        public string GetGreeting(string name)
        {
            var timeOfTheDay = GetTimeOfTheDay();
            return $"Good {timeOfTheDay}, {name}";
        }

        private string GetTimeOfTheDay()
        {
            int hours = DateTime.Now.Hour;
            if(hours > 0 && hours < 12){
                return "morning";
            }else if(hours >= 12 && hours < 18)
            {
                return "afternoon";
            }else{
                return "evening";
            }
        }
    }
}