namespace Octo
{
   partial class frmStart
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusKoordinaten = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.timerGameloop = new System.Windows.Forms.Timer(this.components);
         this.ctrlRenderScreen = new Octo.ctrlRenderScreen();
         this.statusStrip.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusKoordinaten});
         this.statusStrip.Location = new System.Drawing.Point(0, 534);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Size = new System.Drawing.Size(1032, 22);
         this.statusStrip.TabIndex = 0;
         this.statusStrip.Text = "statusStrip1";
         // 
         // toolStripStatusKoordinaten
         // 
         this.toolStripStatusKoordinaten.Name = "toolStripStatusKoordinaten";
         this.toolStripStatusKoordinaten.Size = new System.Drawing.Size(0, 17);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // dateiToolStripMenuItem
         // 
         this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
         this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
         this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
         this.dateiToolStripMenuItem.Text = "Datei";
         // 
         // schließenToolStripMenuItem
         // 
         this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
         this.schließenToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
         this.schließenToolStripMenuItem.Text = "schließen";
         this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
         // 
         // timerGameloop
         // 
         this.timerGameloop.Enabled = true;
         this.timerGameloop.Interval = 25;
         this.timerGameloop.Tag = "1000 msec / 25 mSec = 40 FpS";
         this.timerGameloop.Tick += new System.EventHandler(this.timerGameloop_Tick);
         // 
         // ctrlRenderScreen
         // 
         this.ctrlRenderScreen.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlRenderScreen.Game = null;
         this.ctrlRenderScreen.Location = new System.Drawing.Point(0, 24);
         this.ctrlRenderScreen.Name = "ctrlRenderScreen";
         this.ctrlRenderScreen.Size = new System.Drawing.Size(1032, 510);
         this.ctrlRenderScreen.TabIndex = 2;
         // 
         // frmStart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1032, 556);
         this.Controls.Add(this.ctrlRenderScreen);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.menuStrip1);
         this.KeyPreview = true;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "frmStart";
         this.Text = "Octo";
         this.Load += new System.EventHandler(this.frmStart_Load);
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
      private ctrlRenderScreen ctrlRenderScreen;
      private System.Windows.Forms.Timer timerGameloop;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusKoordinaten;
   }
}

