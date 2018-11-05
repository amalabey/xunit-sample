using System;

namespace fizzbuzz.services
{
    public class MachineTimeService : ITimeService
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}