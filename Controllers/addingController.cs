using Microsoft.AspNetCore.Mvc;

namespace PantojaM_AllForOne.controller;


[ApiController]
[Route("[controller]")]
public class AddingController : ControllerBase
{
    public List<string> adding = new();
    [HttpGet]
    [Route("return{number1}/{number2}")]
    public List<string> Hello(int number1, int number2)
    {

        int sum = number1 + number2;
        adding.Add($"the sum of, {number1} and {number2} = {sum}");
        return adding;
    }

}
