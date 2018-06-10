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
        public bool mIsMouse = false;
        List<Tools> mDrawn = new List<Tools>();

        public PaintForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (mImg != null)
                g.DrawImage(mImg, new Point(0, 0));

            foreach(Tools tool in mDrawn)
            {
                switch (tool.mType)
                {
                    case ToolsType.Pen:
                        ((Pens)tool).Draw(g);
                        break;
                    case ToolsType.Brush:
                        ((Brushes)tool).Draw(g);
                        break;
                    case ToolsType.Line:
                        ((Lines)tool).Draw(g);
                        break;
                    case ToolsType.Square:
                        ((Squares)tool).Draw(g);
                        break;
                    case ToolsType.Circle:
                        ((Circles)tool).Draw(g);
                        break;
                }
            }
        }

        public void SaveImg()
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

        public void DeleteAll()
        {
            mImg = null;
            mDrawn.Clear();
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            mIsMouse = true;
            MainForm mainForm = (MainForm)MdiParent;
            Tools mainTool = mainForm.mTools;

            switch(mainTool.mType)
            {
                case ToolsType.Pen:
                    mDrawn.Add(new Pens(mainTool.mColor, new Point(e.X, e.Y)));
                    break;
                case ToolsType.Brush:
                    mDrawn.Add(new Brushes(mainTool.mColor, new Point(e.X, e.Y)));
                    break;
                case ToolsType.Line:
                    mDrawn.Add(new Lines(mainTool.mColor, mainTool.mThick, new Point(e.X, e.Y)));
                    break;
                case ToolsType.Square:
                    mDrawn.Add(new Squares(mainTool.mColor, mainTool.mThick, mainTool.mIsFill, new Point(e.X, e.Y)));
                    break;
                case ToolsType.Circle:
                    mDrawn.Add(new Circles(mainTool.mColor, mainTool.mThick, mainTool.mIsFill, new Point(e.X, e.Y)));
                    break;
            }

        }

        private void pnlPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if(mIsMouse )
            {
                Tools tool = mDrawn[mDrawn.Count - 1];
                switch (tool.mType)
                {
                    case ToolsType.Pen:
                        Pens pen = (Pens)tool;
                        pen.Add(new Point(e.X, e.Y));
                        break;
                    case ToolsType.Brush:
                        Brushes brush = (Brushes)tool;
                        brush.Add(new Point(e.X, e.Y));
                        break;
                    case ToolsType.Line:
                        Lines line = (Lines)tool;
                        line.Add(new Point(e.X, e.Y));
                        break;
                    case ToolsType.Square:
                        Squares square = (Squares)tool;
                        square.Add(new Point(e.X, e.Y));
                        break;
                    case ToolsType.Circle:
                        Circles circle = (Circles)tool;
                        circle.Add(new Point(e.X, e.Y));
                        break;
                }
                pnlPaint.Invalidate(true);
                pnlPaint.Update();
            }


        }

        private void pnlPaint_MouseUp(object sender, MouseEventArgs e)
        {
            mIsMouse = false;
        }

    }
}
