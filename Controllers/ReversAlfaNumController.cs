
using System.Net.Http.Headers;
using D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversAlfaNum;
using Microsoft.AspNetCore.Mvc;


namespace D3_MiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReversAlfaNumController : Controller
{
    private readonly IReversAlfaNumService _reversAlfaNumService;

    public ReversAlfaNumController(IReversAlfaNumService reversAlfaNumService)
    {
        _reversAlfaNumService = reversAlfaNumService;
    }

    [HttpGet]
    [Route("ReversAlfaNum/{yourInput}")]
    public string ReversAlfaNumeric(string yourInput)
    {

        return _reversAlfaNumService.ReversAlfaNumeric(yourInput);
    }
}
