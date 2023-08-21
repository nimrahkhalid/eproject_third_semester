using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class friends
    {
        [Key]
        public int friend_id { get; set; }
        public int user_id { get; set; }
    }
}