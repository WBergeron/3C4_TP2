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
    /// Logique d'interaction pour Marketplace.xaml
    /// </summary>
    public partial class Marketplace : Window
    {
        public Marketplace()
        {
            InitializeComponent();

            InitializeComboBox();
            AffichageWrapPanelContent();
        }

        public void AffichageWrapPanelContent()
        {
            ContentOffer.Children.Clear();
            switch (Category.SelectedIndex)
            {
                case 1:
                    foreach (var item in App.Current.Offers.Values)
                    {
                        var offerUserControl = new UserMarketControl(item);
                        ContentOffer.Children.Add(offerUserControl);
                    }
                    break;
                default:
                    break;
            }
        }

        private void InitializeComboBox()
        {
            Category.Items.Clear();
            foreach (var item in App.Current.Category)
            {
                Category.Items.Add(item);
            }
            Category.SelectedIndex = 1;
        }
    }
}
