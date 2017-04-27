using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Patient
{
    /// <summary>
    /// Stores Information about Drugs. Not medically accurate.
    /// </summary>
    public class DrugHistory
    {
        [Key]
        public int DrugId { get; set; }
        [MaxLength(100)]
        public string DrugName { get; set; }
        public short IntakePerDay { get; set; }

        /// <summary>
        /// How many days to take the drug
        /// </summary>
        public short TotalDays { get; set; }

        public string Notes { get; set; }
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
