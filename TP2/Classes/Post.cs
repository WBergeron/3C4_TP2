using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TP2.Classes
{
    public class Post
    {

        public enum Access
        {
            Public,
            FriendsOnly,
            FriendsExcept,
            SpecificFriends,
            OnlyMe,
        }
        public enum Reaction
        {
            Like,
            Love,
            Sad,
            Angry
        }
        public int NbLike { get; set; }
        public int NbLove { get; set; }
        public int NbSad { get; set; }
        public int NbAngry { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsRead { get; set; }
        public int IdUserPost { get; set; }
        public DateTime DateTime { get; set; }
        public string SourcePost { get; set; }
        public User? UserPost => App.Current.Users.Values.FirstOrDefault(x => x.Id == IdUserPost);

        public Access GiveAccess { get; set; }

        public List<int> IdUserAccess = new();

        public Dictionary<int, Reaction> Reactions = new();

        public BitmapImage PostImage => new BitmapImage(App.GetUri(SourcePost));

    }
}
