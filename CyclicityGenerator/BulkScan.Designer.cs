namespace CyclicityGenerator
{
    partial class BulkScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkScan));
            this.label1 = new System.Windows.Forms.Label();
            this.bulkScanBtn = new System.Windows.Forms.Button();
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disItems = new System.Windows.Forms.Label();
            this.BackHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bulk Scanner Mode";
            // 
            // bulkScanBtn
            // 
            this.bulkScanBtn.BackColor = System.Drawing.Color.White;
            this.bulkScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkScanBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.bulkScanBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.bulkScanBtn.Location = new System.Drawing.Point(461, 398);
            this.bulkScanBtn.Name = "bulkScanBtn";
            this.bulkScanBtn.Size = new System.Drawing.Size(225, 46);
            this.bulkScanBtn.TabIndex = 3;
            this.bulkScanBtn.Text = "Next";
            this.bulkScanBtn.UseVisualStyleBackColor = false;
            this.bulkScanBtn.Click += new System.EventHandler(this.bulkScanBtn_Click);
            // 
            // picWebCam
            // 
            this.picWebCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWebCam.BackColor = System.Drawing.Color.White;
            this.picWebCam.Location = new System.Drawing.Point(20, 80);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(414, 364);
            this.picWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebCam.TabIndex = 14;
            this.picWebCam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 19F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(470, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 108);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please click \"Next\"\r\nonce you\'re done\r\nscanning.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.label3.Location = new System.Drawing.Point(456, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Items scanned:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disItems
            // 
            this.disItems.AutoSize = true;
            this.disItems.BackColor = System.Drawing.Color.Transparent;
            this.disItems.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.disItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.disItems.Location = new System.Drawing.Point(670, 80);
            this.disItems.Name = "disItems";
            this.disItems.Size = new System.Drawing.Size(0, 28);
            this.disItems.TabIndex = 21;
            this.disItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackHome
            // 
            this.BackHome.BackColor = System.Drawing.Color.White;
            this.BackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackHome.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.BackHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.BackHome.Location = new System.Drawing.Point(461, 333);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(225, 46);
            this.BackHome.TabIndex = 22;
            this.BackHome.Text = "Home";
            this.BackHome.UseVisualStyleBackColor = false;
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // BulkScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.BackHome);
            this.Controls.Add(this.disItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWebCam);
            this.Controls.Add(this.bulkScanBtn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "BulkScan";
            this.Size = new System.Drawing.Size(711, 474);
            this.Load += new System.EventHandler(this.BulkScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bulkScanBtn;
        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label disItems;
        private System.Windows.Forms.Button BackHome;
    }
}
