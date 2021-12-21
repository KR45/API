using System;
using System.Collections.Generic;
using System.Linq;
using catalog.entities;

namespace catalog.repositories
{
    public class inmemitemsrep : itemrepos //making interface instead of making everytime new object
    {
        private readonly List<Item> items = new()
        {
            new Item {Id= Guid.NewGuid(), Name="Potion", Price= 10, CreatedDate=DateTimeOffset.UtcNow},
            new Item {Id= Guid.NewGuid(), Name="Arm", Price= 20, CreatedDate=DateTimeOffset.UtcNow},
            new Item {Id= Guid.NewGuid(), Name="Duck", Price= 30, CreatedDate=DateTimeOffset.UtcNow},
            new Item {Id= Guid.NewGuid(), Name="Iron", Price= 40, CreatedDate=DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return  items.Where(item => item.Id == id).SingleOrDefault();
        }

    }
}
