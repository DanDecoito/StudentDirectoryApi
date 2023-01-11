using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch2Controller : ControllerBase
{
    [HttpGet]
    [Route("Adding/{num1}/{num2}")]
    public int Adding(string num1, string num2)
    {
        int number1 = int.Parse(num1);
        int number2 = int.Parse(num2);

        return number1 + number2;
    }

}

