namespace FileRemover
{
    partial class frmMain
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.chkInclude = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdSource = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 402);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 23;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(549, 51);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(138, 42);
            this.btnBrowseSource.TabIndex = 22;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.BtnBrowseSource_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(549, 393);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 42);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(22, 250);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(665, 133);
            this.txtText.TabIndex = 18;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(23, 30);
            this.lblSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(134, 25);
            this.lblSource.TabIndex = 17;
            this.lblSource.Text = "Source folder:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(23, 57);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(514, 29);
            this.txtSource.TabIndex = 16;
            this.txtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(342, 26);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(196, 29);
            this.chkSubfolders.TabIndex = 24;
            this.chkSubfolders.Text = "Include subfolders";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // chkInclude
            // 
            this.chkInclude.AutoSize = true;
            this.chkInclude.Location = new System.Drawing.Point(28, 214);
            this.chkInclude.Name = "chkInclude";
            this.chkInclude.Size = new System.Drawing.Size(343, 29);
            this.chkInclude.TabIndex = 25;
            this.chkInclude.Text = "Includes the following (one per line)";
            this.chkInclude.UseVisualStyleBackColor = true;
            this.chkInclude.CheckedChanged += new System.EventHandler(this.ChkInclude_CheckedChanged);
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(28, 116);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(220, 29);
            this.chkSize.TabIndex = 26;
            this.chkSize.Text = "Size equal/less than:";
            this.chkSize.UseVisualStyleBackColor = true;
            this.chkSize.CheckedChanged += new System.EventHandler(this.ChkSize_CheckedChanged);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(22, 151);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(191, 29);
            this.txtSize.TabIndex = 27;
            this.txtSize.TextChanged += new System.EventHandler(this.TxtSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "bytes";
            // 
            // txtExtension
            // 
            this.txtExtension.Enabled = false;
            this.txtExtension.Location = new System.Drawing.Point(336, 151);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(351, 29);
            this.txtExtension.TabIndex = 30;
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Location = new System.Drawing.Point(342, 116);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(324, 29);
            this.chkExtension.TabIndex = 29;
            this.chkExtension.Text = "Extension is (comma separated):";
            this.chkExtension.UseVisualStyleBackColor = true;
            this.chkExtension.CheckedChanged += new System.EventHandler(this.ChkExtension_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.chkExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.chkSize);
            this.Controls.Add(this.chkInclude);
            this.Controls.Add(this.chkSubfolders);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "File remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.CheckBox chkInclude;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog ofdSource;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.CheckBox chkExtension;
    }
}

