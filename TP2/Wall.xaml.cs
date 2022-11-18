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
            UserChanged();
        }
        public void InitializeComboBox()
        {
            ComboBoxUser.Items.Clear();

            foreach (var user in App.Current.Users)
            {
                ComboBoxUser.Items.Add(user.Value);
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
            var userProfilControl = new UserProfilControl(userCurrent);
            StackPanelUser.Children.Add(new UserProfilControl(userCurrent));
        }
    }
}
