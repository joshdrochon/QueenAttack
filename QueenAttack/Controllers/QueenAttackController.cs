using Microsoft.AspNetCore.
using QueenAttackProject.Models;
using System;

namespace QueenAttackProject.Controllers
{
  public class QueenAttackController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("//Home/Index");
    }

    [HttpPost("QueenAttack/ResultFalse")]
    public ActionResult ResultFalse()
    {
      QueenAttack queenAttackFalse = new QueenAttack();
      //coming seen to view near you!
      return View("ResultFalse");
    }

    [HttpPost("QueenAttackResultTrue")]
    public ActionResult ResultTrue()
    {
      QueenAttack queenAttackTrue = new QueenAttack();
      //coming seen to view near you!
      return View("ResultTrue");
    }
  }
}
