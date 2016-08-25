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
using System.Diagnostics;
using Octo.Input;
using System.Drawing.Imaging;

namespace Octo
{
   public partial class ctrlRenderScreen : UserControl
   {
      // Konstruktor
      public ctrlRenderScreen()
      {
         InitializeComponent();
      }

      // Properties
      public clsGame Game{ get; set; }

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
                  e.Graphics.DrawImage(Obj.SpriteImage, Obj.destRectangle , Obj.srcRectangle , GraphicsUnit.Pixel);
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
