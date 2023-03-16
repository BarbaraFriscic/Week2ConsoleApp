using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    public class Member : PersonalInfo
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public Guid MembershipPlanId { get; set; }

        public Location Location { get; set; }
        public MembershipPlan MembershipPlan { get; set; }
    }
}
