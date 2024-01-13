
namespace D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversNum;

public class ReversNumService : IReversNumService
{
    public string ReversNumber(string InputNumber)
    {
        bool isTrue = int.TryParse(InputNumber, out int num);
            if(isTrue)
            {
                string numToString =num.ToString();
                string reversedNum = "";
                for(int i = numToString.Length - 1; i >=0; i--)
                {
                    reversedNum += numToString[i];
                }
                
                return $"You entered {InputNumber}, reversed is {reversedNum}!";
            }else{
                return "You entered an invalid Number!";
            }
        }
}
