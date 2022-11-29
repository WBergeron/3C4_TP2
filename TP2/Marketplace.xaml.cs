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
            var radioButtonSelected = RadioButtonIsTrue();
            InitializeComboBox();
            AffichageWrapPanelContent(radioButtonSelected);

            // Event de recherche
            SearchButton.Click += SearchButton_Click;
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var radioButtonSelected = RadioButtonIsTrue();
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
            var triOffer = App.Current.Offers.Values.OrderBy(x => x.Id);
            ContentOffer.Children.Clear();
            switch (ComboBoxCategory.SelectedValue)
            {
                case "Appliances":
                    break;
                case "Cars":
                    if (radioButtonSelected == SortBy.Date)
                    {
                        triOffer = triOffer.OrderBy(x => x.DateDeMiseEnVente);
                    }
                    if (radioButtonSelected == SortBy.Price)
                    {
                        triOffer = triOffer.OrderBy(x => x.Price);
                    }
                    if (!(minPrice.Text == "" || maxPrice.Text == ""))
                    {
                        
                    }
                    

                    foreach (var item in triOffer)
                    {
                        var offerUserControl = new UserMarketControl(item);
                        ContentOffer.Children.Add(offerUserControl);
                    }
                    break;
                case "Property Rentals":
                    break;
                default:
                    break;
            }
        }

        private void InitializeComboBox()
        {
            // Category ComboBox
            ComboBoxCategory.Items.Clear();
            foreach (var item in App.Current.Category)
            {
                ComboBoxCategory.Items.Add(item);
            }
            ComboBoxCategory.SelectedIndex = 1;

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
