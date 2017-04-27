using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientScheduler.Models.User
{
    /// <summary>
    /// Model to store all user related information
    /// </summary>
    public class UserExtended : User
    {
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        
        public List<Phones> PhoneList { get; set; }
        public List<Address> AddressList { get; set; }
        
        public bool Active { get; set; }

        [ForeignKey("Roles")]
        public short RoleId { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
