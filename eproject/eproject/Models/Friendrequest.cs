using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eproject.Models
{
	public class Friendrequest
	{
		[Key]
		public int Req_id{ get; set; }
		public int sender_id { get; set; }
		public int receiver_id { get; set; }
		public string req_status { get; set; }

        [ForeignKey("sender_id")]
        public user user { get; set; }




    }
}
