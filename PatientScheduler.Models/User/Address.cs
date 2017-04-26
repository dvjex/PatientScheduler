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
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        [ForeignKey("States")]
        public short StateId { get; set; }
        public string ZipCode { get; set; }
    }
}
