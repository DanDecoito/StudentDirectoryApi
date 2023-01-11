using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch7Controller : ControllerBase
{

    [HttpGet]
    [Route("Game/{number}")]
    public string Game(string number)
    {
        string numberOne = "";
        string numberTwo = "";
        int numInput = int.Parse(number);
        char[] intArray = number.ToCharArray();
        for (int i = 0; i < intArray.Length; i++)
        {
            numberOne = numberOne + intArray[i].ToString();
        }

        for (int j = intArray.Length - 1; j > -1; j--)
        {
            numberTwo = numberTwo + intArray[j].ToString();
        }
        return $" --Reverse it-- \nYour number is \n{number} \nYour number reversed is \n{numberTwo}";
    }

}

