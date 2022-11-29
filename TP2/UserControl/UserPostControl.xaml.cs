using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP2.Classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour UserPostControl.xaml
    /// </summary>
    public partial class UserPostControl : UserControl
    {
        public UserPostControl(User user)
        {
            InitializeComponent();
            ProfilImage.ImageSource = user.Profil;
            UserName.Text = user.Name + " " + user.LastName;
            LikeImage.ImageSource = App.Current.stickers[1].StickerImage;
            LoveImage.ImageSource = App.Current.stickers[2].StickerImage;
            SadImage.ImageSource = App.Current.stickers[3].StickerImage;
            AngryImage.ImageSource = App.Current.stickers[0].StickerImage;

            foreach (var post in App.Current.Posts.Values)
            {
                PostImage.Source = post.PostImage;
            }
        }
    }
}
