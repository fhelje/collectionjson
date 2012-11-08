using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionJson
{
    public class Document
    {
        public Collection Collection { get; set; }
    }

    public class Collection
    {
        public Collection()
        {
            Links = new List<Link>();
            Items = new List<Item>();
            Queries = new List<Query>();
            Template = new Template();
        }

        public string Version { get; set; }
        public Uri Href { get; set; }
        public IList<Link> Links { get; private set; }
        public IList<Item> Items { get; private set; }
        public IList<Query> Queries { get; private set; }
        public Template Template { get; private set; }
    }

    public class Link
    {
        public string Rel { get; set; }
        public Uri Href { get; set; }
        public string Prompt { get; set; }
        public string Render { get; set; }
    }

    public class Data
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Prompt { get; set; }
    }

    public class Item
    {
        public Item()
        {
            Data = new List<Data>();
            Links = new List<Link>();
        }
        
        public Uri Href { get; set; }
        public IList<Data> Data { get; private set; }
        public IList<Link> Links { get; private set; }
    }

    public class Query
    {
        public Query()
        {
            Data = new List<Data>();
        }

        public string Rel { get; set; }
        public Uri Href { get; set; }
        public string Prompt { get; set; }
        public IList<Data> Data {get; private set;}
    }

    public class Template
    {
        public Template()
        {
            Data = new List<Data>();
        }

        public IList<Data> Data { get; private set; }
    }

    public class Error
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }

}
