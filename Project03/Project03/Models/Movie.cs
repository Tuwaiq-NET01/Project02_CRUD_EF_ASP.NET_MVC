using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project03.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Poster { get; set; }
		public string Description { get; set; }
		public string Rating { get; set; }
		public string Cast { get; set; }
	}
}
