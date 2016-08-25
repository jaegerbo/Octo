using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Objects
{
   class clsAutomaticMove : IMove
   {
      public void move(clsGameObjectMoveable obj, TimeSpan deltaTime)
      {
         try
         {
            // automatisch
            obj.X += (float)(Math.Cos(obj.Angle) * obj.MaxSpeed * deltaTime.TotalSeconds);
            obj.Y += (float)(Math.Sin(obj.Angle) * obj.MaxSpeed * deltaTime.TotalSeconds);

            //obj.X = (int)(obj.X + (obj.Velocity.X * deltaTime.TotalSeconds));
            //obj.Y = (int)(obj.Y + (obj.Velocity.Y * deltaTime.TotalSeconds));

            if (obj.Playgroundsize.Width  != 0 && obj.Playgroundsize.Height  != 0)
            {
               // Grenzen abchecken, wenn über das Game-Objekt Grenzen vorhanden sin
               if (obj.X < 0)
               {
                  obj.X = 0;
                  obj.Velocity = new Vector2(obj.Velocity.X * -1, obj.Velocity.Y);
               }
               if (obj.Y < 0)
               {
                  obj.Y = 0;
                  obj.Velocity = new Vector2(obj.Velocity.X, obj.Velocity.Y * -1);
               }
               if (obj.X + obj.Width > obj.Playgroundsize.Width )
               {
                  obj.X = obj.Playgroundsize.Width - obj.Width;
                  obj.Angle = (float)Math.PI * 2 - obj.Angle;
                  //obj.Velocity = new Vector2(obj.Velocity.X * -1, obj.Velocity.Y);
               }
               if (obj.Y + obj.Height > obj.Playgroundsize.Height)
               {
                  obj.Y = obj.Playgroundsize.Height - obj.Height;
                  obj.Angle = (float)Math.PI * 2 - obj.Angle;
                  //obj.Velocity = new Vector2(obj.Velocity.X, obj.Velocity.Y * -1);
               }
            }
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
      }
   }
}
