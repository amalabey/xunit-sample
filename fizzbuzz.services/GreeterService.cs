using System;

namespace fizzbuzz.services
{
    public class GreeterService
    {
        private ITimeService _timeService;

        public GreeterService(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string GetGreeting(string name)
        {
            var timeOfTheDay = GetTimeOfTheDay();
            return $"Good {timeOfTheDay}, {name}";
        }

        private string GetTimeOfTheDay()
        {
            int hours = _timeService.Now().Hour;

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