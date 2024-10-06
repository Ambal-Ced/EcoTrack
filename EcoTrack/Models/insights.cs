using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoTrack.Models
{
    public class insights
    {
        [Key] public int iid { get; set; }
        public string insight {  get; set; }
        [ForeignKey("ids")]
        
        public int ids { get; set; }
    }
}
