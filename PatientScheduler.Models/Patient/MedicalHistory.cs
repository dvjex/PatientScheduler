using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Patient
{
    /// <summary>
    /// Stores Medical Information. Not medically accurate.
    /// </summary>
    public class MedicalHistory
    {
        [Key]
        public int MedicalId { get; set; }
        public string Notes { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
