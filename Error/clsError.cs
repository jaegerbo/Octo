using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo
{
   class clsError
   {
      public clsError(string message)
      {
         System.Diagnostics.Debugger.Break();
      }
      public clsError(Exception ex)
      {
         System.Diagnostics.Debugger.Break();
      }
   }
}
