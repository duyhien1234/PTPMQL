using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DangDuyHien2002.Controllers;
 public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName)
    {
        string strReturn = "Hello" + FullName;
        //gui du lieu ve view
        ViewBag.Thongbao = strReturn;
        return View();


    }
    

    public IActionResult About()
    {
        return View();
    }
}