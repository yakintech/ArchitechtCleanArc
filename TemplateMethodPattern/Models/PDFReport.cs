﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Models
{
    public class PDFReport : SystemReports
    {
        public override void WriteReport()
        {
            Console.WriteLine("Writing PDF Report");
        }
    }
}
