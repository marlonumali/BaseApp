using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApp.Data;
using BaseApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseApp.Controllers
{
    [ApiController]
    [Route("BaseApp/[controller]")]
    public class Users : ControllerBase
    {
        private readonly DataContext context;
        public Users(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id)
        {
            return await context.Users.FindAsync(Id);            
        }

    }
}