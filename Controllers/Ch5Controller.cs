using Microsoft.AspNetCore.Mvc;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Ch5Controller : ControllerBase
{
    [HttpGet]
    [Route("Game/{name}/{game}/{adverb}/{dayOfWeek}/{location}")]
    public string Game(string name, string game, string adverb, string dayOfWeek, string location)
    {// there is five things
        return $"One day {name} was playing {game} with his brother. They both failed to realize that it was {dayOfWeek} so they {adverb} drove to {location}.";
    }

}

