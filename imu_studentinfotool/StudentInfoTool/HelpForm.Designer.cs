namespace StudentInfoTool
{
    partial class HelpForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.versioninfo = new System.Windows.Forms.Label();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // versioninfo
            // 
            this.versioninfo.AutoSize = true;
            this.versioninfo.Location = new System.Drawing.Point(58, 22);
            this.versioninfo.Name = "versioninfo";
            this.versioninfo.Size = new System.Drawing.Size(257, 12);
            this.versioninfo.TabIndex = 3;
            this.versioninfo.Text = "    学生信息表生成加密工具当前版本为v.1.0.";
            // 
            // pictureInfo
            // 
            this.pictureInfo.Image = global::imu_studentinfotool.Properties.Resources.ui_login_03_bg;
            this.pictureInfo.InitialImage = null;
            this.pictureInfo.Location = new System.Drawing.Point(5, 56);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(390, 158);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfo.TabIndex = 2;
            this.pictureInfo.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.versioninfo);
            this.Controls.Add(this.pictureInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帮助";
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.Label versioninfo;
    }
}

