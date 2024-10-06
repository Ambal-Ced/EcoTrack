using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoTrack.Models
{
    public class electrates
    {
        [ForeignKey("ids")]
        public int ids { get; set; }
        public decimal kwrate { get; set; }
        public decimal totbillelec { get; set; }
        public string dates1 { get; set; }
        [Key]
        public int sepa { get; set; }
    }
}
