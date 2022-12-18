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

        public static readonly string ApplicationBaseUri = "pack://application:,,,/TP2;component";

        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }

        public Dictionary<int, Objet> Inventaire = new()
        {
            { 0, new Armure() { Id = 0, Name = "Plastron de cuir", Description="Armure de cuir simple", Niveau=1, classeArmure=1, partieDuCorps="Tronc", Source="/Assets/ArmureCuir.png" } },
            { 1, new Armure() { Id = 1, Name = "Jambière de cuir", Description="Armure de cuir simple", Niveau=1, classeArmure=1, partieDuCorps="Jambes", Source="/Assets/Jambière.png" } },
        };

    }
}
