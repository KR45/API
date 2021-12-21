//Edited on 21/12/21 KR

//Made interface for the repositories for already made object 


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
