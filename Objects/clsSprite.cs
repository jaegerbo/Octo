using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace Octo.Objects
{
   class clsSprite : clsGameObjectMoveable
   {
      public clsSprite(int xStart, int yStart, int width, int height, System.Drawing.Size screenSize):base() {
         XStart = xStart; YStart = yStart;
         X = xStart; Y = yStart;
         Width = width; Height = height;
         Velocity = new Vector2(100, 100);
      }

      // Methoden
      public override void update(TimeSpan deltaTime)
      {
         moveBehavior.move(this, deltaTime);
         destRectangle = new Rectangle((int)X, (int)Y, Width, Height);
         base.update(deltaTime);
      }
      //public override void render(Graphics gr)
      //{
      //   try
      //   {
      //      base.render(gr);
      //   }
      //   catch (Exception ex)
      //   {
      //      new clsError(ex);
      //   }
      //}

   }
}
