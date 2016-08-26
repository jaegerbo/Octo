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
      public clsMapCell(clsMap Map, int CellX, int CellY) {
         this.Map = Map;
         this.CellX = CellX;
         this.CellY = CellY;
      }

      // Properties
      public clsMap Map;
      public string BackgroundFile = "./Assets/Grass_1.png";
      // die Koordinaten im Map-Raster
      public int CellX;
      public int CellY;
      // die absoluten Koordinaten auf der Map
      private int _MapCellX = 0;
      public int MapCellX {
         get {
            if (_MapCellX == 0)
            {
               _MapCellX = CellX * Map.CELLSIZE; 
            }
            return _MapCellX;
         }
      }
      private int _MapCellY = 0;
      public int MapCellY
      {
         get
         {
            if (_MapCellY == 0)
            {
               _MapCellY = CellY * Map.CELLSIZE;
            }
            return _MapCellY;
         }
      }
   }
}
