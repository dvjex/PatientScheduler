using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Patient
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Patients PatientInfo { get; set; }
        public Doctor.Doctors DoctorInfo { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
