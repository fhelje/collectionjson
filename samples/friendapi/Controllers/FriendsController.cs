using CollectionJson.Infrastructure;
using CollectionJson.Models;
using CollectionJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Net.Http;
using System.Net;

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

        public HttpResponseMessage Get()
        {
            var friends = repo.GetAll();
            return this.Request.CreateResponse(HttpStatusCode.OK, builder.Build(friends));
        }

        public HttpResponseMessage Get(int id)
        {
            var friend = repo.Get(id);
            return this.Request.CreateResponse(HttpStatusCode.OK, builder.Build(new List<Friend> { friend }));
        }

       
        public HttpResponseMessage Put(int id, Template template) {
            var friend = template.ToFriend(id);
            repo.Update(friend);
            return this.Request.CreateResponse(HttpStatusCode.NoContent);
        }

        public HttpResponseMessage Post(Template template)
        {
            var friend = template.ToFriend(0);
            var id = repo.Add(friend);
            var response = this.Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Url.Link("default", new { controller = "Friends", id = id }));
            return response;
        }
        
    }
}
