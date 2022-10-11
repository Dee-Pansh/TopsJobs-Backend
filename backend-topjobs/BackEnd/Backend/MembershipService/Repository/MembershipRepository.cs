using MembershipService.Entities;
using System.Linq;
namespace MembershipService.Repository
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly MembershipDb db;
        public MembershipRepository(MembershipDb db)
        {
            this.db = db;
        }
        public string AddSubscription(Membership m)
        {
            this.db.Membership.Add(m);
            db.SaveChanges();
            return "Success";
        }

        public string DeleteSubscription(int EmployerId)
        {

            Membership m = this.db.Membership.SingleOrDefault(t => t.EmployerId == EmployerId);
                if(m!=null)
                {
                this.db.Membership.Remove(m);
                db.SaveChanges();
                return "deleted successfully";
                }
            return "not a regsitered user";
        }

        public Membership GetDetailsOfSubscriptionByEmployerId(int EmpId)
        {
            return this.db.Membership.SingleOrDefault(t => t.EmployerId == EmpId);
        }

        public string GetMembershipStatusByEmployerId(int EmpId)
        {
            if(this.db.Membership==null)
            {
                return "buy subscription to see the Applicant info";
            }
            Membership m = this.db.Membership.SingleOrDefault(y => y.EmployerId == EmpId);
            if (m != null){
                return m.Status;
            }
            return "buy subscription to see the Applicant info";
        }

        public string UpdateSubscription(Membership m)
        {
            Membership o = this.db.Membership.SingleOrDefault(t => t.EmployerId == m.EmployerId);
            if(o!=null)
            {
                this.db.Membership.Update(o);
                db.SaveChanges();
                return "updated successfully";
            }
            return "not a regsitered user";
        }
    }
}
