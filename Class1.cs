using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyForm : Form
{
    protected override void OnPaint(PaintEventArgs e)
    {
       // base.OnPaint(e);

        // إنشاء كائن GraphicsPath
        GraphicsPath path = new GraphicsPath();

        // إضافة قوس إلى المسار
        path.AddArc(100,100, 100, 100, 0, 360);

        // رسم المسار
        e.Graphics.DrawPath(Pens.Brown, path);
    }
}
