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
        public Post Post { get; set; }
        public User UserCurrent { get; set; }
        public UserPostControl(Post post, User userSelected)
        {
            Post = post;
            UserCurrent = userSelected;
            InitializeComponent();
            ProfilImage.ImageSource = Post.UserPost.Profil;
            UserName.Text = Post.UserPost.Name + " " + Post.UserPost.LastName;
            LikeImage.ImageSource = App.Current.stickers[1].StickerImage;
            LoveImage.ImageSource = App.Current.stickers[2].StickerImage;
            SadImage.ImageSource = App.Current.stickers[3].StickerImage;
            AngryImage.ImageSource = App.Current.stickers[0].StickerImage;
            PostImage.Source = Post.PostImage;
            TitleText.Text = Post.Title;
            DateText.Text = Post.DateTime.ToString();
            Description.Text = Post.Description;
            foreach (var reaction in Post.Reactions)
            {
              if(reaction.Key == userSelected.Id)
              {
                UpdateReaction(reaction.Value, 0);    
              }
            }
            
        }
        private void UpdateReaction(Post.Reaction reaction, int selection)
        {
            if (selection == 0)
            {
                switch (reaction)
                {
                    case Post.Reaction.Like:
                        ButtonLike.Background = new SolidColorBrush(Colors.LightBlue);
                        NbLike.Text = Post.NbLike.ToString();
                        break;
                    case Post.Reaction.Love:
                        ButtonLove.Background = new SolidColorBrush(Colors.LightBlue);
                        NbLove.Text = Post.NbLove.ToString();
                        break;
                    case Post.Reaction.Sad:
                        ButtonSad.Background = new SolidColorBrush(Colors.LightBlue);
                        NbSad.Text = Post.NbSad.ToString();
                        break;
                    case Post.Reaction.Angry:
                        ButtonAngry.Background = new SolidColorBrush(Colors.LightBlue);
                        NbAngry.Text = Post.NbAngry.ToString();
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
                        ButtonLike.Background = new SolidColorBrush(Colors.Gray);
                        NbLike.Text = Post.NbLike.ToString();
                        break;
                    case Post.Reaction.Love:
                        ButtonLove.Background = new SolidColorBrush(Colors.Gray);
                        NbLove.Text = Post.NbLove.ToString();
                        break;
                    case Post.Reaction.Sad:
                        ButtonSad.Background = new SolidColorBrush(Colors.Gray);
                        NbSad.Text = Post.NbSad.ToString();
                        break;
                    case Post.Reaction.Angry:
                        ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
                        NbAngry.Text = Post.NbAngry.ToString();
                        break;
                    default:
                        break;
                }
            }


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var source = e.OriginalSource as FrameworkElement;
            switch (source.Name)
            {
                case "ButtonLike":
                    if(Post.Reactions.Contains(UserCurrent.Id, Post.Reaction.Like))
                    Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Like);
                    UpdateReaction(Post.Reaction.Like, 0);
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
