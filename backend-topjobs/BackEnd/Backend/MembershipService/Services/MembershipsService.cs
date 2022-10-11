using MembershipService.Entities;
using MembershipService.Repository;
namespace MembershipService.Services
{
    public class MembershipsService : IMembershipService
    {
        private readonly IMembershipRepository db;

        public MembershipsService(IMembershipRepository db)
        {
            this.db = db;
        }
        public string AddSubscription(Membership m)
        {
            try
            {
                return this.db.AddSubscription(m);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public string DeleteSubscription(int EmployerId)
        {
            try
            {
                return this.db.DeleteSubscription(EmployerId);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public Membership GetDetailsOfSubscriptionByEmployerId(int EmpId)
        {
             try
            {
                return this.db.GetDetailsOfSubscriptionByEmployerId(EmpId);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public string GetMembershipStatusByEmployerId(int EmpId)
        {
                return this.db.GetMembershipStatusByEmployerId(EmpId);
        }

        public string UpdateSubscription(Membership m)
        {
             try
            {
                return this.db.UpdateSubscription(m);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }
    }
}
