﻿using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Author name";

    [HttpGet("healthy")]
    public IActionResult Healthy()
    {
        return Ok("It's working");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}