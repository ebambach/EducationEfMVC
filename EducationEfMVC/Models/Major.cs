using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEfMVC.Models {
	public class Major {
		public int Id { get; set; }
		public string Description { get; set; }

		//This is a collection of the Students with a particular Major
		public ICollection<Student> Students { get; set; }
	}
}