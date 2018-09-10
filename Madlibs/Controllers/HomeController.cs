using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
      [Route("/madlibs")]
      public ActionResult Madlibs()
      {
              LetterVariable myLetterVariable = new LetterVariable();
              myLetterVariable.SetRecipient(Request.Query["person"]);
              myLetterVariable.SetSender(Request.Query["personTwo"]);
              myLetterVariable.SetRecipient(Request.Query["animal"]);
              myLetterVariable.SetSender(Request.Query["verb"]);
              myLetterVariable.SetRecipient(Request.Query["noun"]);

              return View("Hello", myLetterVariable);
            }
  }
 }
