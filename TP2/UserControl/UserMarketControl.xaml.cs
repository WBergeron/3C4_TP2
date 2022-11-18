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
    /// Logique d'interaction pour UserMarketControl.xaml
    /// </summary>
    public partial class UserMarketControl : UserControl
    {
        public UserMarketControl()
        {
            InitializeComponent();
        }
        public UserMarketControl(Offer offre)
        {
            InitializeComponent();

            OfferImage.Source = offre.ImageOffer;
            Cost.Text = offre.Price.ToString();
            Date.Text = offre.DateDeMiseEnVente.ToShortDateString();
            NameOffer.Text = offre.Titre;
            Descript.Text = offre.Description;
        }
    }
}
