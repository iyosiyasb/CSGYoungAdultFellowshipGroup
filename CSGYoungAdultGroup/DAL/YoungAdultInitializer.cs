using System;
using System.Collections.Generic;
using CSGYoungAdultGroup.Models;

namespace CSGYoungAdultGroup.DAL
{
	public class YoungAdultInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<YoungAdultContext>
	{
		protected override void Seed(YoungAdultContext context)
		{
			var Members = new List<Member>
			{
			new Member{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
			new Member{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Member{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
			new Member{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Member{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Member{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
			new Member{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
			new Member{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
			};

			Members.ForEach(s => context.Members.Add(s));
			context.SaveChanges();
			var Groups = new List<Group>
			{
			new Group{GroupID=1050,Title="Poems",},
			new Group{GroupID=4022,Title="Worship",},
			new Group{GroupID=4041,Title="Drama",},
			new Group{GroupID=1045,Title="Prayer",},
			new Group{GroupID=3141,Title="Bible",},
			new Group{GroupID=2021,Title="Instrument",},
			new Group{GroupID=2042,Title="Counselling",}
			};
			Groups.ForEach(s => context.Groups.Add(s));
			context.SaveChanges();
			var enrollments = new List<Enrollment>
			{
			new Enrollment{MemberID=1,GroupID=1050},
			new Enrollment{MemberID=1,GroupID=4022},
			new Enrollment{MemberID=1,GroupID=4041},
			new Enrollment{MemberID=2,GroupID=1045},
			new Enrollment{MemberID=2,GroupID=3141},
			new Enrollment{MemberID=2,GroupID=2021},
			new Enrollment{MemberID=3,GroupID=1050},
			new Enrollment{MemberID=4,GroupID=1050},
			new Enrollment{MemberID=4,GroupID=4022},
			new Enrollment{MemberID=5,GroupID=4041},
			new Enrollment{MemberID=6,GroupID=1045},
			new Enrollment{MemberID=7,GroupID=3141},
			};
			enrollments.ForEach(s => context.Enrollments.Add(s));
			context.SaveChanges();
		}
	}
}
	
