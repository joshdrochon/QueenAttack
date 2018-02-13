using System;
using Microsoft.AspNetCore.Mvc;

namespace QueenAttackProject.Models
{
  public class Queen
  {

    public bool CanAttack(int x1, int y1, int x2, int y2)
    {
      if(x1 == x2)
      {
        return true;
      }
      else if(y1 == y2)
      {
        return true;
      }
      else if(((x1 - x2) * -1) == ((y1 - y2) * -1)))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }











}//end namespace
