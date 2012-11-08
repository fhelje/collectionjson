using System;
namespace CollectionJson.Infrastructure
{
    public interface ICollectionJsonDocumentBuilder
    {
        CollectionJson.Document Build(System.Collections.Generic.IEnumerable<CollectionJson.Models.Friend> friends);
    }
}
