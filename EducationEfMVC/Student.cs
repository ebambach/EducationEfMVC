using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EducationEfMVC.Models;

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
		public int? MajorId { get; set; }
		public Major Major { get; set; }
		public int Sat { get; set; }
		public double Gpa { get; set; }

		//Entity framework essentially does this for us, where it retrieves the information,
		//allows us to make changes, and then save it.  This is here as an example of an
		//alternative, because sometimes it is easier to comprehend by having it in the class
		//instead of in the method.
		//public void Copy(Student student) {
		//	FirstName = student.FirstName;
		//	LastName = student.LastName;
		//	Sat = student.Sat;
		//	Gpa = student.Gpa;
		//	PhoneNumber = student.PhoneNumber;
		//	Email = student.Email;
		//}
	}
}