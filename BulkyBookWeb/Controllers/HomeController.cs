using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc; //MVC에서 컨트롤러를 작성하기 위해 사용
using System.Diagnostics; //디버그와 관련된 기능을 제공

namespace BulkyBookWeb.Controllers
{
    public class HomeController : Controller //HomeController 클래스를 정의,  Controller 클래스를 상속받음
    {
        private readonly ILogger<HomeController> _logger; // 로깅을 위해 사용됩니다.

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}