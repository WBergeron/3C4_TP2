using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TP2.Classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour Wall.xaml
    /// </summary>
    public partial class Wall : Window
    {
        public bool Popularity { get; set; }
        public Wall()
        {
            InitializeComponent();
            InitializeComboBox();
            ComboBoxUser.SelectedIndex = 0;
            ComboBoxPost.SelectedIndex = 0;
            UserChanged();
            RadioButtonDate.IsChecked = true;
            PostChanged();


        }
        public void InitializeComboBox()
        {
            ComboBoxUser.Items.Clear();
            ComboBoxPost.Items.Clear();
            foreach (var user in App.Current.Users)
            {
                ComboBoxUser.Items.Add(user.Value);
            }
            ComboBoxPost.Items.Add("All users");
            ComboBoxPost.Items.Add("Friends");
            foreach (var user in App.Current.Users)
            {
                ComboBoxPost.Items.Add(user.Value);
            }

        }
        private void ComboBoxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserChanged();
        }
        private void ComboBoxPost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PostChanged();
        }
        private void UserChanged()
        {
            StackPanelUser.Children.Clear();
            var userSelect = (User)ComboBoxUser.SelectedItem;
            var userCurrent = App.Current.Users.Where(x => x.Value == userSelect).First().Value;
            StackPanelUser.Children.Add(new UserProfilControl(userCurrent));
            PostChanged();
        }
        private void PostChanged()
        {
            var userSelect = (User)ComboBoxUser.SelectedItem;
            var userCurrent = App.Current.Users.Where(x => x.Value == userSelect).First().Value;
            StackPanelPost.Children.Clear();
            foreach(var post in App.Current.Posts.Values)
            {
                if(ComboBoxPost.SelectedItem == "All users") 
                {
                    if (post.GiveAccess == Post.Access.Public || post.UserPost == userCurrent)
                    {
                        StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                    }
                    foreach (var friend in App.Current.Friends.Values)
                    {
                        if (userCurrent.Id == friend.IdSend)
                        {
                            if (post.UserPost.Id == friend.IdReceived)
                            {
                                if (post.GiveAccess == Post.Access.FriendsOnly)
                                {
                                    StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                }
                                else if (post.GiveAccess == Post.Access.FriendsExcept)
                                {
                                    if (!post.IdUserAccess.Contains(userCurrent.Id))
                                    {
                                        StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                    }
                                }
                                else if (post.GiveAccess == Post.Access.SpecificFriends)
                                {
                                    if (post.IdUserAccess.Contains(userCurrent.Id))
                                    {
                                        StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                    }
                                }
                            }

                        }

                    }
                }
                else if(ComboBoxPost.SelectedItem == "Friends")
                {
                    foreach( var friend in App.Current.Friends.Values)
                    {
                        if(userCurrent.Id == friend.IdSend)
                        {
                            if (post.UserPost.Id == friend.IdReceived)
                            {
                                if(post.GiveAccess == Post.Access.Public)
                                {
                                    StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                }
                                if (post.GiveAccess == Post.Access.FriendsOnly)
                                {
                                    StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                }
                                else if (post.GiveAccess == Post.Access.FriendsExcept)
                                {
                                    if (!post.IdUserAccess.Contains(userCurrent.Id))
                                    {
                                        StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                    }
                                }
                                else if (post.GiveAccess == Post.Access.SpecificFriends)
                                {
                                    if (post.IdUserAccess.Contains(userCurrent.Id))
                                    {
                                        StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                                    }
                                }
                            }

                        }

                    }

                }
                else
                {
                    if(post.UserPost == ComboBoxPost.SelectedItem)
                    {
                        if (post.GiveAccess == Post.Access.Public)
                        {
                            StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                        }else if(post.GiveAccess == Post.Access.FriendsOnly)
                        {
                            StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                        }
                        else if (post.GiveAccess == Post.Access.FriendsExcept)
                        {
                            if (!post.IdUserAccess.Contains(userCurrent.Id))
                            {
                                StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                            }
                        }
                        if (post.GiveAccess == Post.Access.OnlyMe)
                        {
                            if (post.UserPost == userCurrent)
                            {
                                StackPanelPost.Children.Add(new UserPostControl(post, userCurrent));
                            }
                        }
                    }

                }



            }
        }

        private void RadioButtonDate_Checked(object sender, RoutedEventArgs e)
        {
           App.Current.Posts = App.Current.Posts.OrderByDescending(x => x.Value.DateTime).ToDictionary(x => x.Key, x => x.Value);
           PostChanged();
        }

        public void RadioButtonPopularity_Checked(object sender, RoutedEventArgs e)
        {
           App.Current.Posts = App.Current.Posts.OrderByDescending(x => x.Value.PopularityScore).ToDictionary(x => x.Key, x => x.Value);
           Popularity = true;
           PostChanged();
        }

        public void UpdateWall()
        {
            if (UserPostControl.MouseLeftButtonDownEvent.Equals(true))
            {
                App.Current.Posts = App.Current.Posts.OrderByDescending(x => x.Value.PopularityScore).ToDictionary(x => x.Key, x => x.Value);
                PostChanged();
            }
        }


    }
}
