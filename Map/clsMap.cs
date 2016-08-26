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

         // Liste mit den einzelnen Feldern erstellen
         for(int x = 0; x < CellCountX; x++)
         {
            for(int y = 0; y < CellCountY; y++)
            {
               clsMapCell MapCell = new Map.clsMapCell(this, x, y);
               MapCells.Add(MapCell);
            }
         }
      }

      // Properties
      public int CellCountX;
      public int CellCountY;
      public int CELLSIZE = 100;
      public clsCamera Camera;
      public bool showCellBorder = true;
      public clsMapCellList MapCells = new clsMapCellList();

      // Methoden
      public structSize getSizeInPixel()
      {
         return new structSize(CellCountX * CELLSIZE, CellCountY * CELLSIZE);
      }
   }
}
