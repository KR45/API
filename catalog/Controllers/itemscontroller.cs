using System;
using System.Collections.Generic;
using catalog.entities;
using catalog.repositories;
using Microsoft.AspNetCore.Mvc;

namespace catalog.Controllers
{
     //GET/Items

    [ApiController]
    [Route("[[items]]")]
    public class itemscontroller : ControllerBase
    {
        private readonly itemrepos repositories; //items interface 

        public itemscontroller(itemrepos repositories)
        {
            this.repositories = repositories;//pointing towards the already made class and interface
        }


        [HttpGet]

        public IEnumerable<Item> GetItems()
        {
            var items = repositories.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item= repositories.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
