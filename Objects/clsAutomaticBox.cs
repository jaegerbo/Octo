using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;

namespace Octo.Objects
{
   public class clsAutomaticBox : clsGameObjectMoveable
   {
      // Konstruktor
      public clsAutomaticBox(int xStart, int yStart, int width, int height,System.Drawing.Size screenSize):base() {
         XStart = xStart; YStart = yStart;
         Width = width; Height = height;
         Velocity = new Vector2(100, 100);
      }

      // interne Variablen
      int _frameswitch = 0;

      // Methoden
      public override void update(TimeSpan deltaTime) 
      {
         // Bewegung aufrufen
         moveBehavior.move(this, deltaTime);

         // Bereich der Bitmap bestimmen, die gezeichnet werden soll. Dabei alle 10 Frames den Bereich wechseln.
         if (_frameswitch <= 10)
         {
            srcRectangle = new Rectangle(0, 0, 100, 100);
         }
         else
         {
            srcRectangle = new Rectangle(100, 0, 100, 100);
         }
         if (_frameswitch >= 20 )
         {
            _frameswitch = 0;
         }
         destRectangle = new Rectangle((int)X, (int)Y, 100, 100);
         _frameswitch += 1;

         base.update(deltaTime );

      }
      //public override void render(Graphics gr)
      //{
      //   try
      //   {
      //      gr.FillEllipse(new SolidBrush(BackColor), X, Y, Width, Height);
      //      base.render(gr);
      //   }
      //   catch (Exception ex)
      //   {
      //      new clsError(ex);
      //   }
      //}
   }
}
