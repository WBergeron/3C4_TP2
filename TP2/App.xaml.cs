using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TP2.Classes;

namespace TP2
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

        public Dictionary<int, User> Users = new()
        {
            { 0, new User() { Id = 0, Name = "Tom", LastName = "Richards", SourceProfil="/Assets/Users/user1.jpg" } },
            { 1, new User() { Id = 1, Name = "Elliot", LastName = "Hart", SourceProfil="/Assets/Users/user2.jpg"} },
            { 2, new User() { Id = 2, Name = "Rachel", LastName = "Chapman", SourceProfil="/Assets/Users/user3.jpg"} },
            { 3, new User() { Id = 3, Name = "Myriam", LastName = "Leblanc", SourceProfil="/Assets/Users/user4.jpg"} },
            { 4, new User() { Id = 4, Name = "Paul", LastName = "Burnham", SourceProfil="/Assets/Users/user5.jpg"} },
        };
        public Dictionary<int, Friend> Friends = new()
        {
            { 0, new Friend() { UserSend = Current.Users[0], UserReceived = Current.Users[1] } },
            { 1, new Friend() { UserSend = Current.Users[0], UserReceived = Current.Users[2]} },
            { 2, new Friend() { UserSend = Current.Users[0], UserReceived = Current.Users[3]} },
            { 3, new Friend() { UserSend = Current.Users[1], UserReceived = Current.Users[2]} },
            { 4, new Friend() { UserSend = Current.Users[2], UserReceived = Current.Users[3]} },
        };
    }
}
