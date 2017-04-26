using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Common
{
    public class States
    {
        [Key]
        public short StateId { get; set; }
        public string StateName { get; set; }
    }
}
