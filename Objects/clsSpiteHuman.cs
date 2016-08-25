using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Octo.GameLogic
{
   class clsSpiteHuman : clsGameObject 
   {
      // Properties
      public System.Drawing.Image  Image { get; set; }
      public int VelocityX { get; set; }
      public int VelocityY { get; set; }

      enum WalkingDirection {north, northEast, east, southEast, south, southWest, west, northWest}

      // Methoden
      public override void update(TimeSpan deltaTime)
      {
         // manuell
         X = (int)(X + (VelocityX * deltaTime.TotalSeconds));
         Y = (int)(Y + (VelocityY * deltaTime.TotalSeconds));

         if (Parent != null)
         {
            X = XStart + Parent.X;
            Y = YStart + Parent.Y;
         }
         else
         {
            X = XStart;
            Y = YStart;
         }
         base.update(deltaTime);
      }
      //public override void render(Graphics gr)
      //{
      //   try
      //   {
      //      gr.FillRectangle(new SolidBrush(Color.DarkBlue), X, Y, Width, Height);
      //   }
      //   catch (Exception ex)
      //   {
      //      new clsError(ex);
      //   }
      //   base.render(gr);
      //}
   }

}
