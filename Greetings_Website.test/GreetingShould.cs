using System;
using System.Collections;
using System.Collections.Generic;
using Greeting_Website;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Xunit;

namespace Greetings_Website.test
{
    public class GreetingShould
    {
        [Fact]
        public void GiveTheCorrectDate()
        {
            var greeting = new Greeting();
            var timeGetter = new FakeTimeGetter();
            var result = greeting.GetTime(timeGetter);
            Assert.Equal(" - the time on the server is 5:23AM on 18 January 2018",result );
        }

        [Theory]
        [InlineData("","Hello Jordan")]
        [InlineData("Mark", "Hello Jordan and Mark")]
        [InlineData("Mark,David", "Hello Jordan, Mark and David")]
        public void GetCorrectNamings(string dir, string expected)
        {
            var names = dir.Split(',');
            if(dir == "")
                names = new string[0];
            
            var greeting = new Greeting();
            var result= greeting.GetNames(names);
            Assert.Equal(expected,result);
        }
    }
}