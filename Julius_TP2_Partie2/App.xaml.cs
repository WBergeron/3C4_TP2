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
            { 9, new Character() { Id = 9, IdCharacterIcon = 9, Name = "Yelan", Level = 76, Rarity = Character.rarity.Gold, Element = Character.element.Hydro, Weapon =  Character.weapon.Bow} },
            { 10, new Character() { Id = 10, IdCharacterIcon = 10, Name = "Shenhe", Level = 03, Rarity = Character.rarity.Gold, Element = Character.element.Cryo, Weapon =  Character.weapon.Polearm} },
            { 11, new Character() { Id = 11, IdCharacterIcon = 11, Name = "Eula", Level = 07, Rarity = Character.rarity.Gold, Element = Character.element.Cryo, Weapon =  Character.weapon.Claymore} },
            { 12, new Character() { Id = 12, IdCharacterIcon = 12, Name = "Qiqi", Level = 44, Rarity = Character.rarity.Gold, Element = Character.element.Cryo, Weapon =  Character.weapon.Sword} },
            { 13, new Character() { Id = 13, IdCharacterIcon = 13, Name = "Nilou", Level = 54, Rarity = Character.rarity.Gold, Element = Character.element.Hydro, Weapon =  Character.weapon.Sword} },
            { 14, new Character() { Id = 14, IdCharacterIcon = 14, Name = "Nahida", Level = 23, Rarity = Character.rarity.Gold, Element = Character.element.Dendro, Weapon =  Character.weapon.Catalyst} },
            { 15, new Character() { Id = 15, IdCharacterIcon = 15, Name = "Kujou Sara", Level = 43, Rarity = Character.rarity.Purple, Element = Character.element.Electro, Weapon =  Character.weapon.Bow} },
            { 16, new Character() { Id = 16, IdCharacterIcon = 16, Name = "Klee", Level = 79, Rarity = Character.rarity.Gold, Element = Character.element.Pyro, Weapon =  Character.weapon.Catalyst} },
            { 17, new Character() { Id = 17, IdCharacterIcon = 17, Name = "Keqing", Level = 51, Rarity = Character.rarity.Gold, Element = Character.element.Electro, Weapon =  Character.weapon.Sword} },
            { 18, new Character() { Id = 18, IdCharacterIcon = 18, Name = "Kaedehara Kazuha", Level = 24, Rarity = Character.rarity.Gold, Element = Character.element.Anemo, Weapon =  Character.weapon.Sword} },
            { 19, new Character() { Id = 19, IdCharacterIcon = 19, Name = "Bennett", Level = 15, Rarity = Character.rarity.Purple, Element = Character.element.Pyro, Weapon =  Character.weapon.Sword} },
            { 20, new Character() { Id = 20, IdCharacterIcon = 20, Name = "Raiden Shogun", Level = 12, Rarity = Character.rarity.Gold, Element = Character.element.Electro, Weapon =  Character.weapon.Polearm} },
            { 21, new Character() { Id = 21, IdCharacterIcon = 21, Name = "Rosaria", Level = 01, Rarity = Character.rarity.Purple, Element = Character.element.Cryo, Weapon =  Character.weapon.Polearm} },
            { 22, new Character() { Id = 22, IdCharacterIcon = 22, Name = "Wanderer", Level = 90, Rarity = Character.rarity.Gold, Element = Character.element.Anemo, Weapon =  Character.weapon.Catalyst} }
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
            { 8, new CharacterIcon() {  Id = 8, Source = "/Assets/Characters/Character_Yae_Miko.jpg"} },
            { 9, new CharacterIcon() {  Id = 9, Source = "/Assets/Characters/Character_Yelan.jpg"} },
            { 10, new CharacterIcon() {  Id = 10, Source = "/Assets/Characters/Character_Shenhe.jpg"} },
            { 11, new CharacterIcon() {  Id = 11, Source = "/Assets/Characters/Character_Eula.jpg"} },
            { 12, new CharacterIcon() {  Id = 12, Source = "/Assets/Characters/Character_Qiqi.jpg"} },
            { 13, new CharacterIcon() {  Id = 13, Source = "/Assets/Characters/Character_Nilou.jpg"} },
            { 14, new CharacterIcon() {  Id = 14, Source = "/Assets/Characters/Character_Nahida.jpg"} },
            { 15, new CharacterIcon() {  Id = 15, Source = "/Assets/Characters/Character_Kujou_Sara.jpg"} },
            { 16, new CharacterIcon() {  Id = 16, Source = "/Assets/Characters/Character_Klee.jpg"} },
            { 17, new CharacterIcon() {  Id = 17, Source = "/Assets/Characters/Character_Keqing.jpg"} },
            { 18, new CharacterIcon() {  Id = 18, Source = "/Assets/Characters/Character_Kaedehara_Kazuha.jpg"} },
            { 19, new CharacterIcon() {  Id = 19, Source = "/Assets/Characters/Character_Bennett.jpg"} },
            { 20, new CharacterIcon() {  Id = 20, Source = "/Assets/Characters/Character_Raiden_Shogun.jpg"} },
            { 21, new CharacterIcon() {  Id = 21, Source = "/Assets/Characters/Character_Rosaria.jpg"} },
            { 22, new CharacterIcon() {  Id = 22, Source = "/Assets/Characters/Character_Wanderer.jpg"} }
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
            { 9, new CharacterBackground() { Id = 9, Source = "/Assets/Backgrounds/Namecard_Background_Yelan.jpg"} },
            { 10, new CharacterBackground() { Id = 10, Source = "/Assets/Backgrounds/Namecard_Background_Shenhe.jpg"} },
            { 11, new CharacterBackground() { Id = 11, Source = "/Assets/Backgrounds/Namecard_Background_Eula.jpg"} },
            { 12, new CharacterBackground() { Id = 12, Source = "/Assets/Backgrounds/Namecard_Background_Qiqi.jpg"} },
            { 13, new CharacterBackground() { Id = 13, Source = "/Assets/Backgrounds/Namecard_Background_Nilou.jpg"} },
            { 14, new CharacterBackground() { Id = 14, Source = "/Assets/Backgrounds/Namecard_Background_Nahida.jpg"} },
            { 15, new CharacterBackground() { Id = 15, Source = "/Assets/Backgrounds/Namecard_Background_Kujou_Sara.jpg"} },
            { 16, new CharacterBackground() { Id = 16, Source = "/Assets/Backgrounds/Namecard_Background_Klee.jpg"} },
            { 17, new CharacterBackground() { Id = 17, Source = "/Assets/Backgrounds/Namecard_Background_Keqing.jpg"} },
            { 18, new CharacterBackground() { Id = 18, Source = "/Assets/Backgrounds/Namecard_Background_Kaedehara_Kazuha.jpg"} },
            { 19, new CharacterBackground() { Id = 19, Source = "/Assets/Backgrounds/Namecard_Background_Bennett.jpg"} },
            { 20, new CharacterBackground() { Id = 20, Source = "/Assets/Backgrounds/Namecard_Background_Raiden_Shogun.jpg"} },
            { 21, new CharacterBackground() { Id = 21, Source = "/Assets/Backgrounds/Namecard_Background_Rosaria.jpg"} },
            { 22, new CharacterBackground() { Id = 22, Source = "/Assets/Backgrounds/Namecard_Background_Wanderer.jpg"} }
        };
    }
}
