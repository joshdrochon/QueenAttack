using Microsoft.AspNetCore.Mvc;
using QueenAttackProject.Models;
using System;

namespace QueenAttackProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("QueenAttack/QueenAttackResult")]
    public ActionResult Result()
    {
      int inputX1 = Int32.Parse(Request.Form["queen-x"]);
      int inputY1 = Int32.Parse(Request.Form["queen-y"]);

      int inputX2 = Int32.Parse(Request.Form["target-x"]);
      int inputY2 = Int32.Parse(Request.Form["target-y"]);

      QueenAttack newQueenAttack = new QueenAttack();

      bool myQueenAttack = newQueenAttack.CanAttack
      (inputX1, inputY1, inputX2, inputY2);

      if(myQueenAttack == false)
      {
        return View("../QueenAttack/ResultFalse");
      }
      else
      {
        return View("../QueenAttack/ResultTrue");
      }
    }

  }
}
