using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _3C4_TP2_Partie2.Classes
{
    public class ElementIcon
    {
        public Character.element IdElement { get; set; }
        public Character.rarity IdRarity { get; set; }
        public string Source { get; set; }

        public BitmapImage ElementImage => new BitmapImage(App.GetUri(Source));
    }
}
