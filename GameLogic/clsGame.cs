using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Octo.Objects;

namespace Octo.GameLogic
{
   public class clsGame
   {
      // Konstruktor
      public clsGame(System.Drawing.Size screenSize) {
         try
         {
            this.ScreenSize = screenSize;
            PlaygroundSize = new Size(2000, 2000);

            GameObjectList = new List<clsGameObject>();
            Backcolor = Color.LightBlue;

            // Hintergrund hinzufügen
            clsBackground Background = new clsBackground();
            Background.Height = ScreenSize.Height;
            Background.Width = ScreenSize.Width;
            Background.Image = Image.FromFile("./Assets/Grass_1.png");
            GameObjectList.Add(Background);

            // Spielobjekte hinzufügen
            clsSprite Ball1 = new clsSprite(10, 20, 100, 100, ScreenSize);
            Ball1.MaxSpeed = 150;
            Ball1.Angle = (float)Math.PI / 4;
            Ball1.Playgroundsize = screenSize;
            Ball1.moveBehavior = new clsAutomaticMove();
            Ball1.SpriteImage = Image.FromFile("./Assets/Ball.png");
            GameObjectList.Add(Ball1);

            clsSprite Ball2 = new clsSprite(400, 200, 20, 20, ScreenSize);
            Ball2.moveBehavior = new clsManualMove();
            Ball2.MaxSpeed = 100;
            Ball2.SpriteImage = Image.FromFile("./Assets/Ball.png");
            GameObjectList.Add(Ball2);

         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
      }

      #region Properties
      public List<clsGameObject>  GameObjectList { get; set; }
      public Size ScreenSize{ get; set; }
      public Size PlaygroundSize { get; set; }
      public Color Backcolor { get; set; }
      public clsInput Input { get; set; }
      #endregion

      public void update(TimeSpan deltaTime)
      {
         try
         {
            // alle Objekte aus der Objektliste updaten
            foreach (clsGameObject Obj in GameObjectList)
            {
               Obj.Input = Input;
               Obj.update(deltaTime);
            }
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
      }
   }

}
