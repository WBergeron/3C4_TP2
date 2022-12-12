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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Les couleurs de rareter
        // 9b06f1 purpe
        // fb9f07 gold
        Character CharacterSelected { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Filter.SelectedIndex = 0;
            CharacterChanged();
        }
        public void CharacterChanged()
        {
            WrapPanelCharacter.Children.Clear();
            foreach (var character in App.Current.Characters.Values)
            {
                WrapPanelCharacter.Children.Add(new Card(character, this));

            }
            if (CharacterSelected == null)
            {
                BackgroundChanged(App.Current.Characters.FirstOrDefault(x => x.Value.Id == 0).Value);
            }
            else
            {
                BackgroundChanged(CharacterSelected);
            }
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ComboBoxItem)Filter.SelectedItem).Content.ToString())
            {
                case "Level":
                    App.Current.Characters = App.Current.Characters.OrderByDescending(x => x.Value.Level).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case "Rarity":
                    App.Current.Characters = App.Current.Characters.OrderBy(x => x.Value.Rarity).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case "Element":
                    App.Current.Characters = App.Current.Characters.OrderBy(x => x.Value.Element).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case "Weapon":
                    App.Current.Characters = App.Current.Characters.OrderBy(x => x.Value.Weapon).ToDictionary(x => x.Key, x => x.Value);
                    break;
                default:
                    break;
            }
            CharacterChanged();
        }
        public void BackgroundChanged(Character character)
        {
            CharacterSelected = character;
            background.Source = App.Current.Backgrounds.FirstOrDefault(x => x.Value.Id == character.Id).Value.CharacterBackgroundImage;
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (CharacterSelected != null && App.Current.Characters.ContainsKey(CharacterSelected.Id))
            {
                var result = MessageBox.Show("Voulez-vous supprimer " + CharacterSelected.Name, "Supprimer personnage", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (App.Current.Characters.Count != 0 && result == MessageBoxResult.Yes)
                {
                    App.Current.Characters.Remove(CharacterSelected.Id);
                    if (App.Current.Characters.Count != 0)
                    {
                        CharacterSelected = App.Current.Characters.First().Value;
                    }
                    else
                    {
                        MessageBox.Show("Il y a plus de personnage", "Supprimer personnage", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                CharacterChanged();
            }
        }
    }
}
