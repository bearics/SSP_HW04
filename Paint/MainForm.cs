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
    public partial class MainForm : Form
    {
        public List<PaintForm> mChild = new List<PaintForm>();
        public Tools mTools = new Tools();

        public MainForm()
        {
            InitializeComponent();

            this.UpdateStyles();
        }


        private void tsmiNew_Click(object sender, EventArgs e)
        {

            newPaint(null);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            ofdOpenImage.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일(*.jpeg)|*.jpeg|비트맵 파일(*.bmp)|*bmp|인터넷 파일(*.png)|*png";

            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                string path = ofdOpenImage.FileName;

                newPaint(path);
            }
        }

        private void newPaint(string imgPath)
        {
            mChild.Add(new PaintForm());
            PaintForm c = mChild[mChild.Count - 1];
            c.MdiParent = this;
            c.mImgPath = imgPath;
            if (c.mImgPath == null)
            { // new file
                c.Text = "제목 없음";
                c.WindowState = FormWindowState.Maximized;
            }
            else
            {
                c.Text = Path.GetFileName(imgPath);
                c.mImg = Image.FromFile(imgPath);
                c.WindowState = FormWindowState.Normal;
                c.Width = c.mImg.Width + 16;
                c.Height = c.mImg.Height + 39;
            }
            c.Show();

            tsmiDeleteImage.Enabled = true;
            tsmiSave.Enabled = true;
        }

        public void Disable()
        {
            tsmiSave.Enabled = false;
            tsmiDeleteImage.Enabled = false;

        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {

            Form child = this.ActiveMdiChild;                        
            ((PaintForm)child).SaveImg();
            
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            if (cldPaintColor.ShowDialog() == DialogResult.OK)
            {
                tsbColor.BackColor = cldPaintColor.Color;
                mTools.mColor = cldPaintColor.Color;
            }
        }


        private void tsbPencil_Click(object sender, EventArgs e)
        {
            mTools.mType = ToolsType.Pen;
            UncheckedAll(sender);
        }

        private void tsbPaint_Click(object sender, EventArgs e)
        {
            mTools.mType = ToolsType.Brush;
            UncheckedAll(sender);
        }

        private void tsbLine_Click(object sender, EventArgs e)
        {
            mTools.mType = ToolsType.Line;
            UncheckedAll(sender);
        }

        private void tsbSquare_Click(object sender, EventArgs e)
        {
            mTools.mType = ToolsType.Square;
            UncheckedAll(sender);
        }

        private void tsbCircle_Click(object sender, EventArgs e)
        {
            mTools.mType = ToolsType.Circle;
            UncheckedAll(sender);
        }

        private void tsbThick_Click(object sender, EventArgs e)
        {
            pnlThick.Visible = true;
        }

        private void tsbFill_Click(object sender, EventArgs e)
        {
            pnlFill.Visible = true;
        }

        private void btnThick_Click(object sender, EventArgs e)
        {
            mTools.mThick = Convert.ToInt32(((Button)sender).Text);
            pnlThick.Visible = false;
        }

        private void btnNotFill_Click(object sender, EventArgs e)
        {
            mTools.mIsFill = false;
            pnlFill.Visible = false;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            mTools.mIsFill = true;
            pnlFill.Visible = false;
        }
        
        private void UncheckedAll( Object sender)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            tsbPencil.Checked = false;
            tsbPaint.Checked = false;
            tsbLine.Checked = false;
            tsbSquare.Checked = false;
            tsbCircle.Checked = false;

            btn.Checked = true;
        }

        private void tsmiDeleteImage_Click(object sender, EventArgs e)
        {
            Form child = this.ActiveMdiChild;
            ((PaintForm)child).DeleteAll();
        }
    }
}
