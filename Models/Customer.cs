using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_Final.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone_no { get; set; }
        [ForeignKey("Hotel_Room")]

        public List<Room> Rooms { get; set; }
        [ForeignKey("Hotel_A")]
        public int Hotel_Id { get; set; }
        public virtual Hotel Hotel_A { get; set; }



    }
}
