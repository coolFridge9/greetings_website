using System;
using System.ComponentModel;

namespace Greeting_Website
{
    public class ActualTimeGetter : TimeGetterInterface
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}