using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace William_TP2_Partie2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current { get { return Application.Current as App; } }

        public static readonly string ApplicationBaseUri = "pack://application:,,,/William_TP2_Partie2;component";

        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }

        public Dictionary<int, Objet> Inventaire = new()
        {
            { 0, new Armure() { Id = 0, Name = "Plastron de cuir", Description="Armure de cuir simple", Niveau=1, classeArmure=3, partieDuCorps="Tronc", Source="/Assets/armc.jpg" } },
            { 1, new Armure() { Id = 1, Name = "Jambière de cuir", Description="Armure de cuir simple", Niveau=1, classeArmure=2, partieDuCorps="Jambes", Source="/Assets/Jambiere.jpg" } },
            { 5, new Armure() { Id = 5, Name = "Casque des profondeurs", Description="Armure d'obsidienne forgé", Niveau=8, classeArmure=22, partieDuCorps="Tête", Source="/Assets/casque.jpg" } },
            { 2, new Epee() { Id = 2, Name = "Épee de cuivre", Description="Épée clasique", Niveau=1, typeGarde="Légerte", typeLame="Droite à double côté", materiaux= new List<string>(){ "Cuivre", "Cuir"}, enchantement="", niveauEnchantement=0, Source="/Assets/epeeCuivre.jpg" } },
            { 6, new Hallebarde() { Id = 6, Name = "Hallebarde de Crysaline", Description="Hallebarde lourde", Niveau=7, typeHache="Épaisse à double côté", materiaux= new List<string>(){ "Crysaline", "Acier", "Fautre"}, enchantement="Fléau des arthropodes", niveauEnchantement=2, Source="/Assets/hallebarde.jpg" } },
            { 3, new Nouriture() { Id = 3, Name = "Biscuit", Description="Biscuit clasique au chocolat", Niveau=3, effet="Regeneration", pvRegen=10, Source="/Assets/biscuit.jpg" } },
            { 4, new Nouriture() { Id = 4, Name = "Radis", Description="Petit radis sauvage", Niveau=1, effet="Anti-poison", pvRegen=0, Source="/Assets/radis.jpg" } },
            { 7, new Potion() { Id = 7, Name = "Potion de soin", Description="Moyenne potion de soin", Niveau=2, effet="Soin", type=true, pvPositif=10, pvNegatif=0, Source="/Assets/potionsoin.jpg" } },
            { 8, new Potion() { Id = 8, Name = "Potion de poison", Description="Petite potion de poison jetable", Niveau=1, effet="Poison", type=false, pvPositif=0, pvNegatif=10, Source="/Assets/potionpoison.jpg" } },
        };

    }
}
