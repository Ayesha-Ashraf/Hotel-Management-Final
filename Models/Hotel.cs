using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_Final.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string URl { get; set; }
        [Required]
        public int Price { get; set; }

        public List<Customer> Customers { get; set; }

        public List<Room> Rooms { get; set; }

    }
}
