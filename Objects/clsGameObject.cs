using Octo.Basics;
using Octo.GameLogic;
using Octo.Map;
using Octo.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Octo
{
   public class clsGameObject
   {
      // Konstruktoren
      public clsGameObject() {
         XStart = 0; YStart = 0;
         X = XStart; Y = YStart;
         BackColor = Color.White;
         GameObjectList = new List<clsGameObject>();
      }
      public clsGameObject(int xStart, int yStart, int width, int height)
      {
         XStart = xStart; YStart = yStart;
         X = XStart; Y = YStart;
         Width = width; Height = height;
         BackColor = Color.White;
         GameObjectList = new List<clsGameObject>();
      }

      // Properties
      public float XStart { get; set; }
      public float X { get; set; }
      public float YStart { get; set; }
      public float Y { get; set; }
      public float Width { get; set; }
      public float Height { get; set; }
      //public Size Playgroundsize { get; set; }
      public clsMap Map;
      public Color BackColor { get; set; }
      private Image _SpriteImage = null;
      public Image SpriteImage { get { return _SpriteImage; }
         set {
            if (value != null)
            {
               _SpriteImage = value;
               destRectangle = new structRectangle(0, 0, _SpriteImage.Width, _SpriteImage.Height);
               srcRectangle = new structRectangle(0, 0, _SpriteImage.Width, _SpriteImage.Height);
            }
         }
      }
      public structRectangle destRectangle { get; set; }
      public structRectangle srcRectangle { get; set; }

      private List<clsGameObject> GameObjectList { get; }
      public clsGameObject  Parent { get; set; }

      public clsInput  Input { get; set; }

      // Methoden
      public virtual void update(TimeSpan deltaTime)
      {
         if (GameObjectList != null)
         {
            foreach (clsGameObject Obj in GameObjectList)
            {
               Obj.update(deltaTime);
            }
         }
      }
      //public virtual void render(Graphics gr) {
      //   if (GameObjectList != null)
      //   {
      //      foreach (clsGameObject Obj in GameObjectList)
      //      {
      //         Obj.render(gr);
      //      }
      //   }
      //}
      public List<clsGameObject> getObejctList()
      {
         return GameObjectList;
      }
      public clsGameObject addObjectToList(clsGameObject Object)
      {
         GameObjectList.Add(Object);
         return this;
      }
      public Boolean removeObjectFromList(clsGameObject Object)
      {
         if( GameObjectList.Contains(Object ) == true)
         {
            GameObjectList.Remove(Object);
            return true;
         }
         else
         {
            return false;
         }
      }

      public IMove moveBehavior { get; set; }

   }
}
