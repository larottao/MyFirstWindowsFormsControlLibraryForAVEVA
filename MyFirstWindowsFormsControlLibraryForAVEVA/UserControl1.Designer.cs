namespace MyFirstWindowsFormsControlLibraryForAVEVA
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.pilotLightRed = new System.Windows.Forms.PictureBox();
            this.pilotLightYellow = new System.Windows.Forms.PictureBox();
            this.pilotLightGreen = new System.Windows.Forms.PictureBox();
            this.pilotLightBlue = new System.Windows.Forms.PictureBox();
            this.pilotLightWhite = new System.Windows.Forms.PictureBox();
            this.panelFaceplate = new System.Windows.Forms.Panel();
            this.buttonWhite = new System.Windows.Forms.Label();
            this.buttonBlue = new System.Windows.Forms.Label();
            this.buttonGreen = new System.Windows.Forms.Label();
            this.buttonYellow = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightWhite)).BeginInit();
            this.panelFaceplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Ugly PLC Test Setup";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pilotLightRed
            // 
            this.pilotLightRed.Image = ((System.Drawing.Image)(resources.GetObject("pilotLightRed.Image")));
            this.pilotLightRed.Location = new System.Drawing.Point(497, 202);
            this.pilotLightRed.Name = "pilotLightRed";
            this.pilotLightRed.Size = new System.Drawing.Size(70, 98);
            this.pilotLightRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilotLightRed.TabIndex = 8;
            this.pilotLightRed.TabStop = false;
            // 
            // pilotLightYellow
            // 
            this.pilotLightYellow.Image = ((System.Drawing.Image)(resources.GetObject("pilotLightYellow.Image")));
            this.pilotLightYellow.Location = new System.Drawing.Point(564, 201);
            this.pilotLightYellow.Name = "pilotLightYellow";
            this.pilotLightYellow.Size = new System.Drawing.Size(63, 105);
            this.pilotLightYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilotLightYellow.TabIndex = 9;
            this.pilotLightYellow.TabStop = false;
            // 
            // pilotLightGreen
            // 
            this.pilotLightGreen.Image = ((System.Drawing.Image)(resources.GetObject("pilotLightGreen.Image")));
            this.pilotLightGreen.Location = new System.Drawing.Point(624, 191);
            this.pilotLightGreen.Name = "pilotLightGreen";
            this.pilotLightGreen.Size = new System.Drawing.Size(63, 115);
            this.pilotLightGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilotLightGreen.TabIndex = 10;
            this.pilotLightGreen.TabStop = false;
            // 
            // pilotLightBlue
            // 
            this.pilotLightBlue.Image = ((System.Drawing.Image)(resources.GetObject("pilotLightBlue.Image")));
            this.pilotLightBlue.Location = new System.Drawing.Point(690, 201);
            this.pilotLightBlue.Name = "pilotLightBlue";
            this.pilotLightBlue.Size = new System.Drawing.Size(56, 99);
            this.pilotLightBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilotLightBlue.TabIndex = 11;
            this.pilotLightBlue.TabStop = false;
            // 
            // pilotLightWhite
            // 
            this.pilotLightWhite.Image = ((System.Drawing.Image)(resources.GetObject("pilotLightWhite.Image")));
            this.pilotLightWhite.Location = new System.Drawing.Point(747, 210);
            this.pilotLightWhite.Name = "pilotLightWhite";
            this.pilotLightWhite.Size = new System.Drawing.Size(54, 75);
            this.pilotLightWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilotLightWhite.TabIndex = 12;
            this.pilotLightWhite.TabStop = false;
            // 
            // panelFaceplate
            // 
            this.panelFaceplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFaceplate.BackgroundImage")));
            this.panelFaceplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFaceplate.Controls.Add(this.buttonWhite);
            this.panelFaceplate.Controls.Add(this.buttonBlue);
            this.panelFaceplate.Controls.Add(this.buttonGreen);
            this.panelFaceplate.Controls.Add(this.buttonYellow);
            this.panelFaceplate.Controls.Add(this.buttonRed);
            this.panelFaceplate.Controls.Add(this.pilotLightWhite);
            this.panelFaceplate.Controls.Add(this.pilotLightBlue);
            this.panelFaceplate.Controls.Add(this.pilotLightRed);
            this.panelFaceplate.Controls.Add(this.pilotLightGreen);
            this.panelFaceplate.Controls.Add(this.pilotLightYellow);
            this.panelFaceplate.Location = new System.Drawing.Point(30, 106);
            this.panelFaceplate.Name = "panelFaceplate";
            this.panelFaceplate.Size = new System.Drawing.Size(1093, 489);
            this.panelFaceplate.TabIndex = 13;
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.Transparent;
            this.buttonWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWhite.Location = new System.Drawing.Point(763, 130);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(46, 47);
            this.buttonWhite.TabIndex = 17;
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Transparent;
            this.buttonBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue.Location = new System.Drawing.Point(698, 130);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(46, 47);
            this.buttonBlue.TabIndex = 16;
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Transparent;
            this.buttonGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen.Location = new System.Drawing.Point(635, 130);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(46, 47);
            this.buttonGreen.TabIndex = 15;
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Transparent;
            this.buttonYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYellow.Location = new System.Drawing.Point(572, 129);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(46, 47);
            this.buttonYellow.TabIndex = 14;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Transparent;
            this.buttonRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRed.Location = new System.Drawing.Point(506, 129);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(46, 47);
            this.buttonRed.TabIndex = 13;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFaceplate);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1153, 625);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotLightWhite)).EndInit();
            this.panelFaceplate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pilotLightRed;
        private System.Windows.Forms.PictureBox pilotLightYellow;
        private System.Windows.Forms.PictureBox pilotLightGreen;
        private System.Windows.Forms.PictureBox pilotLightBlue;
        private System.Windows.Forms.PictureBox pilotLightWhite;
        private System.Windows.Forms.Panel panelFaceplate;
        private System.Windows.Forms.Label buttonBlue;
        private System.Windows.Forms.Label buttonGreen;
        private System.Windows.Forms.Label buttonYellow;
        private System.Windows.Forms.Label buttonRed;
        private System.Windows.Forms.Label buttonWhite;
    }
}
