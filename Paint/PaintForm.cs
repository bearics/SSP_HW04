using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    public partial class PaintForm : Form
    {
        public string mImgPath = null;
        public Image mImg;

        public PaintForm()
        {
            InitializeComponent();
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            //pnlPaint.Invalidate(true);
            //pnlPaint.Update();   
        }

        private void pnlPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlPaint.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if( mImg != null)
                g.DrawImage(mImg, new Point(0, 0));
        }

        public void saveImg()
        {
            Bitmap bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
            pnlPaint.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPaint.Width, pnlPaint.Height));

            if (mImg != null)
                mImg.Dispose();

            try
            {
                if(File.Exists(mImgPath))
                {
                    File.Delete(mImgPath);
                }
                System.Drawing.Imaging.ImageFormat fmt = System.Drawing.Imaging.ImageFormat.Jpeg;
                bmp.Save(mImgPath, fmt);
            }
            finally
            {
                bmp.Dispose();
            }

        }

    }
}
