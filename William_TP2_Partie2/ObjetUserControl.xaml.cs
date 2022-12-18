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
    public partial class ObjetUserControl : UserControl
    {
        public ObjetUserControl()
        {
            InitializeComponent();
        }

        public ObjetUserControl(Objet objet)
        {
            InitializeComponent();

            Image.Source = objet.ImageObjet;
            Nom.Text = objet.Name;
            Niveau.Text = objet.Niveau.ToString();
        }
    }
}
