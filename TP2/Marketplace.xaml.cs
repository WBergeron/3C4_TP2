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
        enum SortBy
        {
            None = -1,

            Date,
            Price,
        }
        public Marketplace()
        {
            // Initialisation
            InitializeComponent();
            InitializeComboBox();

            var radioButtonSelected = RadioButtonIsTrue();

            // Event de recherche
            if (SearchButton.IsPressed)
            {
                radioButtonSelected = RadioButtonIsTrue();


            }
            AffichageWrapPanelContent(radioButtonSelected);
        }

        private SortBy RadioButtonIsTrue()
        {
            if (DateRadio.IsChecked.Value)
            {
                return SortBy.Date;
            }
            if (PriceRadio.IsChecked.Value)
            {
                return SortBy.Price;
            }
            return SortBy.None;
        }

        private void AffichageWrapPanelContent(SortBy radioButtonSelected)
        {
            ContentOffer.Children.Clear();
            switch (Category.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    foreach (var item in App.Current.Offers)
                    {
                        if (radioButtonSelected == SortBy.Date)
                        {
                            
                        }
                        if (radioButtonSelected == SortBy.Price)
                        {
                            
                        }
                        if (radioButtonSelected == SortBy.None)
                        {
                            
                        }
                        var offerUserControl = new UserMarketControl(item.Value);
                        ContentOffer.Children.Add(offerUserControl);
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void InitializeComboBox()
        {
            // Category ComboBox
            Category.Items.Clear();
            foreach (var item in App.Current.Category)
            {
                Category.Items.Add(item);
            }
            Category.SelectedIndex = 1;

            // Maker ComboBox
            MakerComboBox.Items.Clear();
            foreach (var item in App.Current.Maker)
            {
                MakerComboBox.Items.Add(item);
            }
            MakerComboBox.SelectedIndex = 0;

            // Brand ComboBox
            BrandComboBox.Items.Clear();
            foreach (var item in App.Current.Brand)
            {
                BrandComboBox.Items.Add(item);
            }
            BrandComboBox.SelectedIndex = 0;
        }
    }
}
