using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class user
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_username { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public int user_phone { get; set; }
        public string? user_gender { get; set; }
        public string? user_dob { get; set; }
        public string?user_image { get; set; }
        public string? user_country { get; set; }
        public string? user_city { get; set; }
        public string? user_address { get; set; }
       public string? user_marital_status { get; set; }
        public string? user_qualification { get; set; }
        public string? user_school { get; set; }
        public string? user_college { get; set; }
        public string? user_work_status { get; set; }
        public string? user_organization { get; set; }
        public string? user_designation { get; set; }

    }
}
