using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using Octo.Input;
using System.Windows.Forms;

namespace Octo
{
   public class clsInput
   {
      // Konstruktor
      public clsInput() {      }

      // Properties
      public bool North { get; set; }
      public bool West { get; set; }
      public bool South { get; set; }
      public bool East { get; set; }

      // Methoden
      public void addKey(clsKeyInfo KeyInfo)
      {
         switch (KeyInfo.Key)
         {
            case Keys.A:
               West = KeyInfo.Down;
               break;
            case Keys.D:
               East = KeyInfo.Down;
               break;
            case Keys.W:
               North = KeyInfo.Down;
               break;
            case Keys.S:
               South = KeyInfo.Down;
               //Console.WriteLine("Y = " + Y.ToString());
               break;
         }
      }
   }
}
