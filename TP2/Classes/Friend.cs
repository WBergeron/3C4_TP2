using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Classes
{
    public class Friend
    {
        public int IdSend { get; set; }
        public int IdReceived { get; set; }
        public int FriendRequestResponse { get; set; }
        public int FriendRequestPending { get; set; }

        public User? UserSend => App.Current.Users.Values.FirstOrDefault(x => x.Id == IdSend);
        public User? UserReceived => App.Current.Users.Values.FirstOrDefault(x => x.Id == IdReceived);

        public List<Friend> FriendListOrderOldToNew = new();

        public List<Friend> FriendListOrderName => FriendListOrderOldToNew.OrderBy(x => x.UserReceived.Name).ToList();
        public List<Friend> FriendInCommon(User userCurrent)
        {
            return FriendListOrderOldToNew.Where(x => x.UserReceived.Id == userCurrent.Id).ToList();
        }

    }

    
}
