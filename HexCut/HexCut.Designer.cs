﻿namespace HexCut
{
    partial class HexCut
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Lable_FileNameText = new System.Windows.Forms.Label();
            this.TextBox_StartOffset = new System.Windows.Forms.TextBox();
            this.TextBox_Size = new System.Windows.Forms.TextBox();
            this.Lable_Offset = new System.Windows.Forms.Label();
            this.Lable_size = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lable_FileName = new System.Windows.Forms.Label();
            this.Lable_FileSize = new System.Windows.Forms.Label();
            this.Lable_FileSizeText = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // Lable_FileNameText
            // 
            this.Lable_FileNameText.AutoSize = true;
            this.Lable_FileNameText.Location = new System.Drawing.Point(157, 42);
            this.Lable_FileNameText.Name = "Lable_FileNameText";
            this.Lable_FileNameText.Size = new System.Drawing.Size(23, 12);
            this.Lable_FileNameText.TabIndex = 1;
            this.Lable_FileNameText.Text = "xxx";
            this.Lable_FileNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_StartOffset
            // 
            this.TextBox_StartOffset.Location = new System.Drawing.Point(159, 113);
            this.TextBox_StartOffset.Name = "TextBox_StartOffset";
            this.TextBox_StartOffset.Size = new System.Drawing.Size(100, 21);
            this.TextBox_StartOffset.TabIndex = 2;
            this.TextBox_StartOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_Size
            // 
            this.TextBox_Size.Location = new System.Drawing.Point(159, 150);
            this.TextBox_Size.Name = "TextBox_Size";
            this.TextBox_Size.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Size.TabIndex = 3;
            this.TextBox_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lable_Offset
            // 
            this.Lable_Offset.AutoSize = true;
            this.Lable_Offset.Location = new System.Drawing.Point(67, 116);
            this.Lable_Offset.Name = "Lable_Offset";
            this.Lable_Offset.Size = new System.Drawing.Size(41, 12);
            this.Lable_Offset.TabIndex = 6;
            this.Lable_Offset.Text = "offset";
            // 
            // Lable_size
            // 
            this.Lable_size.AutoSize = true;
            this.Lable_size.Location = new System.Drawing.Point(73, 153);
            this.Lable_size.Name = "Lable_size";
            this.Lable_size.Size = new System.Drawing.Size(29, 12);
            this.Lable_size.TabIndex = 7;
            this.Lable_size.Text = "size";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem1,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // OpenToolStripMenuItem1
            // 
            this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
            this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.OpenToolStripMenuItem1.Text = "Open";
            this.OpenToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Lable_FileName
            // 
            this.Lable_FileName.AutoSize = true;
            this.Lable_FileName.Location = new System.Drawing.Point(58, 42);
            this.Lable_FileName.Name = "Lable_FileName";
            this.Lable_FileName.Size = new System.Drawing.Size(59, 12);
            this.Lable_FileName.TabIndex = 9;
            this.Lable_FileName.Text = "file name";
            // 
            // Lable_FileSize
            // 
            this.Lable_FileSize.AutoSize = true;
            this.Lable_FileSize.Location = new System.Drawing.Point(58, 79);
            this.Lable_FileSize.Name = "Lable_FileSize";
            this.Lable_FileSize.Size = new System.Drawing.Size(59, 12);
            this.Lable_FileSize.TabIndex = 10;
            this.Lable_FileSize.Text = "file size";
            // 
            // Lable_FileSizeText
            // 
            this.Lable_FileSizeText.AutoSize = true;
            this.Lable_FileSizeText.Location = new System.Drawing.Point(157, 79);
            this.Lable_FileSizeText.Name = "Lable_FileSizeText";
            this.Lable_FileSizeText.Size = new System.Drawing.Size(23, 12);
            this.Lable_FileSizeText.TabIndex = 11;
            this.Lable_FileSizeText.Text = "xxx";
            this.Lable_FileSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HexCut
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(this.Lable_FileSizeText);
            this.Controls.Add(this.Lable_FileSize);
            this.Controls.Add(this.Lable_FileName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lable_size);
            this.Controls.Add(this.Lable_Offset);
            this.Controls.Add(this.TextBox_Size);
            this.Controls.Add(this.TextBox_StartOffset);
            this.Controls.Add(this.Lable_FileNameText);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HexCut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexCut";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HexCut_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HexCut_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label Lable_FileNameText;
        private System.Windows.Forms.TextBox TextBox_StartOffset;
        private System.Windows.Forms.TextBox TextBox_Size;
        private System.Windows.Forms.Label Lable_Offset;
        private System.Windows.Forms.Label Lable_size;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label Lable_FileName;
        private System.Windows.Forms.Label Lable_FileSize;
        private System.Windows.Forms.Label Lable_FileSizeText;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

