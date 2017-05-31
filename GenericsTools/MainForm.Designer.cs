namespace GenericsTools
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
            this.mainTab = new System.Windows.Forms.TabControl();
            this.idTab = new System.Windows.Forms.TabPage();
            this.chbUuidTime = new System.Windows.Forms.CheckBox();
            this.txtIdResult = new System.Windows.Forms.TextBox();
            this.lblIdCount = new System.Windows.Forms.Label();
            this.txtIdCount = new System.Windows.Forms.TextBox();
            this.btnBuildId = new System.Windows.Forms.Button();
            this.chbDeleteIdLine = new System.Windows.Forms.CheckBox();
            this.chbIdUpper = new System.Windows.Forms.CheckBox();
            this.md5Tab = new System.Windows.Forms.TabPage();
            this.txtMd5Upper = new System.Windows.Forms.TextBox();
            this.lblMd5Upper = new System.Windows.Forms.Label();
            this.txtMd5Lower = new System.Windows.Forms.TextBox();
            this.lblMd5Lower = new System.Windows.Forms.Label();
            this.btnBuildMd5 = new System.Windows.Forms.Button();
            this.txtMd5Source = new System.Windows.Forms.TextBox();
            this.lblMd5Source = new System.Windows.Forms.Label();
            this.mainTab.SuspendLayout();
            this.idTab.SuspendLayout();
            this.md5Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.idTab);
            this.mainTab.Controls.Add(this.md5Tab);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(0, 0);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(576, 407);
            this.mainTab.TabIndex = 0;
            // 
            // idTab
            // 
            this.idTab.BackColor = System.Drawing.Color.Transparent;
            this.idTab.Controls.Add(this.chbUuidTime);
            this.idTab.Controls.Add(this.txtIdResult);
            this.idTab.Controls.Add(this.lblIdCount);
            this.idTab.Controls.Add(this.txtIdCount);
            this.idTab.Controls.Add(this.btnBuildId);
            this.idTab.Controls.Add(this.chbDeleteIdLine);
            this.idTab.Controls.Add(this.chbIdUpper);
            this.idTab.Location = new System.Drawing.Point(4, 22);
            this.idTab.Name = "idTab";
            this.idTab.Padding = new System.Windows.Forms.Padding(3);
            this.idTab.Size = new System.Drawing.Size(568, 381);
            this.idTab.TabIndex = 0;
            this.idTab.Text = "UUID生成";
            // 
            // chbUuidTime
            // 
            this.chbUuidTime.AutoSize = true;
            this.chbUuidTime.Location = new System.Drawing.Point(158, 17);
            this.chbUuidTime.Name = "chbUuidTime";
            this.chbUuidTime.Size = new System.Drawing.Size(84, 16);
            this.chbUuidTime.TabIndex = 6;
            this.chbUuidTime.Text = "带时间因子";
            this.chbUuidTime.UseVisualStyleBackColor = true;
            // 
            // txtIdResult
            // 
            this.txtIdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdResult.Location = new System.Drawing.Point(19, 66);
            this.txtIdResult.Multiline = true;
            this.txtIdResult.Name = "txtIdResult";
            this.txtIdResult.ReadOnly = true;
            this.txtIdResult.Size = new System.Drawing.Size(531, 296);
            this.txtIdResult.TabIndex = 5;
            // 
            // lblIdCount
            // 
            this.lblIdCount.AutoSize = true;
            this.lblIdCount.Location = new System.Drawing.Point(17, 42);
            this.lblIdCount.Name = "lblIdCount";
            this.lblIdCount.Size = new System.Drawing.Size(29, 12);
            this.lblIdCount.TabIndex = 4;
            this.lblIdCount.Text = "数量";
            // 
            // txtIdCount
            // 
            this.txtIdCount.Location = new System.Drawing.Point(52, 39);
            this.txtIdCount.MaxLength = 2;
            this.txtIdCount.Name = "txtIdCount";
            this.txtIdCount.Size = new System.Drawing.Size(100, 21);
            this.txtIdCount.TabIndex = 3;
            this.txtIdCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCount_KeyPress);
            // 
            // btnBuildId
            // 
            this.btnBuildId.Location = new System.Drawing.Point(158, 37);
            this.btnBuildId.Name = "btnBuildId";
            this.btnBuildId.Size = new System.Drawing.Size(75, 23);
            this.btnBuildId.TabIndex = 2;
            this.btnBuildId.Text = "生成UUID";
            this.btnBuildId.UseVisualStyleBackColor = true;
            this.btnBuildId.Click += new System.EventHandler(this.btnBuildId_Click);
            // 
            // chbDeleteIdLine
            // 
            this.chbDeleteIdLine.AutoSize = true;
            this.chbDeleteIdLine.Location = new System.Drawing.Point(74, 17);
            this.chbDeleteIdLine.Name = "chbDeleteIdLine";
            this.chbDeleteIdLine.Size = new System.Drawing.Size(78, 16);
            this.chbDeleteIdLine.TabIndex = 1;
            this.chbDeleteIdLine.Text = "去除‘-’";
            this.chbDeleteIdLine.UseVisualStyleBackColor = true;
            // 
            // chbIdUpper
            // 
            this.chbIdUpper.AutoSize = true;
            this.chbIdUpper.Location = new System.Drawing.Point(19, 17);
            this.chbIdUpper.Name = "chbIdUpper";
            this.chbIdUpper.Size = new System.Drawing.Size(48, 16);
            this.chbIdUpper.TabIndex = 0;
            this.chbIdUpper.Text = "大写";
            this.chbIdUpper.UseVisualStyleBackColor = true;
            // 
            // md5Tab
            // 
            this.md5Tab.BackColor = System.Drawing.Color.Transparent;
            this.md5Tab.Controls.Add(this.txtMd5Upper);
            this.md5Tab.Controls.Add(this.lblMd5Upper);
            this.md5Tab.Controls.Add(this.txtMd5Lower);
            this.md5Tab.Controls.Add(this.lblMd5Lower);
            this.md5Tab.Controls.Add(this.btnBuildMd5);
            this.md5Tab.Controls.Add(this.txtMd5Source);
            this.md5Tab.Controls.Add(this.lblMd5Source);
            this.md5Tab.Location = new System.Drawing.Point(4, 22);
            this.md5Tab.Name = "md5Tab";
            this.md5Tab.Padding = new System.Windows.Forms.Padding(3);
            this.md5Tab.Size = new System.Drawing.Size(568, 381);
            this.md5Tab.TabIndex = 1;
            this.md5Tab.Text = "MD5生成";
            // 
            // txtMd5Upper
            // 
            this.txtMd5Upper.BackColor = System.Drawing.SystemColors.Window;
            this.txtMd5Upper.Location = new System.Drawing.Point(103, 128);
            this.txtMd5Upper.Name = "txtMd5Upper";
            this.txtMd5Upper.ReadOnly = true;
            this.txtMd5Upper.Size = new System.Drawing.Size(362, 21);
            this.txtMd5Upper.TabIndex = 6;
            // 
            // lblMd5Upper
            // 
            this.lblMd5Upper.AutoSize = true;
            this.lblMd5Upper.Location = new System.Drawing.Point(26, 131);
            this.lblMd5Upper.Name = "lblMd5Upper";
            this.lblMd5Upper.Size = new System.Drawing.Size(71, 12);
            this.lblMd5Upper.TabIndex = 5;
            this.lblMd5Upper.Text = "MD5（大写）";
            // 
            // txtMd5Lower
            // 
            this.txtMd5Lower.BackColor = System.Drawing.SystemColors.Window;
            this.txtMd5Lower.Location = new System.Drawing.Point(103, 75);
            this.txtMd5Lower.Name = "txtMd5Lower";
            this.txtMd5Lower.ReadOnly = true;
            this.txtMd5Lower.Size = new System.Drawing.Size(362, 21);
            this.txtMd5Lower.TabIndex = 4;
            // 
            // lblMd5Lower
            // 
            this.lblMd5Lower.AutoSize = true;
            this.lblMd5Lower.Location = new System.Drawing.Point(26, 78);
            this.lblMd5Lower.Name = "lblMd5Lower";
            this.lblMd5Lower.Size = new System.Drawing.Size(71, 12);
            this.lblMd5Lower.TabIndex = 3;
            this.lblMd5Lower.Text = "MD5（小写）";
            // 
            // btnBuildMd5
            // 
            this.btnBuildMd5.Location = new System.Drawing.Point(390, 17);
            this.btnBuildMd5.Name = "btnBuildMd5";
            this.btnBuildMd5.Size = new System.Drawing.Size(75, 23);
            this.btnBuildMd5.TabIndex = 2;
            this.btnBuildMd5.Text = "生成MD5";
            this.btnBuildMd5.UseVisualStyleBackColor = true;
            this.btnBuildMd5.Click += new System.EventHandler(this.btnBuildMd5_Click);
            // 
            // txtMd5Source
            // 
            this.txtMd5Source.Location = new System.Drawing.Point(103, 19);
            this.txtMd5Source.Name = "txtMd5Source";
            this.txtMd5Source.Size = new System.Drawing.Size(281, 21);
            this.txtMd5Source.TabIndex = 1;
            // 
            // lblMd5Source
            // 
            this.lblMd5Source.AutoSize = true;
            this.lblMd5Source.Location = new System.Drawing.Point(44, 22);
            this.lblMd5Source.Name = "lblMd5Source";
            this.lblMd5Source.Size = new System.Drawing.Size(53, 12);
            this.lblMd5Source.TabIndex = 0;
            this.lblMd5Source.Text = "源字符串";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 407);
            this.Controls.Add(this.mainTab);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "常用工具";
            this.mainTab.ResumeLayout(false);
            this.idTab.ResumeLayout(false);
            this.idTab.PerformLayout();
            this.md5Tab.ResumeLayout(false);
            this.md5Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage idTab;
        private System.Windows.Forms.TabPage md5Tab;
        private System.Windows.Forms.CheckBox chbDeleteIdLine;
        private System.Windows.Forms.CheckBox chbIdUpper;
        private System.Windows.Forms.Button btnBuildId;
        private System.Windows.Forms.Label lblIdCount;
        private System.Windows.Forms.TextBox txtIdCount;
        private System.Windows.Forms.TextBox txtIdResult;
        private System.Windows.Forms.Button btnBuildMd5;
        private System.Windows.Forms.TextBox txtMd5Source;
        private System.Windows.Forms.Label lblMd5Source;
        private System.Windows.Forms.Label lblMd5Lower;
        private System.Windows.Forms.TextBox txtMd5Lower;
        private System.Windows.Forms.Label lblMd5Upper;
        private System.Windows.Forms.TextBox txtMd5Upper;
        private System.Windows.Forms.CheckBox chbUuidTime;

    }
}

