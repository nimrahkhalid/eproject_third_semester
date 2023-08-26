using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
	public class chat
	{
		[Key]
		public int chat_id { get; set; }
		public int sender_id { get; set; }
		public int receiver_id { get; set; }
	}
}
