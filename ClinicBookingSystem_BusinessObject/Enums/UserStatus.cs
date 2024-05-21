using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBookingSystem_BusinessObject.Enums
{
    public enum UserStatus
    {
        [Description("Cancel")]
        Cancel = 0,
        [Description("Active")]
        Active = 1, 
        [Description("Wait for confirm")]
        Pending = 2,
    }
}
