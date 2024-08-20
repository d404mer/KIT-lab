using Microsoft.AspNetCore.Mvc;
using PP_laba_4.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace PP_laba_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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




        //функции самих заданий
        public IActionResult FirstTask()
        {
            return View();
        }

        public IActionResult SecondTask() 
        {
            return View();
        }

        public IActionResult ThirdTask() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult FirstTask(string Number)
        {
            bool answ = false;
            if ( Convert.ToInt32(Number) % 7 == 0)
            {
                answ = true;
            }
            ViewBag.SevenEleven = answ;
            return View();
        }


        

        [HttpPost]
        public IActionResult SecondTask(string textInput)
        {
            char[] result = new char[textInput.Length];
            int c = 0;

            for (int i = 0; i < textInput.Length; i++)
            {
                if (char.ToLower(textInput[i]) != 'с')
                {
                    result[i] = textInput[i];
                    c++;
                }
                //else { result[i] = ''; }
            }

            for (int k = c; k < result.Length;k++)
            {
                result[k] = '_';
            }

            
            ViewBag.StringResult = new string(result);
            return View();
        }


        [HttpPost]
        public IActionResult ThirdTask(string arrayInput)
        {

            string[] numbersString = arrayInput.Split(',');
            int[] numbersInt = new int[numbersString.Length];
            double sum = 0, mult = 1;
            string respond = "fsgd";


            if (numbersInt.Length % 2 == 0)
            {
                for (int i = 0; i < numbersInt.Length; i++)
                {
                    numbersInt[i] = int.Parse(numbersString[i]);
                }

                for (int k = 0; k < numbersInt.Length; k++)
                {
                    if (k % 2 != 0)
                    {
                        sum += Math.Pow(numbersInt[k], 2);
                        mult *= Math.Pow(numbersInt[k], 3);
                    }

                }
                ViewBag.Quad = sum;
                ViewBag.Trip = mult;
            }

            else {
                    respond = "длина массива нечётна";
                    ViewBag.answ =  respond; 
            }
            
            
                return View();
        }


    }
}
