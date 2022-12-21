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

namespace William_TP2_Partie2
{
    /// <summary>
    /// Logique d'interaction pour Objet.xaml
    /// </summary>
    /// 
    public partial class ObjetUserControl : UserControl
    { 
        public Objet CarteObjet { get; set; } 

        public ObjetUserControl()
        {
            InitializeComponent();
        }

        public ObjetUserControl(Objet objet)
        {
            InitializeComponent();

            if (buttonObjet.IsMouseOver)
            {
                buttonObjet.Background = new LinearGradientBrush(Colors.LightBlue, Colors.BlueViolet, 180);
            }

            buttonObjet.Click += ButtonObjet_Click;

            CarteObjet = objet;
            Image.Source = objet.ImageObjet;
            if (objet.Name.Length <= 18)
            {
                Nom.Text = objet.Name;
            }
            else
            {
                Nom.Text = objet.Name.Substring(0, 18) + "...";
            }
            Niveau.Text = objet.Niveau.ToString();
        }

        private void ButtonObjet_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment jeter '" + CarteObjet.Name + "' de votre inventaire?", "Delete objet", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                var w = new MockupWindow();
                w.SupprimerObjet(CarteObjet);
            }
        }
    }
}
