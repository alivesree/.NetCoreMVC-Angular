using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Numr.Business.Entities
{
    [Table("customer", Schema = "public")]
	public class Customer 
	{
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }


        public string Address { get; set; }

        public string Address_Details { get; set; }
    }
}
