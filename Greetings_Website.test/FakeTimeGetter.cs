using System;
using Greeting_Website;

namespace Greetings_Website.test
{
    public class FakeTimeGetter : TimeGetterInterface
    {
        public DateTime GetDateTime()
        {
            return new DateTime(2018, 1, 18, 5, 23, 5); //18th jan 5:23am
        }
    }
}