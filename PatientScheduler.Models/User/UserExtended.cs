using System.Collections.Generic;

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
    }
}
