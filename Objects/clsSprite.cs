using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Octo.Basics;

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
         destRectangle = new structRectangle(X, Y, Width, Height);
         base.update(deltaTime);
      }
   }
}
