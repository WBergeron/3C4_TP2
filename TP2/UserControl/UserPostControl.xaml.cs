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
            Day.Text = (DateTime.Now - Post.DateTime).Days.ToString() + "d";
            PostImage.Source = Post.PostImage;
            TitleText.Text = Post.Title;
            DateText.Text = Post.DateTime.ToString("MMMM") + " " + Post.DateTime.Day.ToString() + " at " + Post.DateTime.ToString("hh:mm");
            Description.Text = Post.Description;
            ButtonLike.Background = new SolidColorBrush(Colors.Gray);
            ButtonLove.Background = new SolidColorBrush(Colors.Gray);
            ButtonSad.Background = new SolidColorBrush(Colors.Gray);
            ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
            UpdateReaction();    
        }
        private void UpdateReaction()
        {
            NbLike.Text = Post.NbLike.ToString();
            NbLove.Text = Post.NbLove.ToString();
            NbSad.Text = Post.NbSad.ToString();
            NbAngry.Text = Post.NbAngry.ToString();
            if (Post.Reactions.ContainsKey(UserCurrent.Id))
            {
                switch (Post.Reactions[UserCurrent.Id])
                {
                    case Post.Reaction.Like:
                        ButtonLike.Background = new SolidColorBrush(Colors.LightBlue);
                        ButtonLove.Background = new SolidColorBrush(Colors.Gray);
                        ButtonSad.Background = new SolidColorBrush(Colors.Gray);
                        ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
                        break;
                    case Post.Reaction.Love:
                        ButtonLove.Background = new SolidColorBrush(Colors.LightBlue);
                        ButtonLike.Background = new SolidColorBrush(Colors.Gray);
                        ButtonSad.Background = new SolidColorBrush(Colors.Gray);
                        ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
                        break;
                    case Post.Reaction.Sad:
                        ButtonSad.Background = new SolidColorBrush(Colors.LightBlue);
                        ButtonLike.Background = new SolidColorBrush(Colors.Gray);
                        ButtonLove.Background = new SolidColorBrush(Colors.Gray);
                        ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
                        break;
                    case Post.Reaction.Angry:
                        ButtonAngry.Background = new SolidColorBrush(Colors.LightBlue);
                        ButtonLike.Background = new SolidColorBrush(Colors.Gray);
                        ButtonLove.Background = new SolidColorBrush(Colors.Gray);
                        ButtonSad.Background = new SolidColorBrush(Colors.Gray);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                ButtonLike.Background = new SolidColorBrush(Colors.Gray);
                ButtonLove.Background = new SolidColorBrush(Colors.Gray);
                ButtonSad.Background = new SolidColorBrush(Colors.Gray);
                ButtonAngry.Background = new SolidColorBrush(Colors.Gray);
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var source = e.OriginalSource as FrameworkElement;
            switch (source.Name)
            {
                case "ButtonLike":
                    if(Post.Reactions.ContainsKey(UserCurrent.Id))
                    {
                        if (Post.Reactions[UserCurrent.Id] == Post.Reaction.Like)
                        {
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.PopularityScore -= 3;
                            break;

                        }
                        if (Post.Reactions[UserCurrent.Id] != Post.Reaction.Like)
                        {
                            removePopularityScore(UserCurrent.Id);
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Like);
                            Post.PopularityScore += 3;

                        }

                    }
                    else
                    {
                        Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Like);
                        Post.PopularityScore += 3;
                    }
                    break;
                case "ButtonLove":
                    if (Post.Reactions.ContainsKey(UserCurrent.Id))
                    {
                        if (Post.Reactions[UserCurrent.Id] == Post.Reaction.Love)
                        {
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.PopularityScore -= 5;
                            break;
                        }
                        if (Post.Reactions[UserCurrent.Id] != Post.Reaction.Love)
                        {
                            removePopularityScore(UserCurrent.Id);
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Love);
                            Post.PopularityScore += 5;

                        }
                    }
                    else
                    {
                        Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Love);
                        Post.PopularityScore += 5;
                    }

                    break;
                case "ButtonSad":
                    if (Post.Reactions.ContainsKey(UserCurrent.Id))
                    {
                        if (Post.Reactions[UserCurrent.Id] == Post.Reaction.Sad)
                        {
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.PopularityScore -= 1;
                            break;
                        }
                        if (Post.Reactions[UserCurrent.Id] != Post.Reaction.Sad)
                        {
                            removePopularityScore(UserCurrent.Id);
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Sad);
                            Post.PopularityScore += 1;

                        }
                    }
                    else
                    {
                        Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Sad);
                        Post.PopularityScore += 1;
                    }
                    break;
                case "ButtonAngry":
                    if (Post.Reactions.ContainsKey(UserCurrent.Id))
                    {
                        if (Post.Reactions[UserCurrent.Id] == Post.Reaction.Angry)
                        {
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.PopularityScore -= 1;
                            break;
                        }
                        if (Post.Reactions[UserCurrent.Id] != Post.Reaction.Angry)
                        {
                            removePopularityScore(UserCurrent.Id);
                            Post.Reactions.Remove(UserCurrent.Id);
                            Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Angry);
                            Post.PopularityScore += 1;

                        }
                    }
                    else
                    {
                        Post.Reactions.Add(UserCurrent.Id, Post.Reaction.Angry);
                        Post.PopularityScore += 1;
                    }
                    break;
                default:
                    break;
            }
            UpdateReaction();
            
        }
        public void removePopularityScore(int id)
        {
            if (Post.Reactions[id] == Post.Reaction.Like)
            {
                Post.PopularityScore -= 3;
            }
            if (Post.Reactions[id] == Post.Reaction.Love)
            {
                Post.PopularityScore -= 5;
            }
            if (Post.Reactions[id] == Post.Reaction.Sad)
            {
                Post.PopularityScore -= 1;
            }
            if (Post.Reactions[id] == Post.Reaction.Angry)
            {
                Post.PopularityScore -= 1;
            }
        }
    }
}
