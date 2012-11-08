using CollectionJson.Infrastructure;
using CollectionJson.Models;
using CollectionJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace CollectionJson.Controllers
{
    public class FriendsController : ApiController
    {
        private IFriendRepository repo;
        private ICollectionJsonDocumentBuilder builder;

        public FriendsController(IFriendRepository repo, ICollectionJsonDocumentBuilder builder)
        {
            this.repo = repo;
            this.builder = builder;
        }

        public Document Get()
        {
            var friends = repo.GetAll();
            return builder.Build(friends);
        }

        public Document Get(int id)
        {
            var friend = repo.Get(id);
            return builder.Build(new List<Friend> { friend });
        }
    }
}
