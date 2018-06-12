using Greeting_Website;
using Xunit;

namespace Greetings_Website.test
{
    public class WebsiteHosterShould
    {
        [Fact]
        public void PrintGreetingOnPostRequest()
        {
            var webHoster = new WebsiteHoster();
            webHoster.HostWebsite(new string[]{});
            
        }
        
    }
}