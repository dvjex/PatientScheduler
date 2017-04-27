using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Doctor
{
    public class Department
    {
        public short DepartmentId { get; set; }
        [MaxLength(25)]
        public string DepartmentName { get; set; }
    }
}
