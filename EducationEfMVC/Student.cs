using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEfMVC {
	public class Student {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zipcode { get; set; }
		public DateTime Birthday { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		//Needs a default in the Program, "majorid" is allowed to be "null" in SQL
		public int Majorid { get; set; }
		public int Sat { get; set; }
		public double Gpa { get; set; }
	}
}