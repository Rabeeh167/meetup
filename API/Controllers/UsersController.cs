using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser?>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }
    //    [HttpGet]
    //    public ActionResult<IEnumerable<AppUser>> GetUsers()
    //    {
    //     var users = _context.Users.ToList();
    //     return users;
    //    }

    //    [HttpGet("{id}")]
    //    public ActionResult<AppUser?> GetUser(int id)
    //    {
    //     var user = this._context.Users.Find(id);
    //     return user;
    //    }
}
