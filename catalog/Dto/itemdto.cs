//for data transfer object 
//hiding direct interface of items using this from clients

using System;

namespace catalog.Dto
{
    public record itemDto
    {

        public Guid Id{get; init; }

        public string Name {get; set;}

        public decimal Price {get; init;}

        public DateTimeOffset CreatedDate{get; init;}

    }
}