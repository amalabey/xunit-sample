using System;

namespace fizzbuzz.services
{
    public class FizzBuzzService
    {
        public string Print(int v)
        {
            if(v % 3 == 0)
            {
                return "Fizz";
            }else if(v % 5 == 0)
            {
                return "Buzz";
            }else{
                return v.ToString();
            }
        }
    }
}
