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
        List<PaintForm> child = new List<PaintForm>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {

            newPaint(null);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            ofdOpenImage.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일(*.jpeg)|*.jpeg";

            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                string path = ofdOpenImage.FileName;

                newPaint(path);
            }
        }

        private void newPaint(string imgPath)
        {
            child.Add(new PaintForm());
            PaintForm c = child[child.Count - 1];
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
                c.Width = c.mImg.Width + 16;
                c.Height = c.mImg.Height + 39;
            }
            c.Show();

            tsmiSave.Enabled = true;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            sfdSaveImage.Filter = "Images|*.jpeg;*jpg";
            
            if(sfdSaveImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string 
            }

            Form child = this.ActiveMdiChild;
                        
            ((PaintForm)child).saveImg();
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            if (cldPaintColor.ShowDialog() == DialogResult.OK)
                tsbColor.BackColor = cldPaintColor.Color;
        }
    }
}
