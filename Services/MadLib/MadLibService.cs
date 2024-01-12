
namespace D3_MiniChallengeFiveToSeven_Endpoints.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string madLib(string adjective1, string noun2, string adjective3, string noun4, string animal5, string name6, string place7, string object8, string superpower9, string adjective10)
    {
        return $"One {adjective1} day, a {noun2} decided to go on a {adjective3}  journey. They packed their {noun4} and set off with their trusty {animal5} companion named {name6}. As they traveled through {place7}, they stumbled upon a magical {object8} that granted them the power of {superpower9}. With their newfound ability, they faced a {adjective10}  challenge and emerged victorious.";
    }
}
