using System.Collections.Generic;

namespace PatientScheduler.Models.Patient
{
    public class Patients
    {
        public User.UserExtended UserInfo { get; set; }

        public List<DiagnosisHistory> DiagnosisHistory { get; set; }
        public List<MedicalHistory> MedicalHistory { get; set; }
        public List<DrugHistory> DrugHistory { get; set; }
    }
}
