
using D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversNum;
using Microsoft.AspNetCore.Mvc;


namespace D3_MiniChallengeFiveToSeven_Endpoints.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class ReversNumController : Controller
    {
    private readonly IReversNumService _reversNumService;

    public ReversNumController(IReversNumService reversNumService)
        {
        _reversNumService = reversNumService;
    }


        [HttpGet]
        [Route("ReversNumber/{InputNumber}")]
        public string ReversNumber(string InputNumber)
        {
           return _reversNumService.ReversNumber(InputNumber);
        }
        
    }
