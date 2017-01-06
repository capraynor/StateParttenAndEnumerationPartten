using System;
using StateParttenAndEnumerationPartten.Interfaces;

namespace StateParttenAndEnumerationPartten.Implementations.TenantTypes {
    public class Enterprise: ITenantType {
        private readonly Tenant _tenant;
        public Enterprise ( Tenant tenant ) {
            _tenant = tenant;
        }
        public DateTime GetExpirationTime() {
            return _tenant.PurchaseTime + TimeSpan.FromDays ( 360 );
        }

        public string GetTypeName() {
            return "企业版";
        }
    }
}