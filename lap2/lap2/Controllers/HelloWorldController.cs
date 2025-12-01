using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web; // Thêm namespace này

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View(); // Trả về một View, không phải chuỗi
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // Lưu dữ liệu vào từ điển ViewData
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View(); // Trả về View Welcome
        }
    }
}