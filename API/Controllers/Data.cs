using Microsoft.AspNetCore.Mvc;
using laserApp.Models;

namespace laserApp.Controllers;

[ApiController]
[Route("[controller]")]
public class laserAppController : ControllerBase
{
    private readonly ILogger<laserAppController> _logger;

    public laserAppController(ILogger<laserAppController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Data> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Data
        {
        	Id = Random.Shared.Next(-20, 55),
		Text = "This is the number generated from random function"
	})
        .ToArray();
    }
}
