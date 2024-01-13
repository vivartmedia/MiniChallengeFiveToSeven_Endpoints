
using D3_MiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace D3_MiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("IsItOddOrEven/{EnterNumber}")]
    public string OddOrEven(string EnterNumber)
    {
        return _oddOrEvenService.OddOrEven(EnterNumber);

    }

}
