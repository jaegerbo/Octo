using Octo.Basics;
using Octo.Camera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Map
{
   public class clsMap
   {
      // Konstruktor
      public clsMap(int CellCountX, int CellCountY)
      {
         this.CellCountX = CellCountX;
         this.CellCountY = CellCountY;
      }

      // Properties
      public int CellCountX;
      public int CellCountY;
      public const int CELLSIZE = 100;
      public clsCamera Camera;
      public bool showCellBorder = true;
      
      // Methoden
      public structSize getSizeInPixel()
      {
         return new structSize(CellCountX * CELLSIZE, CellCountY * CELLSIZE);
      }
   }
}
