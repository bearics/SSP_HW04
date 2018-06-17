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
            System.Drawing.Imaging.ImageFormat fmt=null;
            pnlPaint.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPaint.Width, pnlPaint.Height));
            sfd.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일(*.jpeg)|*.jpeg|비트맵 파일(*.bmp)|*bmp|인터넷 파일(*.png)|*png"; ;
            sfd.AddExtension = true;

            if (mImg != null)
                mImg.Dispose();
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch(sfd.FilterIndex)
                    {
                        case 1:
                        case 2:
                            fmt = System.Drawing.Imaging.ImageFormat.Jpeg;
                            if (!sfd.FileName.Contains("."))
                                sfd.FileName += ".jpeg";
                            break;
                        case 3:
                            fmt = System.Drawing.Imaging.ImageFormat.Bmp;
                            if (!sfd.FileName.Contains("."))
                                sfd.FileName += ".bmp";
                            break;
                        case 4:
                            fmt = System.Drawing.Imaging.ImageFormat.Png;
                            if (!sfd.FileName.Contains("."))
                                sfd.FileName += ".png";
                            break;
                        default:
                            MessageBox.Show("Cannot save in that extensions");
                            break;
                    }


                    if (File.Exists(mImgPath) && mImgPath == sfd.FileName)
                    {
                        File.Delete(mImgPath);
                    }

                    if( fmt != null)
                    {
                        bmp.Save(sfd.FileName, fmt);
                        mImg = Image.FromFile(sfd.FileName);
                        mImgPath = sfd.FileName;
                        this.Text = Path.GetFileName(sfd.FileName);
                    }
                }
            }
            finally
            {
                bmp.Dispose();
            }

        }

        public void SaveImg1()
        {
            Bitmap bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
            System.Drawing.Imaging.ImageFormat fmt = null;
            pnlPaint.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPaint.Width, pnlPaint.Height));
            sfd.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일(*.jpeg)|*.jpeg|비트맵 파일(*.bmp)|*bmp|인터넷 파일(*.png)|*png"; ;
            sfd.AddExtension = true;
            if (mImg != null)
                mImg.Dispose();
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fmt = System.Drawing.Imaging.ImageFormat.Jpeg;
                    if (!sfd.FileName.Contains("."))
                        sfd.FileName += ".jpeg";
                    if (File.Exists(mImgPath) && mImgPath == sfd.FileName)
                    {
                        File.Delete(mImgPath);
                    }
                    if (fmt != null)
                    {
                        bmp.Save(sfd.FileName, fmt);
                        mImg = Image.FromFile(sfd.FileName);
                        mImgPath = sfd.FileName;
                        this.Text = Path.GetFileName(sfd.FileName);
                    }
                }
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
            pnlPaint.Invalidate(true);
            pnlPaint.Update();
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

        private void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<PaintForm> childs = ((MainForm)MdiParent).mChild;
            foreach (PaintForm child in childs)
            {
                if(child == this)
                {
                    childs.Remove(this);
                    break;
                }
            }
            if (childs.Count == 0)
                ((MainForm)MdiParent).Disable();

        }
    }
}
