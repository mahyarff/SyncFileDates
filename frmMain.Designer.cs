namespace MaFa.Winforms.SyncFileDate
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
            this.txb_SourcePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BrowseSrc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BrowseDst = new System.Windows.Forms.Button();
            this.txb_DestinationPath = new System.Windows.Forms.TextBox();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.txb_Pattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_Recursive = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_SourcePath
            // 
            this.txb_SourcePath.AllowDrop = true;
            this.txb_SourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SourcePath.Location = new System.Drawing.Point(6, 19);
            this.txb_SourcePath.Name = "txb_SourcePath";
            this.txb_SourcePath.Size = new System.Drawing.Size(764, 20);
            this.txb_SourcePath.TabIndex = 0;
            this.txb_SourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txb_SourcePath_DragDrop);
            this.txb_SourcePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txb_SourcePath_DragEnter);
            this.txb_SourcePath.DragOver += new System.Windows.Forms.DragEventHandler(this.txb_SourcePath_DragOver);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_BrowseSrc);
            this.groupBox1.Controls.Add(this.txb_SourcePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // btn_BrowseSrc
            // 
            this.btn_BrowseSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseSrc.Location = new System.Drawing.Point(695, 45);
            this.btn_BrowseSrc.Name = "btn_BrowseSrc";
            this.btn_BrowseSrc.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseSrc.TabIndex = 1;
            this.btn_BrowseSrc.Text = "Browse";
            this.btn_BrowseSrc.UseVisualStyleBackColor = true;
            this.btn_BrowseSrc.Click += new System.EventHandler(this.btn_BrowseSrc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_BrowseDst);
            this.groupBox2.Controls.Add(this.txb_DestinationPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // btn_BrowseDst
            // 
            this.btn_BrowseDst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseDst.Location = new System.Drawing.Point(695, 45);
            this.btn_BrowseDst.Name = "btn_BrowseDst";
            this.btn_BrowseDst.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseDst.TabIndex = 1;
            this.btn_BrowseDst.Text = "Browse";
            this.btn_BrowseDst.UseVisualStyleBackColor = true;
            this.btn_BrowseDst.Click += new System.EventHandler(this.btn_BrowseDst_Click);
            // 
            // txb_DestinationPath
            // 
            this.txb_DestinationPath.AllowDrop = true;
            this.txb_DestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_DestinationPath.Location = new System.Drawing.Point(6, 19);
            this.txb_DestinationPath.Name = "txb_DestinationPath";
            this.txb_DestinationPath.Size = new System.Drawing.Size(764, 20);
            this.txb_DestinationPath.TabIndex = 0;
            this.txb_DestinationPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txb_DestinationPath_DragDrop);
            this.txb_DestinationPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txb_DestinationPath_DragEnter);
            this.txb_DestinationPath.DragOver += new System.Windows.Forms.DragEventHandler(this.txb_DestinationPath_DragOver);
            // 
            // txb_Result
            // 
            this.txb_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Result.BackColor = System.Drawing.SystemColors.Window;
            this.txb_Result.Location = new System.Drawing.Point(12, 200);
            this.txb_Result.Multiline = true;
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.ReadOnly = true;
            this.txb_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Result.Size = new System.Drawing.Size(776, 211);
            this.txb_Result.TabIndex = 3;
            // 
            // btn_Sync
            // 
            this.btn_Sync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sync.Location = new System.Drawing.Point(713, 417);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(75, 23);
            this.btn_Sync.TabIndex = 4;
            this.btn_Sync.Text = "Sync";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // txb_Pattern
            // 
            this.txb_Pattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Pattern.Location = new System.Drawing.Point(62, 417);
            this.txb_Pattern.Name = "txb_Pattern";
            this.txb_Pattern.Size = new System.Drawing.Size(82, 22);
            this.txb_Pattern.TabIndex = 5;
            this.txb_Pattern.Text = "*.dll";
            this.txb_Pattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pattern";
            // 
            // chb_Recursive
            // 
            this.chb_Recursive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chb_Recursive.AutoSize = true;
            this.chb_Recursive.Checked = true;
            this.chb_Recursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Recursive.Location = new System.Drawing.Point(166, 420);
            this.chb_Recursive.Name = "chb_Recursive";
            this.chb_Recursive.Size = new System.Drawing.Size(74, 17);
            this.chb_Recursive.TabIndex = 7;
            this.chb_Recursive.Text = "Recursive";
            this.chb_Recursive.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chb_Recursive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Pattern);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Sync File Dates";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_SourcePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BrowseSrc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_BrowseDst;
        private System.Windows.Forms.TextBox txb_DestinationPath;
        private System.Windows.Forms.TextBox txb_Result;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.TextBox txb_Pattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_Recursive;
    }
}

