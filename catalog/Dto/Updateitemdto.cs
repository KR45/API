// helps to modify already stored values
using System.ComponentModel.DataAnnotations;

namespace catalog.Dto


{

    public record Updateitemdto
    {
        [Required] // helps as to prevent from taking null values
        public string Name {get; set;} //create item dto and take item string to be entered 


        [Required]
        [Range(1,1000)] // prevent from taking negative value
        public decimal Price {get; init;} //create item dto , as both of things can't be generated at server side .

    }



}