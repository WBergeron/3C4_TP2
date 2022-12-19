using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace William_TP2_Partie2
{
    partial class Objet
    {
        public int Id;
        public string Name;
        public int Niveau;
        public string Description;
        public string Source { get; set; }
        public BitmapImage ImageObjet => new BitmapImage(App.GetUri(Source));
    }
}
