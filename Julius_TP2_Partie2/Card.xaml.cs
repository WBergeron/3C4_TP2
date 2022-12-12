using _3C4_TP2_Partie2.Classes;
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

namespace _3C4_TP2_Partie2
{
    /// <summary>
    /// Logique d'interaction pour Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public Character CardCharacter { get; set; }
        public MainWindow WindowMain { get; set; }

        public Card(Character character, MainWindow mainWindow)
        {
            CardCharacter = character;
            WindowMain = mainWindow;
            InitializeComponent();
            ElementImage.ImageSource = character.ElementIcon.ElementImage;
            CharacterImage.Source = character.CharacterIcon.CharacterImage;
            Level.Text = "Level " + character.Level.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowMain.BackgroundChanged(CardCharacter);
        }
    }
}
