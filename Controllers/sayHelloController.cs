

using Microsoft.AspNetCore.Mvc;

namespace PantojaM_AllForOne.controller;


[ApiController]
[Route("[controller]")]
    public class SayHelloController: ControllerBase
    {
        public List <string> greeting = new();
        [HttpPost]
        [Route("Hello/{name}")]
        public List <string> Hello(string name)
        {
            greeting.Add($"Hello, {name}");
            return greeting;
        }

    }
