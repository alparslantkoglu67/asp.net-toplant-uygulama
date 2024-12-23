using System.Runtime.InteropServices;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{
    public class HomeController : Controller
    {
//localhost/home/index
     public IActionResult Index()
     {
        int UserCount=Repository.Users.Where(info => info.WillAttend==true).Count();
        int saat =DateTime.Now.Hour;
       /* ViewBag.Selamlama = saat > 12 ? "İyi Günler":"Günaydın";*/
        ViewData["Selamlama"]= saat > 12 ? "İyi Günler":"Günaydın";
        var meetingInfo=new MeetingInfo(){
            Id =1,
            Location="Ankara",
            Date=new DateTime(2024,8,12,20,0,0),
            NumberOfPeople=UserCount,

        };


        return View(meetingInfo);
        
     }   
    }
}