using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Classes
{
    class Car : Offer
    {
        public string Fabriquant { get; set; }
        public string Marque { get; set; }
        public DateOnly Annee { get; set; }
        public int Odometre { get; set; }
        
    }
}
