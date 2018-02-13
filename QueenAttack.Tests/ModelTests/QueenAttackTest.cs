using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackProject.Models;
using QueenAttackProject;
using System;


namespace QueenAttackProject.Test
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void TestCanAttack()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.CanAttack(2, 2, 3, 4));
    }
  }
}
