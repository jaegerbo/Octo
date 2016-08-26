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
using Octo.Map;

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
      public clsGame Game;
      public clsMap Map;
      public int MapOffsetX = 0;
      public int MapOffsetY = 0;

      // interne Variablen
      private Dictionary<string, Image> ImageList = new Dictionary<string, Image>();
      private Image loadImageFromList(string Filename)
      {
         Image Image = null;
         if (ImageList.ContainsKey(Filename))
         {
            ImageList.TryGetValue(Filename, out Image );
         }
         else
         {
            Image = Image.FromFile(Filename);
            if (Image != null)
            {
               ImageList.Add(Filename, Image);
            }
         }
         return Image;
      }

      // Methoden
      protected override void OnPaint(PaintEventArgs e)
      {
         try
         {
            if (Game == null) return;

            e.Graphics.Clear(Game.Backcolor);

            // Map rendern
            renderMap(e.Graphics);

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

      private void renderMap(Graphics gr)
      {
         try
         {
            foreach(clsMapCell MapCell in Map.MapCells)
            {
               // prüfen, ob die Zelle oder Teile von ihr sichtbar sind
               if ((MapCell.MapCellX >= MapOffsetX && MapCell.MapCellX <= MapOffsetX- this.Size.Width) ||
                   (MapCell.MapCellX + Map.CELLSIZE >= MapOffsetX && MapCell.MapCellX + Map.CELLSIZE <= MapOffsetX - this.Size.Width) ||
                   (MapCell.MapCellY >= MapOffsetY && MapCell.MapCellY <= MapOffsetY - this.Size.Height ) ||
                   (MapCell.MapCellY + Map.CELLSIZE >= MapOffsetY && MapCell.MapCellY + Map.CELLSIZE <= MapOffsetY - this.Size.Height ))
               {
                  // wenn ja wird sie, oder Teile von ihr gerendert
                  Image Image = loadImageFromList(MapCell.BackgroundFile);
                  gr.DrawImage(Image,
                               new Rectangle(MapCell.MapCellX + Map.CELLSIZE - MapOffsetX,
                                             MapCell.MapCellY + Map.CELLSIZE - MapOffsetY,
                                             MapCell.MapCellX + Map.CELLSIZE,
                                             MapCell.MapCellY + Map.CELLSIZE),
                               new Rectangle(),
                                       GraphicsUnit.Pixel);

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
