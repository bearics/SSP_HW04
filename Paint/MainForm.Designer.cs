namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.sideToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tsbPencil = new System.Windows.Forms.ToolStripButton();
            this.tsbPaint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbSquare = new System.Windows.Forms.ToolStripButton();
            this.tsbCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbThick = new System.Windows.Forms.ToolStripButton();
            this.tsbFill = new System.Windows.Forms.ToolStripButton();
            this.cldPaintColor = new System.Windows.Forms.ColorDialog();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.sideToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.이미지ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiNew.Text = "새로 만들기(N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpen.Text = "열기(O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Enabled = false;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(180, 22);
            this.tsmiSave.Text = "저장(S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "끝내기(X)";
            // 
            // 이미지ToolStripMenuItem
            // 
            this.이미지ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteImage});
            this.이미지ToolStripMenuItem.Name = "이미지ToolStripMenuItem";
            this.이미지ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.이미지ToolStripMenuItem.Text = "이미지";
            // 
            // tsmiDeleteImage
            // 
            this.tsmiDeleteImage.Enabled = false;
            this.tsmiDeleteImage.Name = "tsmiDeleteImage";
            this.tsmiDeleteImage.Size = new System.Drawing.Size(167, 22);
            this.tsmiDeleteImage.Text = "이미지 지우기(N)";
            // 
            // sideToolStrip
            // 
            this.sideToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbColor,
            this.tsbPencil,
            this.tsbPaint,
            this.toolStripSeparator1,
            this.tsbLine,
            this.tsbSquare,
            this.tsbCircle,
            this.toolStripSeparator2,
            this.tsbThick,
            this.tsbFill});
            this.sideToolStrip.Location = new System.Drawing.Point(0, 24);
            this.sideToolStrip.Name = "sideToolStrip";
            this.sideToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.sideToolStrip.Size = new System.Drawing.Size(32, 426);
            this.sideToolStrip.TabIndex = 1;
            this.sideToolStrip.Text = "toolStrip1";
            // 
            // tsbColor
            // 
            this.tsbColor.AutoSize = false;
            this.tsbColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(29, 29);
            this.tsbColor.Text = "toolStripButton1";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // tsbPencil
            // 
            this.tsbPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPencil.Image = ((System.Drawing.Image)(resources.GetObject("tsbPencil.Image")));
            this.tsbPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPencil.Name = "tsbPencil";
            this.tsbPencil.Size = new System.Drawing.Size(29, 20);
            this.tsbPencil.Text = "toolStripButton2";
            // 
            // tsbPaint
            // 
            this.tsbPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaint.Image")));
            this.tsbPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaint.Name = "tsbPaint";
            this.tsbPaint.Size = new System.Drawing.Size(27, 20);
            this.tsbPaint.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // tsbLine
            // 
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(27, 20);
            this.tsbLine.Text = "toolStripButton1";
            // 
            // tsbSquare
            // 
            this.tsbSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSquare.Image = ((System.Drawing.Image)(resources.GetObject("tsbSquare.Image")));
            this.tsbSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSquare.Name = "tsbSquare";
            this.tsbSquare.Size = new System.Drawing.Size(27, 20);
            this.tsbSquare.Text = "toolStripButton1";
            // 
            // tsbCircle
            // 
            this.tsbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsbCircle.Image")));
            this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCircle.Name = "tsbCircle";
            this.tsbCircle.Size = new System.Drawing.Size(27, 20);
            this.tsbCircle.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(27, 6);
            // 
            // tsbThick
            // 
            this.tsbThick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThick.Image = ((System.Drawing.Image)(resources.GetObject("tsbThick.Image")));
            this.tsbThick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThick.Name = "tsbThick";
            this.tsbThick.Size = new System.Drawing.Size(27, 20);
            this.tsbThick.Text = "toolStripButton1";
            // 
            // tsbFill
            // 
            this.tsbFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFill.Image = ((System.Drawing.Image)(resources.GetObject("tsbFill.Image")));
            this.tsbFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFill.Name = "tsbFill";
            this.tsbFill.Size = new System.Drawing.Size(27, 20);
            this.tsbFill.Text = "toolStripButton2";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "ofdOpenImage";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideToolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "그림판";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.sideToolStrip.ResumeLayout(false);
            this.sideToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteImage;
        private System.Windows.Forms.ToolStrip sideToolStrip;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ColorDialog cldPaintColor;
        private System.Windows.Forms.ToolStripButton tsbPencil;
        private System.Windows.Forms.ToolStripButton tsbPaint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbSquare;
        private System.Windows.Forms.ToolStripButton tsbCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbThick;
        private System.Windows.Forms.ToolStripButton tsbFill;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveImage;
    }
}

