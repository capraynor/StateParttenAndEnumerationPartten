using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateParttenAndEnumerationPartten.Interfaces;

namespace StateParttenAndEnumerationPartten.Implementations.TenantTypes {
    public class Personal : ITenantType {
        private readonly Tenant _tenant;
        public Personal(Tenant tenant) {
            _tenant = tenant;
        }
        public DateTime GetExpirationTime() {
            return _tenant.PurchaseTime + TimeSpan.FromDays ( 180 );
        }

        public string GetTypeName() {
            return "个人版";
        }
    }
}
