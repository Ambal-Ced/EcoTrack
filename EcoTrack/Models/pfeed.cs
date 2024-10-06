using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoTrack.Models
{
    public class pfeed
    {
        [ForeignKey("ids")]
        public int ids { get; set; }
        public string feedbacks {  get; set; }
        [Key] public int fid { get; set; }
    }
}
