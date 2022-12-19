using Microsoft.AspNetCore.Mvc;
using VsProj.Services;

namespace VsProj.Controllers
{
    [ApiController]
    [Route("api/v1/partnerek")]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;
        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet]
        public ActionResult GetPartners()
        {
            var partnerInfos = _partnerService.GetPartnerInfos();
            if (partnerInfos == null) return NotFound();

            return Ok(partnerInfos);
        }
    }
}
