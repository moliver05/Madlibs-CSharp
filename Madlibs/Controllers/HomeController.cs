using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {

    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlibs_form")]
    public ActionResult Madlibs()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetPerson(Request.Query["person"]);
      myLetterVariable.SetPersonTwo(Request.Query["personTwo"]);
      myLetterVariable.SetAnimal(Request.Query["animal"]);
      myLetterVariable.SetVerb(Request.Query["verb"]);
      myLetterVariable.SetNoun(Request.Query["noun"]);
      myLetterVariable.SetExpression(Request.Query["expression"]);

      return View("Story", myLetterVariable);
    }
  }
 }
