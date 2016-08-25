using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Objects
{
   class clsBox : clsGameObject 
   {
      public clsBox():base()
      {

      }

      public override void update(TimeSpan deltaTime)
      {
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
