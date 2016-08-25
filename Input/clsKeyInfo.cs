using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Octo.Input
{
   // Diese Klasse speichert Daten zu gedrückten Tasten
   public class clsKeyInfo
   {
      // interne Variablen
      Stopwatch watch;

      // Konstruktor
      public clsKeyInfo(Keys key, bool down)
      {
         Key = key;
         watch = new Stopwatch();
         Down = down;
         watch.Start();
      }

      // Properties
      public Keys Key { get; set; }
      public bool Down { get; set; }
      private long _Milliseconds = 0;
      public long MilliSeconds {
         get {
            _Milliseconds = watch.ElapsedMilliseconds;
            return _Milliseconds;
         }
         set { _Milliseconds = value; }
      }

      public override string ToString()
      {
         return Key.ToString() ;
      }
   }

   // zugehörige Liste
   public class clsKeyInfoListHt : Dictionary<Keys, clsKeyInfo> { }
}
