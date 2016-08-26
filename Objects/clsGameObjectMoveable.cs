using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Objects
{
   public class clsGameObjectMoveable : clsGameObject
   {
      // Konstruktor
      public clsGameObjectMoveable()
      {
         Velocity = new Vector2(100, 100);
         MaxSpeed = 1;
      }

      // Properties
      public Vector2 Velocity { get; set; }

      // Angle geht von 0 bis 2 * Pi
      // 0 = rechts, Pi/2 = unten, Pi = links, Pi * 1,5 = oben
      public float Angle { get; set; }

      // AngleDegree geht von 0 bis 360
      // 0 = rechts, 90 = unten, 180 = links, 270 = oben
      public int AngleDegree {
         get {
            return (int)(Angle * 180 / Math.PI);
         }
         set {
            Angle = (float)(value * Math.PI / 180);
         } }
      public int MaxSpeed { get; set; }

      // Methoden
      public IMove moveBehavior { get; set; }

   }
}
