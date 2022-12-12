using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C4_TP2_Partie2.Classes
{
    public class Character
    {
        public enum weapon
        {
            Sword,
            Claymore,
            Bow,
            Polearm,
            Catalyst,
        }
        public enum element
        {
            Anemo,
            Geo,
            Hydro,
            Pyro,
            Dendro,
            Electro,
            Cryo
        }
        public enum rarity
        {
            Gold,
            Purple
        }
        public int Id { get; set; }
        public int IdCharacterIcon { get; set; }

        public string Name { get; set; }
        public int Level { get; set; }

        public rarity Rarity { get; set; }
        public element Element { get; set; }
        public weapon Weapon { get; set; }

        public CharacterIcon? CharacterIcon => App.Current.CharacterIcons.Values.FirstOrDefault(x => x.Id == IdCharacterIcon);
        public ElementIcon? ElementIcon => App.Current.ElementIcons.Values.FirstOrDefault(x => x.IdElement == Element && x.IdRarity == Rarity);

        public CharacterBackground? Background => App.Current.Backgrounds.Values.FirstOrDefault(x => x.Id == Id);

        
    }
}
