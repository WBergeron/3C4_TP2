using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TP2.Classes
{
    public class Offer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime DateDeMiseEnVente { get; set; }
        public string Source { get; set; }
        public BitmapImage ImageOffer => new BitmapImage(App.GetUri(Source));

    }
}
