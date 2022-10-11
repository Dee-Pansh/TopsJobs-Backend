using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DetailsServices.Entities;
using DetailsServices.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using Microsoft.Extensions.Configuration;
using DetailsServices.Entities.Model;
using Microsoft.AspNetCore.Authorization;
namespace DetailsServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private readonly IJobSeekerServices _jobSeekerServices;
        private readonly IEmployeeServices _employeeServices;
        private readonly DetailsDb db;
        public DetailsController(IEmployeeServices _employeeServices, IJobSeekerServices _jobSeekerServices,DetailsDb db)
        {
            this._employeeServices = _employeeServices;
            this._jobSeekerServices = _jobSeekerServices;
            this.db = db;
        }
        


        [HttpPost]
        [Route("RegisterForEmployer")]
        public string Register(Employer emp)
        {
            try
            {
                return this._employeeServices.AddEmployer(emp);
            }
            catch (Exception)
            {
                return "some error occured";
            }
        }



        [HttpPost]
           [Route("RegisterForJobSeeker")]
            public string Register(JobSeeker js)
            {
                try
                {
                    return this._jobSeekerServices.AddJobSeeker(js);
                }
                catch (Exception)
                {
                return "some error occured";
            }
            }




        [HttpPost, Route("LoginEmployer")]
        public IActionResult LoginEmployer(Login login)
        {
            try
            {
                AuthUserForEmployer authUser = null;
                Employer emp = this.db.Employers.SingleOrDefault(u=>u.EmailAddress==login.Email && u.Password==login.Password);
                if (emp != null)
                {
                    authUser = new AuthUserForEmployer()
                    {
                        UserId = emp.Id,
                        Name = emp.Name,
                        Token = GetTokenOfEmployer(emp),
                        Role = emp.Role,
                        EmailAddress=emp.EmailAddress,
                        PhoneNumber = emp.PhoneNumber,
                        CompanyName=emp.CompanyName

                    };
                }
                return Ok(authUser);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



        [HttpPost, Route("LoginJobSeeker")]

        public IActionResult LoginJobSeeker(Login login)
        {
            try
            {
                AuthUserForJobSeeker authUser = null;
                JobSeeker js = _jobSeekerServices.Login(login);
                if (js != null)
                {
                    authUser = new AuthUserForJobSeeker()
                    {
                        UserId = js.Id,
                        Name = js.Name,
                        Token = GetTokenOfJobSeeker(js),
                        Role = js.Role,
                       EmailAddress=js.EmailAddress,
                        PhoneNumber = js.PhoneNumber
                    };
                }
                return Ok(authUser);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }




        private string GetTokenOfEmployer(Employer emp)
        {
            var _config = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                   {
                          new Claim(ClaimTypes.Name, emp.Name.ToString()),
                          new Claim(ClaimTypes.Role, emp.Role)
                   }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }




        private string GetTokenOfJobSeeker(JobSeeker js)
        {
            var _config = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                   {
                          new Claim(ClaimTypes.Name, js.Name.ToString()),
                          new Claim(ClaimTypes.Role, js.Role)
                   }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
