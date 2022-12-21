using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
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
        public int option { get; set; }
        public MockupWindow()
        {
            InitializeComponent();

            option = 0;
            randomButton.Click += RandomButton_Click;
            armeButton.Click += ArmeButton_Click;
            armureButton.Click += ArmureButton_Click;
            nouritureButton.Click += NouritureButton_Click;
            potionButton.Click += PotionButton_Click;

            AffichageObjet(option);
        }

        

        public void AffichageObjet(int optionDeTri)
        {
            ContentObjet.Children.Clear();

            IEnumerable<Objet> triObjet = App.Current.Inventaire.Values;

            switch (optionDeTri)
            {
                case 0:
                    triObjet = triObjet.OrderBy(x => x.Name);
                    break;
                case 1:
                    triObjet = triObjet.OrderBy(x => x.Name)
                                        .OfType<Arme>();
                    break;
                case 2:
                    triObjet = triObjet.OrderBy(x => x.Name)
                                        .OfType<Armure>();
                    break;
                case 3:
                    triObjet = triObjet.OrderBy(x => x.Name)
                                        .OfType<Nouriture>();
                    break;
                case 4:
                    triObjet = triObjet.OrderBy(x => x.Name)
                                        .OfType<Potion>();
                    break;
                default:
                    break;
            }
            foreach (var item in triObjet)
            {
                var objetUserControl = new ObjetUserControl(item);
                ContentObjet.Children.Add(objetUserControl);
            }
        }

        public void SupprimerObjet(Objet objetASupprimer)
        {
            App.Current.Inventaire.Remove(objetASupprimer.Id);
        }

        private void PotionButton_Click(object sender, RoutedEventArgs e)
        {
            option = 4;
            AffichageObjet(option);
        }

        private void NouritureButton_Click(object sender, RoutedEventArgs e)
        {
            option = 3;
            AffichageObjet(option);
        }

        private void ArmureButton_Click(object sender, RoutedEventArgs e)
        {
            option = 2;
            AffichageObjet(option);
        }

        private void ArmeButton_Click(object sender, RoutedEventArgs e)
        {
            option = 1;
            AffichageObjet(option);
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            option = 0;
            AffichageObjet(option);
        }
    }
}
