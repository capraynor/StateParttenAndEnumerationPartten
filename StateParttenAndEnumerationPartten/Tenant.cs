using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttenAndEnumerationPartten {
    public class Tenant {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public TenantType TenantType { get; set; }
        public DateTime PurchaseTime { get; set; }

        public DateTime GetExpirationTime() {
            switch (TenantType) {
                case TenantType.Enterprise:
                    return this.PurchaseTime + TimeSpan.FromDays(365);

                case TenantType.Personal:
                    return this.PurchaseTime + TimeSpan.FromDays(180);

                case TenantType.Professonal:
                    throw new Exception( @"The Tenant type 'Professonal' is not support yet." );

                default:
                    throw new Exception ( $"Invalid Tenant type: {this.TenantType}" );
            }
        }

        public override string ToString() {
            return "【租户信息】\n " +
                   $"ID：{this.Id}\n " +
                   $"租户类型： {this.TenantType}\n" +
                   $"公司：{this.CompanyName}\n" +
                   $"合约开始时间：{this.PurchaseTime.ToLocalTime()}\n" +
                   $"合约结束时间：{this.GetExpirationTime().ToLocalTime()}\n";
        }
    }
}
