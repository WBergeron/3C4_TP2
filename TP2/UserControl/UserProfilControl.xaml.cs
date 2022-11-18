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
    /// Logique d'interaction pour UserProfilControl.xaml
    /// </summary>
    public partial class UserProfilControl : UserControl
    {
        public UserProfilControl()
        {
            InitializeComponent();
        }
        public UserProfilControl(User user)
        {
            InitializeComponent();
            ProfilImage.ImageSource = user.Profil;
            UserName.Text = user.Name + " " + user.LastName;

            foreach (var friend in user.Friends)
            {

            }
        }
    }
}
