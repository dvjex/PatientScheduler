using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string DrugName { get; set; }
        public int IntakePerDay { get; set; }
        public int IntakeId { get; set; }

        public string Notes { get; set; }
    }
}
