using Microsoft.AspNetCore.Mvc;
using Railyatri.Repository;

namespace Railyatri.Controllers
{
    public class TrainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ITrainRepository _Traindb;
        public TrainController(ITrainRepository Traindb)
        {
            _Traindb = Traindb;
        }
        // POST: api/values
        [HttpPost]
        [Route("List")]
        public IActionResult AddMember([FromBody] Trainslist details)
        {

            _Traindb.AddMember(details);

            return Ok(details);

        }

        // GET: api/values
        [HttpPost]
        [Route("get-list")]
        public async Task<IActionResult> Get([FromBody] Trainslist list)
        {


            var Data = await _Traindb.GetAllTrainslist(list);

            return Ok(Data);
        }

    }
}
