using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class VillaNumber
    {
        // we don't want villa numbers to be created by Database instead users and should be unique
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }
        
        [ForeignKey("Villa")]
        public int VillaID { get; set; }
        public Villa Villa { get; set; }

        public string SpecialDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
