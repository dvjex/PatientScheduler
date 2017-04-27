using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.User
{
    /// <summary>
    /// Class for storing addresses
    /// </summary>
    public class Address
    {
        [Key]        
        public int AddressId { get; set; }

        [MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string Address3 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [ForeignKey("States")]
        public short StateId { get; set; }

        [MaxLength(10)]
        public string ZipCode { get; set; }
    }
}
