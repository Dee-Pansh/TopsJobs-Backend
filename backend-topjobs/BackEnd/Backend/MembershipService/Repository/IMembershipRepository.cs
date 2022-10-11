using MembershipService.Entities;
namespace MembershipService.Repository
{
    public interface IMembershipRepository
    {
        public string AddSubscription(Membership m);
        public string DeleteSubscription(int EmployerId);
        public string UpdateSubscription(Membership m);
        public Membership GetDetailsOfSubscriptionByEmployerId(int EmpId);
        public string GetMembershipStatusByEmployerId(int EmpId);
    }
}
