using Microsoft.AspNetCore.Mvc;

namespace SlagboomStatusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlagboomController : ControllerBase
    {
        // Variabele om de status van de slagboom op te slaan
        private static string _slagboomStatus = "dicht";

        // Endpoint om de huidige status van de slagboom op te halen
        [HttpGet]
        public IActionResult GetStatus()
        {
            return Ok(new { status = _slagboomStatus });
        }

        // Endpoint om de slagboom te openen
        [HttpPost("open")] // Dit maakt de /open route beschikbaar
        public IActionResult OpenSlagboom()
        {
            _slagboomStatus = "geopend";
            return Ok(new { status = _slagboomStatus });
        }

        // Endpoint om de slagboom te sluiten
        [HttpPost("close")] // Dit maakt de /close route beschikbaar
        public IActionResult CloseSlagboom()
        {
            _slagboomStatus = "dicht";
            return Ok(new { status = _slagboomStatus });
        }
    }
}
