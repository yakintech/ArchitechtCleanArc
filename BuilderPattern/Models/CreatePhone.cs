using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class CreatePhone
    {

        public void Create(PhoneBuilder phone)
        {
            phone.BuildName();
            phone.BuildBrand();
            phone.BuildPrice();
            phone.BuildId();
        }
    }
}
