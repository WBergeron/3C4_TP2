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
using System.Windows.Shapes;
using TP2.Classes;

namespace TP2
{
    /// <summary>
    /// Logique d'interaction pour Wall.xaml
    /// </summary>
    public partial class Wall : Window
    {
        public Wall()
        {
            InitializeComponent();
            RadioButtonDate.IsChecked = true;
            InitializeComboBox();
            ComboBoxUser.SelectedIndex = 0;
            ComboBoxPost.SelectedIndex = 0;
            UserChanged();
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
        private void UserChanged()
        {
            StackPanelUser.Children.Clear();
            var userSelect = (User)ComboBoxUser.SelectedItem;
            var userCurrent = App.Current.Users.Where(x => x.Value == userSelect).First().Value;
            StackPanelUser.Children.Add(new UserProfilControl(userCurrent));
        }
        private void PostChanged()
        {
            StackPanelPost.Children.Clear();
            foreach(var post in App.Current.Posts.Values)
            {
              StackPanelPost.Children.Add(new UserPostControl(post, (User)ComboBoxUser.SelectedItem));
            }

        }

        private void RadioButtonDate_Checked(object sender, RoutedEventArgs e)
        {
           App.Current.Posts.OrderBy(x => x.Value.DateTime);
           PostChanged();
        }

        private void RadioButtonPopularity_Checked(object sender, RoutedEventArgs e)
        {
            App.Current.Posts.OrderBy(x => x.Value.DateTime);
            PostChanged();
        }
    }
}
