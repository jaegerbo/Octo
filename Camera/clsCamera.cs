using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octo.GameLogic;
using Octo.Basics;
using System.Diagnostics;
using Octo.Input;
using System.Drawing.Imaging;

namespace Octo.Camera
{
   public partial class clsCamera : UserControl
   {
      // Konstruktor
      public clsCamera()
      {
         InitializeComponent();
      }

      // Properties
      public clsGame Game{ get; set; }
      public int MapOffsetX = 0;
      public int MapOffsetY = 0;

      // Methoden
      protected override void OnPaint(PaintEventArgs e)
      {
         try
         {
            if (Game == null) return;

            e.Graphics.Clear(Game.Backcolor);

            // alle Objekte aus der Objektliste updaten
            foreach (clsGameObject Obj in Game.GameObjectList)
            {
               if (Obj.SpriteImage != null)
               {
                  e.Graphics.DrawImage(Obj.SpriteImage, 
                                       new Rectangle((int)Obj.destRectangle.X, (int)Obj.destRectangle.Y, (int)Obj.destRectangle.Width, (int)Obj.destRectangle.Height),
                                       new Rectangle((int)Obj.srcRectangle.X, (int)Obj.srcRectangle.Y, (int)Obj.srcRectangle.Width, (int)Obj.srcRectangle.Height),
                                       GraphicsUnit.Pixel);
               }
               //Obj.render(e.Graphics );
            }
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
         base.OnPaint(e);
      }
   }
}
