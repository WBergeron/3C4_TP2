using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace William_TP2_Partie2
{
    /// <summary>
    /// Logique d'interaction pour MockupWindow.xaml
    /// Link vers l'image: https://www.aq.com/info/handbook/enhance.asp   
    /// /// </summary>
    public partial class MockupWindow : Window
    {
        public MockupWindow()
        {
            InitializeComponent();

            AffichageObjet();

            // Event de Bouton
            
        }

        private void AffichageObjet()
        {
            IEnumerable<Objet> triObjet = App.Current.Inventaire.Values;

            foreach (var item in triObjet)
            {
                var objetUserControl = new ObjetUserControl(item);
                ContentObjet.Children.Add(objetUserControl);
            }
        }
    }
}
