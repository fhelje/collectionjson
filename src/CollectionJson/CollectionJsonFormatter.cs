using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;

namespace CollectionJson
{
    public class CollectionJsonFormatter : JsonMediaTypeFormatter
    {
        public CollectionJsonFormatter()
        {
            this.SupportedMediaTypes.Clear();
            this.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.collection+json"));
            this.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            this.SerializerSettings.Formatting = Formatting.Indented;
            this.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver();
        }

        public override bool CanWriteType(Type type)
        {
            return (type == typeof(CollectionJson.Document));
        }

        public override bool CanReadType(Type type)
        {
            return (type == typeof(CollectionJson.Template));
        }
    }
}
