using Microsoft.AspNetCore.Mvc;

namespace PantojaM_AllForOne.controller;

[ApiController]
[Route("[controller]")]
    public class WhatIsYourNameController : ControllerBase
    {
        public List <string> greeting = new();
        [HttpGet]
        [Route("Hello/{WhatIsYourName}/{WhatTimeDidYouWakeUp}")]
        public List <string> Hello(string WhatIsYourName , string WhatTimeDidYouWakeUp)
        {
            greeting.Add($"Hello, {WhatIsYourName}. I woke up at {WhatTimeDidYouWakeUp} ");
            return greeting;
        }
    }