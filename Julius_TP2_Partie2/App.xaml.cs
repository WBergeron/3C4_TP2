using _3C4_TP2_Partie2.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _3C4_TP2_Partie2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return Application.Current as App; } }

        public static readonly string ApplicationBaseUri = "pack://application:,,,/Julius_TP2_Partie2;component";
        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }
        public Dictionary<int, Character> Characters = new()
        {
            { 0, new Character() { Id = 0, IdCharacterIcon = 0, Name = "Hu Tao", Level = 90, Rarity = Character.rarity.Gold, Element = Character.element.Pyro, Weapon = Character.weapon.Polearm } },
            { 1, new Character() { Id = 1, IdCharacterIcon = 1, Name = "Faruzan", Level = 56, Rarity = Character.rarity.Purple, Element = Character.element.Anemo, Weapon = Character.weapon.Catalyst } },
            { 2, new Character() { Id = 2, IdCharacterIcon = 2, Name = "Kamisato Ayaka", Level = 40, Rarity = Character.rarity.Gold, Element = Character.element.Cryo, Weapon = Character.weapon.Sword } },
            { 3, new Character() { Id = 3, IdCharacterIcon = 3, Name = "Mona", Level = 12, Rarity = Character.rarity.Gold, Element = Character.element.Hydro, Weapon = Character.weapon.Catalyst } },
            { 4, new Character() { Id = 4, IdCharacterIcon = 4, Name = "Sucrose", Level = 90, Rarity = Character.rarity.Purple, Element = Character.element.Anemo, Weapon = Character.weapon.Catalyst } },
            { 5, new Character() { Id = 5, IdCharacterIcon = 5, Name = "Tighnari", Level = 60, Rarity = Character.rarity.Gold, Element = Character.element.Dendro, Weapon = Character.weapon.Bow } },
            { 6, new Character() { Id = 6, IdCharacterIcon = 6, Name = "Xiao", Level = 90, Rarity = Character.rarity.Gold, Element = Character.element.Anemo, Weapon = Character.weapon.Polearm } },
            { 7, new Character() { Id = 7, IdCharacterIcon = 7, Name = "Xingqui", Level = 10, Rarity = Character.rarity.Purple, Element = Character.element.Hydro,Weapon = Character.weapon.Sword } },
            { 8, new Character() { Id = 8, IdCharacterIcon = 8, Name = "Yae Miko", Level = 90, Rarity = Character.rarity.Gold, Element = Character.element.Electro, Weapon = Character.weapon.Catalyst } },
        };
        public Dictionary<int, CharacterIcon> CharacterIcons = new()
        {
            { 0, new CharacterIcon() {  Id = 0, Source = "/Assets/Characters/Character_Hu_Tao.jpg"} },
            { 1, new CharacterIcon() {  Id = 1, Source = "/Assets/Characters/Character_Faruzan.jpg"} },
            { 2, new CharacterIcon() {  Id = 2, Source = "/Assets/Characters/Character_Kamisato_Ayaka.jpg"} },
            { 3, new CharacterIcon() {  Id = 3, Source = "/Assets/Characters/Character_Mona.jpg"} },
            { 4, new CharacterIcon() {  Id = 4, Source = "/Assets/Characters/Character_Sucrose.jpg"} },
            { 5, new CharacterIcon() {  Id = 5, Source = "/Assets/Characters/Character_Tighnari.jpg"} },
            { 6, new CharacterIcon() {  Id = 6, Source = "/Assets/Characters/Character_Xiao.jpg"} },
            { 7, new CharacterIcon() {  Id = 7, Source = "/Assets/Characters/Character_Xingqiu.jpg"} },
            { 8, new CharacterIcon() {  Id = 8, Source = "/Assets/Characters/Character_Yae_Miko.jpg"} }
        };
        public Dictionary<int, ElementIcon> ElementIcons = new()
        {
            { 0, new ElementIcon() { IdElement = Character.element.Geo, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Geo_Gold.jpg"} },
            { 1, new ElementIcon() { IdElement = Character.element.Geo, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Geo_Purpe.jpg"} },
            { 2, new ElementIcon() { IdElement = Character.element.Hydro, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Hydro_Gold.jpg"} },
            { 3, new ElementIcon() { IdElement = Character.element.Hydro, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Hydro_Purpe.jpg"} },
            { 4, new ElementIcon() { IdElement = Character.element.Pyro, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Pyro_Gold.jpg"} },
            { 5, new ElementIcon() { IdElement = Character.element.Pyro, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Pyro_Purpe.jpg"} },
            { 6, new ElementIcon() { IdElement = Character.element.Cryo, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Cryo_Gold.jpg"} },
            { 7, new ElementIcon() { IdElement = Character.element.Cryo, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Cryo_Purpe.jpg"} },
            { 8, new ElementIcon() { IdElement = Character.element.Dendro, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Dendro_Gold.jpg"} },
            { 9, new ElementIcon() { IdElement = Character.element.Dendro, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Dendro_Purpe.jpg"} },
            { 10, new ElementIcon() { IdElement = Character.element.Anemo, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Anemo_Gold.jpg"} },
            { 11, new ElementIcon() { IdElement = Character.element.Anemo, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Anemo_Purpe.jpg"} },
            { 12, new ElementIcon() { IdElement = Character.element.Electro, IdRarity = Character.rarity.Gold, Source = "/Assets/Elements/Element_Electro_Gold.jpg"} },
            { 13, new ElementIcon() { IdElement = Character.element.Electro, IdRarity = Character.rarity.Purple, Source = "/Assets/Elements/Element_Electro_Purpe.jpg"} },
        };
        public Dictionary<int, CharacterBackground> Backgrounds = new()
        {
            { 0, new CharacterBackground() { Id = 0, Source = "/Assets/Backgrounds/Namecard_Background_Hu_Tao.jpg"} },
            { 1, new CharacterBackground() { Id = 1, Source = "/Assets/Backgrounds/Namecard_Background_Faruzan.jpg"} },
            { 2, new CharacterBackground() { Id = 2, Source = "/Assets/Backgrounds/Namecard_Background_Kamisato_Ayaka.jpg"} },
            { 3, new CharacterBackground() { Id = 3, Source = "/Assets/Backgrounds/Namecard_Background_Mona.jpg"} },
            { 4, new CharacterBackground() { Id = 4, Source = "/Assets/Backgrounds/Namecard_Background_Sucrose.jpg"} },
            { 5, new CharacterBackground() { Id = 5, Source = "/Assets/Backgrounds/Namecard_Background_Tighnari.jpg"} },
            { 6, new CharacterBackground() { Id = 6, Source = "/Assets/Backgrounds/Namecard_Background_Xiao.jpg"} },
            { 7, new CharacterBackground() { Id = 7, Source = "/Assets/Backgrounds/Namecard_Background_Xingqiu.jpg"} },
            { 8, new CharacterBackground() { Id = 8, Source = "/Assets/Backgrounds/Namecard_Background_Yae_Miko.jpg"} },
        };
    }
}
