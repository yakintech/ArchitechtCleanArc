using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    internal class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Stok guncellendi. Musteriye bilgi gonderildi.");
            Console.ReadLine();
        }
    }
}
