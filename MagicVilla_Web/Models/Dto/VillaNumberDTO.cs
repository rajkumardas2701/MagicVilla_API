using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
        // navigation property => need to check but looks like has-many or has one relationship in rails model
        public VillaDTO Villa { get; set; }
    }
}
