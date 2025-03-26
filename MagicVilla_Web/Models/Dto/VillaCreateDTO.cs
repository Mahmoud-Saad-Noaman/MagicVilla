using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    // Used when sending new villa data from the front end to the API.
    public class VillaCreateDTO
    {
        #region Properties

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        
        
        [Required]
        public double Rate { get; set; }

        public int Occupancy { get; set; }

        public int Sqft { get; set; }

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }

        #endregion
    }
}
