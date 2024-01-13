

namespace D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversAlfaNum;

public class ReversAlfaNumService : IReversAlfaNumService
{
    public string ReversAlfaNumeric(string yourInput)
    {
     string reversedIs = "";
            for (int i = yourInput.Length - 1; i >=0; i--){
                reversedIs += yourInput[i];
            }
            return $"You entered {yourInput}, reversed is {reversedIs}";
        }
}
