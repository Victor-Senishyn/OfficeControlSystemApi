using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeControlSystemApi.Models.DTOs;
using OfficeControlSystemApi.Models.Enums;

namespace OfficeControlSystemApi.Controllers
{
    public class Test : Controller
    {
        [HttpGet("/test")]
        public async Task<IActionResult> Test1() => Ok("Hello world");
    }
}
