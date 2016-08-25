using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.GameLogic
{
   class clsBackground : clsGameObject 
   {
      public Image Image { get; set; }
      //public override void render(Graphics gr)
      //{
      //   base.render(gr);

      //   // zuerst wird die Hintergrundfarbe gerendert
      //   gr.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);

      //   // danach das Image, wenn vorhanden
      //   if (Image != null)
      //   {
      //      TextureBrush texBrush = new TextureBrush(Image);
      //      gr.FillRectangle(texBrush, 0, 0, Width, Height);
      //   }
      //}
   }
}
