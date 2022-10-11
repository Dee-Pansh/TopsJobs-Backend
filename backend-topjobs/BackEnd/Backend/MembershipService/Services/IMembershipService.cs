using MembershipService.Entities;
namespace MembershipService.Services
{
    public interface IMembershipService
    {
        public string AddSubscription(Membership m);
        public string DeleteSubscription(int EmployerId);
        public string UpdateSubscription(Membership m);
        public Membership GetDetailsOfSubscriptionByEmployerId(int EmpId);
        public string GetMembershipStatusByEmployerId(int EmpId);
    }
}
