using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientScheduler.Models.Logging
{
    [Table("LogException")]
    public class ExceptionLog
    {
        public int Id { get; set; }
        public string StackTrace { get; set; }
        public string Message { get; set; }

        //Are TargetSite, Source, HResult needed?
    }
}
