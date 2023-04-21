using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    public class MembershipPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Guid DurationId { get; set; }
        public Guid PaymentPlanId { get; set; }

        public Category Category { get; set; }
        public Duration Duration { get; set; }
        public PaymentPlan PaymentPlan { get; set; }

        public MembershipPlan()
        {
            this.Category = new Category();
            this.Duration = new Duration();
            this.PaymentPlan = new PaymentPlan();


        }
    }
}
