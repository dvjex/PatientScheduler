using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Doctor
{
    public class Doctors
    {
        public int DoctorId { get; set; }
        public User.UserExtended UserInfo { get; set; }

        [ForeignKey("Department")]
        public short DepartmentID { get; set; }
    }
}
