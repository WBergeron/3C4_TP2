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
        public UserPostControl(Post post, User userSelected)
        {
            User userCurrent = userSelected;
            InitializeComponent();
            ProfilImage.ImageSource = post.UserPost.Profil;
            UserName.Text = post.UserPost.Name + " " + post.UserPost.LastName;
            LikeImage.ImageSource = App.Current.stickers[1].StickerImage;
            LoveImage.ImageSource = App.Current.stickers[2].StickerImage;
            SadImage.ImageSource = App.Current.stickers[3].StickerImage;
            AngryImage.ImageSource = App.Current.stickers[0].StickerImage;
            PostImage.Source = post.PostImage;
            TitleText.Text = post.Title;
            DateText.Text = post.DateTime.ToString();
            Description.Text = post.Description;
            foreach (var reaction in post.Reactions)
            {
              if(reaction.Key == userSelected.Id)
              {
                UpdateReaction(reaction.Value, 0);    
              }
            }
            
            void UpdateReaction(Post.Reaction reaction, int selection)
            {
                if (selection == 0)
                {
                    switch (reaction)
                    {
                        case Post.Reaction.Like:
                            ButtonLike.Background = new SolidColorBrush(Colors.LightBlue);
                            NbLike.Text = post.NbLike.ToString();
                            break;
                        case Post.Reaction.Love:
                            ButtonLove.Background = new SolidColorBrush(Colors.LightBlue);
                            NbLove.Text = post.NbLove.ToString();
                            break;
                        case Post.Reaction.Sad:
                            ButtonSad.Background = new SolidColorBrush(Colors.LightBlue);
                            NbSad.Text = post.NbSad.ToString();
                            break;
                        case Post.Reaction.Angry:
                            ButtonAngry.Background = new SolidColorBrush(Colors.LightBlue);
                            NbAngry.Text = post.NbAngry.ToString();
                            break;
                        default:
                            break;
                    }
                }
                if (selection == 1)
                {
                    switch (reaction)
                    {
                        case Post.Reaction.Like:
                            ButtonLike.Background = new SolidColorBrush(Colors.LightBlue);
                            NbLike.Text = post.NbLike.ToString();
                            break;
                        case Post.Reaction.Love:
                            ButtonLove.Background = new SolidColorBrush(Colors.LightBlue);
                            NbLove.Text = post.NbLove.ToString();
                            break;
                        case Post.Reaction.Sad:
                            ButtonSad.Background = new SolidColorBrush(Colors.LightBlue);
                            NbSad.Text = post.NbSad.ToString();
                            break;
                        case Post.Reaction.Angry:
                            ButtonAngry.Background = new SolidColorBrush(Colors.LightBlue);
                            NbAngry.Text = post.NbAngry.ToString();
                            break;
                        default:
                            break;
                    }
                }


            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var source = e.OriginalSource as FrameworkElement;
            switch (source.Name)
            {
                case "ButtonLike":
                    break;
                case "ButtonLove":
                    break;
                case "ButtonSad":
                    break;
                case "ButtonAngry":
                    break;
                default:
                    break;
            }
        }
    }
}
