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
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsRead { get; set; }
        public int IdUserPost { get; set; }
        public DateTime DateTime { get; set; }
        public string SourcePost { get; set; }

        
        public Access GiveAccess { get; set; }
        public List<int> IdUserAccess { get; set; }

        public Dictionary<int, Reaction> Reactions = new();

        public BitmapImage PostImage => new BitmapImage(App.GetUri(SourcePost));

    }
}
