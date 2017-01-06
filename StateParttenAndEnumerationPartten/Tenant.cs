using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateParttenAndEnumerationPartten.Enumerations;
using StateParttenAndEnumerationPartten.Implementations.TenantTypes;
using StateParttenAndEnumerationPartten.Interfaces;

namespace StateParttenAndEnumerationPartten {
    public class Tenant {
        public long Id { get; set; }

        public string CompanyName { get; set; }

        public DateTime PurchaseTime { get; set; }

        public ITenantType Type { get; set; }

        public void SetType(TenantType typeCode) {
            switch (typeCode) {
                case TenantType.Enterprise:
                    Type = new Enterprise(this);
                    break;

                case TenantType.Personal:
                    Type = new Personal(this);
                    break;

                case TenantType.Professonal:
                    throw new Exception(@"The Tenant type 'Professonal' is not support yet.");

                default:
                    throw new Exception($"Invalid Tenant type: {typeCode}");
            }
        }

        public override string ToString() {
            return "【租户信息】\n" +
                   $"ID：{this.Id}\n" +
                   $"公司：{this.CompanyName}\n" +
                   $"合约开始时间：{this.PurchaseTime.ToLocalTime()}\n" +
                   $"合约结束时间：{Type.GetExpirationTime().ToLocalTime()}\n" +
                   $"合约类型：{Type.GetTypeName()}";
        }
    }
}
