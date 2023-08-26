using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
	public class Friendrequest
	{
		[Key]
		public int chat_id{ get; set; }
		public int sender_id { get; set; }
		public int receiver_id { get; set; }
		public string req_status { get; set; }



	}
}
