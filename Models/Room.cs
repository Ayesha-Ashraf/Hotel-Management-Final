using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_Final.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Room_No { get; set; }
        [Required]
        public string floor_No { get; set; }

        [ForeignKey("Hotel_Customer")]
        public int CustomerId { get; set; }
        public virtual Customer hotel_Customer { get; set; }
        [ForeignKey("Hotel_A")]
        public int Hotel_Id { get; set; }
        public virtual Hotel Hotel_A { get; set; }

    }
}
