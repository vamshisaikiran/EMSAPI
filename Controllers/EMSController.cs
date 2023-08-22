using EMSAPI.Data;
using EMSAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace EMSAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EMSController : Controller
    {
        private readonly EMSAPIDbContext dbContext;

        public EMSController(EMSAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await dbContext.Users.ToListAsync());
        }
        
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest addUserRequest)
        {
            var user = new User()
            {
                UserId = Guid.NewGuid(),
                FirstName = addUserRequest.FirstName,
                LastName = addUserRequest.LastName,
                Username = addUserRequest.Username,
                Password = addUserRequest.Password,
                Role = addUserRequest.Role,
                Email = addUserRequest.Email,
                Group = addUserRequest.Group

            };
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return Ok(user);
        }
    }
}
