using System.ComponentModel.DataAnnotations;

namespace PatientScheduler.Models.User
{
    //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(75)]
        public string Username { get; set; }
        [MinLength(4)]
        public string Password { get; set; }
    }
}
