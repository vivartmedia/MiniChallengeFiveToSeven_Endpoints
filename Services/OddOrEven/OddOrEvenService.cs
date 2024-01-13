
namespace D3_MiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string EnterNumber)
    {
        bool isTrue = int.TryParse(EnterNumber, out int num);
        if (isTrue)
        {
            if (num % 2 == 0)
            {
              return  $"You entered {num}, which is an even number!";
            }
            else
            {
                return $"You entered {num}, which is an odd number!";
            }
        }else{
            return $"You entered {EnterNumber}, which is an invalid number!";
        }
    }
}
