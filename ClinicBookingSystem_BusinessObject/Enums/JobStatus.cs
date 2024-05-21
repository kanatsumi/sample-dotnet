using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBookingSystem_BusinessObject.Enums
{
    public enum JobStatus
    {
        [Description("Fired")]
        Fired = 0,
        [Description("Working")]
        Working = 1,
    }
}
