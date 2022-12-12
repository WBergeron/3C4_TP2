using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _3C4_TP2_Partie2.Classes
{
    public class CharacterIcon
    {
        public int Id { get; set; }
        public string Source { get; set; }

        public BitmapImage CharacterImage => new BitmapImage(App.GetUri(Source));
    }
}
