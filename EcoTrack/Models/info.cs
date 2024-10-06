using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace EcoTrack.Models
{
    public class info
    {
        [Key]
        public int ids { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string type_ { get; set; }
        public int conto { get; set; }
        public string email { get; set; }
        public string passwords { get; set; }
    }
}
