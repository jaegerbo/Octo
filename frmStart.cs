using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octo.GameLogic;
using System.Diagnostics;

namespace Octo
{
   public partial class frmStart : Form
   {
      private clsGame _Game;
      private Stopwatch _watch = new Stopwatch();
      private clsInput _Input;

      // Konstruktor
      public frmStart()
      {
         InitializeComponent();
         _Input = new clsInput();
      }

      // Methoden
      private void frmStart_Load(object sender, EventArgs e)
      {
         try {
            _watch.Start();
            _Game = new clsGame(Camera);
            _Game.Input = _Input;
            Camera.Game = _Game;
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
      }

      #region Events
      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         try
         {
            // das drücken der Richtungstasten abfangen
            _Input.addKey(new Input.clsKeyInfo(keyData, true));
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
         return base.ProcessCmdKey(ref msg, keyData);
      }
      protected override void OnKeyUp(KeyEventArgs e)
      {
         // das drücken der Richtungstasten abfangen
         _Input.addKey(new Input.clsKeyInfo(e.KeyCode , false));
      }
      protected override void OnResize(EventArgs e)
      {
         if (_Game != null) {
            _Game.ScreenSize = Camera.ClientSize;
         }
         base.OnResize(e);
      }
      #endregion
      #region Menü
      private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }
      #endregion

      private void timerGameloop_Tick(object sender, EventArgs e)
      {
         // Gameloop
         try
         {
            _Game.update(_watch.Elapsed);
            Camera.Invalidate();

            _watch.Restart();
         }
         catch (Exception ex)
         {
            new clsError(ex);
         }
      }

   }
}
