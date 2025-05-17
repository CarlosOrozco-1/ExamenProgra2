using Microsoft.AspNetCore.Mvc;
using TallerAPI.Models;
using TallerAPI.Data;

namespace TallerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TallerController : ControllerBase
    {
        // GET: api/taller
        [HttpGet]
        public ActionResult<Taller> Get()
        {
            return TallerData.InfoTaller;
        }
    }
}
