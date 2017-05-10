namespace CyclicityGenerator
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.singleScanBtn = new System.Windows.Forms.Button();
            this.bulkScanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(156)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cyclicity Garbage Scanner";
            // 
            // singleScanBtn
            // 
            this.singleScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.singleScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleScanBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.singleScanBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.singleScanBtn.Location = new System.Drawing.Point(70, 137);
            this.singleScanBtn.Name = "singleScanBtn";
            this.singleScanBtn.Size = new System.Drawing.Size(543, 95);
            this.singleScanBtn.TabIndex = 1;
            this.singleScanBtn.Text = "Single Scan";
            this.singleScanBtn.UseVisualStyleBackColor = false;
            this.singleScanBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bulkScanBtn
            // 
            this.bulkScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bulkScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkScanBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.bulkScanBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(3)))));
            this.bulkScanBtn.Location = new System.Drawing.Point(70, 273);
            this.bulkScanBtn.Name = "bulkScanBtn";
            this.bulkScanBtn.Size = new System.Drawing.Size(543, 95);
            this.bulkScanBtn.TabIndex = 2;
            this.bulkScanBtn.Text = "Bulk Scan";
            this.bulkScanBtn.UseVisualStyleBackColor = false;
            this.bulkScanBtn.Click += new System.EventHandler(this.bulkScanBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bulkScanBtn);
            this.Controls.Add(this.singleScanBtn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(711, 474);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singleScanBtn;
        private System.Windows.Forms.Button bulkScanBtn;
    }
}
