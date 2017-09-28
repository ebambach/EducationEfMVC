using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EducationEfMVC.Models {
	public class Major {
		public int Id { get; set; }
		public string Description { get; set; }

		//This is a collection of the Students with a particular Major
		[JsonIgnore]
		public ICollection<Student> Students { get; set; }
	}
}