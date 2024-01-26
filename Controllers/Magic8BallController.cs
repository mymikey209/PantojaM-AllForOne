using Microsoft.AspNetCore.Mvc;
using PantojaM_AllForOne.service;

namespace Magic8Ball.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _Magic8BallService;
    public Magic8BallController(IMagic8BallService Magic8BallService)
    {
        _Magic8BallService = Magic8BallService;
    }

    public List<string> EightBall = new();
    [HttpGet]
    [Route("AskQuestion/{GiveAnswer}")]

    public string Answer(string GiveAnswer)
    {
        return _Magic8BallService.Answer (GiveAnswer);
    }

   
}