using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttenAndEnumerationPartten {
    public class Program {
        public static void Main ( string[] args ) {
            var tenant = new Tenant {
                Id = 1,
                CompanyName = "北京天职信息技术有限公司",
                TenantType = TenantType.Enterprise,
                PurchaseTime = DateTime.Now,
            };

            Console.Write(tenant.ToString());
            Console.ReadKey();
        }
    }
}
