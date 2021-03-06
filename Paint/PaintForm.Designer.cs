﻿namespace Paint
{
    partial class PaintForm
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
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.pnlPaint = new Paint.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaint.Location = new System.Drawing.Point(0, 0);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(800, 450);
            this.pnlPaint.TabIndex = 0;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseMove);
            this.pnlPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseUp);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPaint);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaintForm_FormClosing);
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel pnlPaint;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}