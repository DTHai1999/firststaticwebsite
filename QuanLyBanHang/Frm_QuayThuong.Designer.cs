namespace QuanLyBanHang
{
    partial class Frm_QuayThuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuayThuong));
            this.picturegift = new System.Windows.Forms.PictureBox();
            this.btnboctham = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturegift)).BeginInit();
            this.SuspendLayout();
            // 
            // picturegift
            // 
            this.picturegift.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picturegift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturegift.ErrorImage = null;
            this.picturegift.InitialImage = null;
            this.picturegift.Location = new System.Drawing.Point(102, 81);
            this.picturegift.Name = "picturegift";
            this.picturegift.Size = new System.Drawing.Size(526, 222);
            this.picturegift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturegift.TabIndex = 0;
            this.picturegift.TabStop = false;
            this.picturegift.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picturegift_LoadCompleted);
            this.picturegift.Click += new System.EventHandler(this.picturegift_Click);
            // 
            // btnboctham
            // 
            this.btnboctham.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnboctham.Location = new System.Drawing.Point(291, 338);
            this.btnboctham.Name = "btnboctham";
            this.btnboctham.Size = new System.Drawing.Size(116, 41);
            this.btnboctham.TabIndex = 1;
            this.btnboctham.Text = "Bốc thăm";
            this.btnboctham.UseVisualStyleBackColor = true;
            this.btnboctham.Click += new System.EventHandler(this.btnboctham_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stop.Location = new System.Drawing.Point(434, 338);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(127, 41);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Restart";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(655, 13);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 17);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = ".";
            // 
            // Frm_QuayThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.btnboctham);
            this.Controls.Add(this.picturegift);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_QuayThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bốc thăm trúng thưởng:";
            this.Load += new System.EventHandler(this.QuayThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturegift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturegift;
        private System.Windows.Forms.Button btnboctham;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label lblDateTime;
    }
}