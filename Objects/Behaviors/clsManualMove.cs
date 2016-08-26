using Octo.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Objects
{
   public class clsManualMove : IMove
   {
      // Properties
      structRectangle _BorderRectangle;
      structRectangle IMove.BorderRectangle
      {
         get
         {
            return _BorderRectangle; ;
         }

         set
         {
            _BorderRectangle = value;
         }
      }

      // Methoden
      public void move(clsGameObjectMoveable obj, TimeSpan deltaTime)
      {
         Vector2 velocity = new Vector2(
                         (obj.Input.West ? -1f : 0f) + (obj.Input.East ? 1f : 0f),
                         (obj.Input.North ? -1f : 0f) + (obj.Input.South ? 1f : 0f));

         if (velocity.Length() > 0f)
         {
            // Vektor normalisieren
            velocity = Vector2.Normalize(velocity);

            //State = PlayerState.Walk;
            obj.Angle = (float)Math.Atan2(velocity.Y, velocity.X);
            obj.X += (velocity.X * obj.MaxSpeed * (float)deltaTime.TotalSeconds );
            obj.Y += (velocity.Y * obj.MaxSpeed * (float)deltaTime.TotalSeconds);
         }
         else
         {
            //State = PlayerState.Idle;
         }
      }
   }
}
