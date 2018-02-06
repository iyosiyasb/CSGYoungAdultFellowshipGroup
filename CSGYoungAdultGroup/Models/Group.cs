using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSGYoungAdultGroup.Models
{
	public class Group
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int GroupID { get; set; }
		public string Title { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}