using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionJson.Models
{
    public class FakeFriendRepository : IFriendRepository
    {
        private static List<Friend> friends = new List<Friend>();

        static FakeFriendRepository()
        {
            friends.Add(new Friend { Id = 1, ShortName = "jdoe", Name = "J. Doe", Email = "jdoe@example.org", Blog = new Uri("http://examples.org/blogs/jdoe"), Avatar = new Uri("http://examples.org/images/jode") });
            friends.Add(new Friend { Id = 2, ShortName = "msmith", Name = "M. Smith", Email = "msmith@example.org", Blog = new Uri("http://examples.org/blogs/msmith"), Avatar = new Uri("http://examples.org/images/msmith") });
            friends.Add(new Friend { Id = 2, ShortName = "rwilliams", Name = "R. Williams", Email = "rwilliams@example.org", Blog = new Uri("http://examples.org/blogs/rwilliams"), Avatar = new Uri("http://examples.org/images/rwilliams") });
        }

        public FakeFriendRepository()
        {
        }

        public IEnumerable<Friend> GetAll()
        {
            return friends;
        }

        public Friend Get(int friendId)
        {
            return friends.FirstOrDefault(f => f.Id == friendId);
        }

        public void Add(Friend friend)
        {
            throw new NotImplementedException();
        }

        static int GetNextId()
        {
            return friends.OrderBy(f => f.Id).Last().Id + 1;
        }
    }
}
