using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionJson.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Uri Blog { get; set; }
        public Uri Avatar { get; set; }
    }
}
