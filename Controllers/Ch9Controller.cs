using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch9Controller : ControllerBase
{
    [HttpGet]
    [Route("Game")]
    public string Game()
    {
        Random randomNum = new Random ();
        string [] Restaurant = new string []{"La Mesa", "Besitos", "Mezo", "Mi Ranchito", "Mi Cocina", "Irmas","Octavios", "Nena's", "Susy's", "Xochimilco", "Hilda's", "Domo", "Shomi", "Thai Me Up", "SunKing", "New fu Lim", "Tsing Tao", "Peking", "China Palace", "Dynasty Seafood", "Dave Wong's", "George's", "LumberJacks", "Cast Iron Co.", " The Creamery", "Market Tavern", "The Downtowner", "the Black Rabbit", "Squeeze Burger", "ElkHorn", "FED", "Prime Table", "Mannys California Fresh", "Bud's Seafood Grille", "Midgley's Public House"  };
        int allChoice = randomNum.Next(0,34);
        return $"You're Restaurant is... \n\n-*-*-*- {Restaurant[allChoice]} -*-*-*-\n";
    }


}
