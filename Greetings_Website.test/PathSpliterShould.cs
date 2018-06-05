using Greeting_Website;
using Xunit;

namespace Greetings_Website.test
{
    public class PathSpliterShould
    {
        [Fact]
        public void SplitAPathIntoNamesListNoNames()
        {
            var pathSplitter = new PathSplitter();
            var result = pathSplitter.SplitPath("/");
            Assert.Equal(new string[0], result);
        }
        
        [Fact]
        public void SplitAPathIntoNamesListOneName()
        {
            var pathSplitter = new PathSplitter();
            var result = pathSplitter.SplitPath("/cam");
            Assert.Equal(new string[]{"cam"}, result);
        }
        [Fact]
        public void SplitAPathIntoNamesListTwoNames()
        {
            var pathSplitter = new PathSplitter();
            var result = pathSplitter.SplitPath("/cam/jordan");
            Assert.Equal(new string[]{"cam","jordan"}, result);
        }
        
    }
}