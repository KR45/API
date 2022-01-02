using System;
using System.Collections.Generic;
using catalog.entities;
using catalog.repositories;
using catalog.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

        public IEnumerable<itemDto> GetItems()
        {
            var items = repositories.GetItems().Select(item => item.AsDto()); // select command is simple projection of file DTO using link
            return items;  

        }

        [HttpGet("{id}")]
        public ActionResult<itemDto> GetItem(Guid id)
        {
            var item= repositories.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return item.AsDto();// if present then it will return the item
        }
    }
}
