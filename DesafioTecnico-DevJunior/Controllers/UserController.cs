using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Users.Domain;

namespace DesafioTecnico_DevJunior.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserDBContexst _db;

        public UserController(UserDBContexst db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }


        [HttpGet]
        public IActionResult get() 
        {
            var users = _db.users.ToList();
            return Ok(users);
        }

        [HttpGet]
        public IActionResult Add(User user) 
        {
            var users = _db.users.Add(user);
            _db.SaveChanges();
            return Ok(users.Entity);
        }
    }
}
