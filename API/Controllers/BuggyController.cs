using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }
       
        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = this._context.Products.Find(40);

            if (thing == null)
            {
                return NotFound(new ApiResponses(404));
            }
            return Ok();
        }
        
        [HttpGet("servererror")]
        public ActionResult GetServerErrorRequest()
        {
            var thing = this._context.Products.Find(40);

            var thingIsNull = thing.ToString();
            return Ok();
        }
        
        
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest(int id)
        {
            return BadRequest(new ApiResponses(400));
        }
        
        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {
            return Ok();
        }
    }
}