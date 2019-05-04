using System.Linq;

namespace alexyz.dev.dbrepo.Functions.Tweets
{
    public class TweetsFunctions
    {
        public static string GetLastTweet()
        {
            var gltContext = new DatabaseContext();

            return gltContext.Tweets.FirstOrDefault()?.TweetText;
        }
    }
}