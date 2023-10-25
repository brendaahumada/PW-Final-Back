using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PW_Final_Backend.Entities
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public string name { get; set; }
        public string? email { get; set; }
        public long celularNumber { get; set; }

        [ForeignKey("Userid")]
        //public User user { get; set; }
        public int Userid { get; set; }

        public Location location { get; set; }
    }
}
