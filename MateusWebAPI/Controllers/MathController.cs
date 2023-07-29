using Microsoft.AspNetCore.Mvc;

namespace MateusWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public UInt64 Index(int numberOfZeroes)
        {
            string myString = "1";

            for (int i = 0; i < numberOfZeroes; i++)
            {
                myString += "0";
            }

            return Convert.ToUInt64(myString);
        }
    }
}
