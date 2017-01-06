using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateParttenAndEnumerationPartten.Enumerations;

namespace StateParttenAndEnumerationPartten {
    public class Program {
        public static void Main ( string[] args ) {
            var tenant = new Tenant {
                Id = 1,
                CompanyName = "北京天职信息技术有限公司",
                PurchaseTime = DateTime.Now,
            };

            tenant.SetType(TenantType.Enterprise);

            Console.Write(tenant.ToString());
            Console.ReadKey();
        }
    }
}
