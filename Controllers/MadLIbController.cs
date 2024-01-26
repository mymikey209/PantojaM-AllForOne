using Microsoft.AspNetCore.Mvc;
using PantojaM_AllForOne.servies;

namespace MadLibs.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibsService _madLibsService;

    public MadLib(IMadLibsService madLibsService)
    {
        _madLibsService = madLibsService;
    }

   

    [HttpGet]
    [Route("On an /{adj1} / afternoon, I found a mysterious  / {noun1} /  in my / {room1} /.it was / {color} / and / {size} /,and it emitted a strange  / {sound}.With curiosity, I cautiously picked it up and it felt  / {texture} / . / Suddely, it began to  / {adj2} / ,and i was transported to an/{noun2}/world filled with. Iembarked on an / {adj3} /  adventure, and i couldnt help but feel/{emotion} / throughout.After what felt like hours, i woke up back in my/{room2}/wondering if it had all been an/{adj4}/dream")]
    public string MadLib(string adj1 , string noun1 , string room1 , string color , string size , string sound , string texture , string adj2 , string noun2 , string adj3 , string emotion , string room2 , string adj4)
    {
        return _madLibsService.MadLib(adj1 , noun1 , room1 , color ,  size , sound ,  texture ,  adj2 , noun2 , adj3 , emotion , room2 , adj4);
       
    }
}