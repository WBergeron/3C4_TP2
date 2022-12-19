using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TP2.Classes
{
    internal class Group
    {
        public int Id { get; set; }
        public User CreaterUser { get; set; }

        public User AdminUser { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SourceImage { get; set; }

        public Wall Wall { get; set; }


        public BitmapImage GroupeImage => new BitmapImage(App.GetUri(SourceImage));

        public List<int> ListIdUser = new();

        public void PromoteAdmin(User userCurrent)
        {
            bool useradmin = ListIdUser.Any(x => x == userCurrent.Id);
            if (useradmin)
            {
                AdminUser = userCurrent;
            }
        }

        public void CreateEvent(User user)
        {
            if (user == AdminUser)
            {
               new Event();
            }
        }
        public List<User> ListUsersGroup => App.Current.Users.Values.Where(x => ListIdUser.Contains(x.Id)).ToList();


    }
}
