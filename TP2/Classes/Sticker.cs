using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TP2.Classes
{
    internal class Sticker : Comment
    {
        public string SourceSticker { get; set; }

        public BitmapImage StickerImage => new BitmapImage(App.GetUri(SourceSticker));
    }
}
