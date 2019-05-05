using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace alexyz.dev.dbrepo.Models
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }
        public string TweetText { get; set; }
        public string TweetItemId { get; set; }
        public int Likes { get; set; }
        public int Retweets { get; set; }
    }
}