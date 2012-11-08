using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionJson.Models
{
    public interface IFriendRepository
    {
        IEnumerable<Friend> GetAll();
        Friend Get(int friendId);
        void Add(Friend friend);
    }
}
