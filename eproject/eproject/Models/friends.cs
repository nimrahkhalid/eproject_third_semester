using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eproject.Models
{
    public class friends
    {
        [Key]
        public int friend_id { get; set; }
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public user user { get; set; }
    }
}