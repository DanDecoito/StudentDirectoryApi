using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch4Controller : ControllerBase
{
   
[HttpGet]
[Route("Maths/{num1}/{num2}")]
public string Maths(string num1,string num2)
{
    
    int number1 = int.Parse(num1);
    int number2 = int.Parse(num2);

    string response = number1 == number2 ? $"{num1} is equal to {num2}" : number1 > number2 ? $"{num1} is Greater than {num2}" :  $"{num1} is Less than {num2}";

    return response;
}

}

