using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MembershipService.Entities;
using MembershipService.Services;
using Microsoft.AspNetCore.Authorization;
namespace MembershipService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipService db;
        public MembershipController(IMembershipService db)
        {
            this.db = db;
        }




        //[Authorize(Roles ="Employer")]
        [HttpGet,Route("GetDetailsOfSubscriptionByEmployerId")]
        public Membership GetDetailsOfSubscriptionByEmployerId(int EmpId)
        {
            return this.db.GetDetailsOfSubscriptionByEmployerId(EmpId);
        }





        //[Authorize(Roles ="Employer")]
        [HttpGet,Route("GetMembershipStatusByEmployerId")]
        public string GetMembershipStatusByEmployerId(int EmpId)
        {
            return this.db.GetMembershipStatusByEmployerId(EmpId);
        }






        //[Authorize(Roles = "Employer")]
        [HttpDelete,Route("DeleteSubscription")]
        public string DeleteSubscription(int EmployerId)
        {
            return this.db.DeleteSubscription(EmployerId);
        }







        //[Authorize(Roles = "Employer")]
        [HttpPut,Route("UpdateSubscription")]
        public string UpdateSubscription(Membership m)
        {
            return this.db.UpdateSubscription(m);
        }
        //[Authorize(Roles = "Employer")]
        [HttpPost,Route("AddSubscription")]
       public string AddSubscription(Membership m)
        {
            return this.db.AddSubscription(m);
        }

    }
}
