using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models
{
    public abstract class SystemReports
    {
        public void CalculateTax()
        {
            Console.WriteLine("Calculating Tax");
        }

        public void CalculatePersonalAllowance()
        {
            Console.WriteLine("Calculating Personal Allowance");
        }

        public void CalculateNationalInsurance()
        {
            Console.WriteLine("Calculating National Insurance");
        }

        public abstract void WriteReport();

        public void GenerateReport()
        {
            CalculateTax();
            CalculatePersonalAllowance();
            CalculateNationalInsurance();
            WriteReport();
        }
    }
}
