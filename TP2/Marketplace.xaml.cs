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
            IEnumerable<Car> triOffer = App.Current.Offers.Values.OfType<Car>();
            ContentOffer.Children.Clear();
            int prixMin = 0;
            int prixMax = 999999;
            int anneeMin = 0;
            int anneeMax = 9999;
            int milageMin = 0;
            int milageMax = 9999;

            // Tri si des prix min ou max on été entrer
            if ((minPrice.Text != "") || (maxPrice.Text != ""))
            {
                if (int.TryParse(minPrice.Text, out int intMinPrice))
                {
                    prixMin = intMinPrice;
                }
                if (int.TryParse(maxPrice.Text, out int intMaxPrice))
                {
                    prixMax = intMaxPrice;
                }
            }

            // Tri si des annee min ou max on été entrer
            if ((minAnnee.Text != "") || (maxAnnee.Text != ""))
            {
                if (int.TryParse(minAnnee.Text, out int intMinAnnee))
                {
                    anneeMin = intMinAnnee;
                }
                if (int.TryParse(maxAnnee.Text, out int intMaxAnnee))
                {
                    anneeMax = intMaxAnnee;
                }
            }

            // Tri si des milage min ou max on été entrer
            if ((minMileage.Text != "") || (maxMileage.Text != ""))
            {
                if (int.TryParse(minMileage.Text, out int intMinMilage))
                {
                    milageMin = intMinMilage;
                }
                if (int.TryParse(maxMileage.Text, out int intMaxMilage))
                {
                    milageMax = intMaxMilage;
                }
            }

            switch (ComboBoxCategory.SelectedValue)
            {
                case "Appliances":
                    break;
                case "Cars":
                    if (radioButtonSelected == SortBy.Date)
                    {
                        triOffer = triOffer
                            .OrderByDescending(x => x.DateDeMiseEnVente)
                            .Where(x => x.Price >= prixMin && x.Price <= prixMax)
                            .Where(x => x.Annee.Year >= anneeMin && x.Annee.Year <= anneeMax)
                            .Where(x => x.Odometre >= milageMin && x.Odometre <= milageMax);
                    }
                    if (radioButtonSelected == SortBy.Price)
                    {
                        triOffer = triOffer
                            .OrderBy(x => x.Price)
                            .Where(x => x.Price >= prixMin && x.Price <= prixMax)
                            .Where(x => x.Annee.Year >= anneeMin && x.Annee.Year <= anneeMax)
                            .Where(x => x.Odometre >= milageMin && x.Odometre <= milageMax);
                    }

                    if (!((string)MakerComboBox.SelectedValue == "All"))
                    {
                        triOffer = triOffer.Where(x => x.Marque == (string)MakerComboBox.SelectedValue);
                    }

                    if (!((string)BrandComboBox.SelectedValue == "All"))
                    {
                        triOffer = triOffer.Where(x => x.Fabriquant == (string)BrandComboBox.SelectedValue);
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
