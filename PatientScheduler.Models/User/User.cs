namespace PatientScheduler.Models.User
{
    //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
