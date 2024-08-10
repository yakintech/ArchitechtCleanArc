using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public abstract class PhoneBuilder
    {
        protected Phone phone;

        public Phone Phone
        {
            get { return phone; }
        }


        public abstract void BuildName();
        public abstract void BuildBrand();
        public abstract void BuildPrice();
        public abstract void BuildId();
    }
}
