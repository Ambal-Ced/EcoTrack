using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoTrack.Models
{
    public class waterrates

    {
        [ForeignKey("ids")]
        public int ids { get; set; }
        public decimal cbrate { get; set; }
        public decimal totbillwater { get; set; }
        public string dates2 { get; set; }
        [Key]
        public int sepb {  get; set; }
    }
}
