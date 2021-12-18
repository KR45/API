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
        private readonly inmemitemsrep repositories;

        public itemscontroller()
        {
            repositories = new inmemitemsrep();
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