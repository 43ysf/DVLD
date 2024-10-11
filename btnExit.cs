// Decompiled with JetBrains decompiler
// Type: Morabaa_7_Setup_Project.ToolBox.btnExit
// Assembly: Morabaa 7 Setup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EBA454E2-6D80-42B2-9054-7C037782ACE2
// Assembly location: C:\Users\ZAIUN\Downloads\MorabaaSetup 2020-5\Morabaa 7 Setup.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Morabaa_7_Setup_Project.ToolBox
{
    partial class btnExit : Button
    {
        private IContainer components = (IContainer)null;

        public btnExit() => this.InitializeComponent();

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(pe.Graphics, this.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.Solid, Color.LightGray, 0, ButtonBorderStyle.Solid, Color.LightGray, 0, ButtonBorderStyle.Solid, Color.Red, 4, ButtonBorderStyle.Solid);
            this.Text = "خروج";
            this.Size = new Size(140, 40);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = Color.FromArgb(54, 71, 79);
            this.Cursor = Cursors.Hand;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Cairo", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ForeColor = Color.White;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
        }
    }
}