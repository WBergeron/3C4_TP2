using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Classes
{
    internal class Post
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
        public int Id { get; set; }
        public bool IsRead { get; set; }
        public int IdUserPost { get; set; }
        public Access GetAccess { get; set; }

        public List<Reaction> Reactions = new();
     
    }
}
