using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientScheduler.Models.User
{
    /// <summary>
    /// Model to store all user related information
    /// </summary>
    public class UserExtended : User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        
        public List<Phones> PhoneList { get; set; }
        public List<Address> AddressList { get; set; }
        
        public bool Active { get; set; }

        [ForeignKey("Roles")]
        public short RoleId { get; set; }
    }
}
