using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Logging
{
    [Table("LogUsage")]
    public class UsageLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string APIUsage { get; set; }
    }
}
