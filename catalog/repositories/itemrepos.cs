using System;
using System.Collections.Generic;
using catalog.entities;

namespace catalog.repositories

{
     public interface itemrepos
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}
