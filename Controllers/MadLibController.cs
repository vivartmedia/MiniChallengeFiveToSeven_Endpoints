
using D3_MiniChallengeFiveToSeven_Endpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace D3_MiniChallengeFiveToSeven_Endpoints.Controllers;

    [Route("[controller]")]
    public class MadLibController : Controller
    {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
        {
        _madLibService = madLibService;
    }


        [HttpGet]
        [Route("Madlib/{adjective1}/{noun2}/{adjective3}/{noun4}/{animal5}/{name6}/{place7}/{object8}/{superpower9}/{adjective10}" )]
        public string madLib(string adjective1, string noun2, string adjective3, string noun4, string animal5, string name6, string place7, string object8, string superpower9, string adjective10)
        {
            return _madLibService.madLib(adjective1, noun2, adjective3, noun4, animal5, name6, place7, object8, superpower9, adjective10);
        }
    }
