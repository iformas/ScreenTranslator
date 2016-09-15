using Emgu.CV.OCR;

using System.Drawing;

namespace ScreenTranslator.WinFroms
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCaptureArea = new System.Windows.Forms.PictureBox();
            this.rtxCapturedText = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.splSeparator = new System.Windows.Forms.SplitContainer();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.grbControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptureArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splSeparator)).BeginInit();
            this.splSeparator.Panel1.SuspendLayout();
            this.splSeparator.Panel2.SuspendLayout();
            this.splSeparator.SuspendLayout();
            this.grbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCaptureArea
            // 
            this.picCaptureArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picCaptureArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCaptureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCaptureArea.Location = new System.Drawing.Point(0, 0);
            this.picCaptureArea.Name = "picCaptureArea";
            this.picCaptureArea.Size = new System.Drawing.Size(455, 174);
            this.picCaptureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCaptureArea.TabIndex = 0;
            this.picCaptureArea.TabStop = false;
            // 
            // rtxCapturedText
            // 
            this.rtxCapturedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxCapturedText.Location = new System.Drawing.Point(0, 0);
            this.rtxCapturedText.Name = "rtxCapturedText";
            this.rtxCapturedText.Size = new System.Drawing.Size(455, 210);
            this.rtxCapturedText.TabIndex = 4;
            this.rtxCapturedText.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(24, 25);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(359, 25);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // splSeparator
            // 
            this.splSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSeparator.Location = new System.Drawing.Point(0, 0);
            this.splSeparator.Name = "splSeparator";
            this.splSeparator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splSeparator.Panel1
            // 
            this.splSeparator.Panel1.Controls.Add(this.picCaptureArea);
            // 
            // splSeparator.Panel2
            // 
            this.splSeparator.Panel2.Controls.Add(this.rtxCapturedText);
            this.splSeparator.Size = new System.Drawing.Size(455, 388);
            this.splSeparator.SplitterDistance = 174;
            this.splSeparator.TabIndex = 7;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(267, 27);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(74, 21);
            this.cmbTo.TabIndex = 7;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(154, 27);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(74, 21);
            this.cmbFrom.TabIndex = 8;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(118, 30);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(30, 13);
            this.From.TabIndex = 9;
            this.From.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(241, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "To";
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.btnTranslate);
            this.grbControls.Controls.Add(this.lblTo);
            this.grbControls.Controls.Add(this.cmbFrom);
            this.grbControls.Controls.Add(this.btnRead);
            this.grbControls.Controls.Add(this.cmbTo);
            this.grbControls.Controls.Add(this.From);
            this.grbControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbControls.Location = new System.Drawing.Point(0, 320);
            this.grbControls.Name = "grbControls";
            this.grbControls.Size = new System.Drawing.Size(455, 68);
            this.grbControls.TabIndex = 11;
            this.grbControls.TabStop = false;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 388);
            this.Controls.Add(this.grbControls);
            this.Controls.Add(this.splSeparator);
            this.MinimumSize = new System.Drawing.Size(471, 427);
            this.Name = "frmMainWindow";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenTranslator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptureArea)).EndInit();
            this.splSeparator.Panel1.ResumeLayout(false);
            this.splSeparator.Panel1.PerformLayout();
            this.splSeparator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splSeparator)).EndInit();
            this.splSeparator.ResumeLayout(false);
            this.grbControls.ResumeLayout(false);
            this.grbControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCaptureArea;
        private System.Windows.Forms.RichTextBox rtxCapturedText;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.SplitContainer splSeparator;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.GroupBox grbControls;
    }
}

