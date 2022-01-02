using catalog.Dto;
using catalog.entities;
namespace catalog
{
    public static class extensions{
        public static itemDto AsDto(this Item item)
        {
            return new itemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate

            };

        }
    }
}