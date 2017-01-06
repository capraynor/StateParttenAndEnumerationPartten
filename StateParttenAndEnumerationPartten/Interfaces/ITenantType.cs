using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttenAndEnumerationPartten.Interfaces {
    public interface ITenantType {
        DateTime GetExpirationTime();
        string GetTypeName();
    }
}
