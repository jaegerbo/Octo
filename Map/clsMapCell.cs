using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Map
{
   public class clsMapCell
   {
      // Konstruktor
      public clsMapCell() { }

      // Properties
      public string BackgroundFile = "./Assets/Grass_1.png";
      public int CellX;
      public int CellY;
      public clsMapCellList MapCells = new clsMapCellList();
   }
}
