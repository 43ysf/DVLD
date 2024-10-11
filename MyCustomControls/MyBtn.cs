using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlTypes;

namespace DVLD.MyCustomControls
{
    public class MyBtn : Button
    {
        private int _BorderSize = 0;
        private int _BorderRadius = 40;
        private Color _BorderColor = Color.White;

        public MyBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        //private GraphicsPath GetFigurePath(RectangleF rect, float raduis)
        //{

        //}

         
    }
}
