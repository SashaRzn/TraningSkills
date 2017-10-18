using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
	public class Book
	{
		public int BookId { get; set; }

		[MaxLength(500)]
		[Required]
		public string Title { get; set; }

		[MaxLength(400)]
		public string Author { get; set; }

		public int? Number { get; set; }
	}
}