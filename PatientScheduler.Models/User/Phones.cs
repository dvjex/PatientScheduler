using System.ComponentModel.DataAnnotations;

namespace PatientScheduler.Models.User
{
    public class Phones
    {
        public short PhoneType { get; set; }
        [MaxLength(25)]
        public string PhoneNumber { get; set; }
    }
}
