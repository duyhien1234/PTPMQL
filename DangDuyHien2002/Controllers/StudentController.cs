using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DangDuyHien2002.Controllers;
 public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}