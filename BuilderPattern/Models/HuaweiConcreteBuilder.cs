using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    internal class HuaweiConcreteBuilder : PhoneBuilder
    {
        public HuaweiConcreteBuilder()
        {
            phone = new Phone();
        }

        public override void BuildBrand()
        {
            phone.Brand = "Huawei";
        }

        public override void BuildId()
        {
            phone.Id = 2;
        }

        public override void BuildName()
        {
            phone.Name = "P30";
        }

        public override void BuildPrice()
        {
            phone.Price = 500;
        }
    }
}
