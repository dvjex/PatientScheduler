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
    /// Stores Diagnosis Information. Not medically accurate.
    /// </summary>
    public class DiagnosisHistory
    {
        [Key]
        public long DiagnosisId { get; set; }
        public string Diagnosis { get; set; }
        public DrugHistory DrugsPrescribed { get; set; }

    }
}
