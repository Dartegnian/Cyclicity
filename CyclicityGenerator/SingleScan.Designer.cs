namespace CyclicityGenerator
{
    partial class SingleScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleScan));
            this.label1 = new System.Windows.Forms.Label();
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single Scanner Mode";
            // 
            // picWebCam
            // 
            this.picWebCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWebCam.BackColor = System.Drawing.Color.White;
            this.picWebCam.Location = new System.Drawing.Point(21, 78);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(414, 364);
            this.picWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebCam.TabIndex = 17;
            this.picWebCam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 19F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(442, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 108);
            this.label2.TabIndex = 18;
            this.label2.Text = "Once done scanning,\r\nyou will automatically\r\ntaken to the next page\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackHome
            // 
            this.BackHome.BackColor = System.Drawing.Color.White;
            this.BackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackHome.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.BackHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.BackHome.Location = new System.Drawing.Point(461, 398);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(225, 46);
            this.BackHome.TabIndex = 19;
            this.BackHome.Text = "Home";
            this.BackHome.UseVisualStyleBackColor = false;
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // SingleScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.BackHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWebCam);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "SingleScan";
            this.Size = new System.Drawing.Size(711, 474);
            this.Load += new System.EventHandler(this.SingleScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackHome;
    }
}
