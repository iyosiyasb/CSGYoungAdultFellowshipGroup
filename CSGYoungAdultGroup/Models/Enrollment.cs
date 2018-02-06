using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSGYoungAdultGroup.Models
{
	public class Enrollment
	{
			public int EnrollmentID { get; set; }
			public int GroupID { get; set; }
			public int MemberID { get; set; }

			public virtual Group Group { get; set; }
			public virtual Member Member { get; set; }
		}
}