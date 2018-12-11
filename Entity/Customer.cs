using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Numr.Business.Entities
{
[Table("student", Schema = "public")]
	public class Customer 
		{
			[Key]
			[Column("id")]
			public int Id { get; set; }
			[Column("name")]
			public string Name { get; set; }
		}
}
