using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace HexCut
{
    public partial class HexCut : Form
    {
        const int FILE_READ_SIZE = 1024 * 1024;
        string OpenFileName = string.Empty;
        string SaveFileName = string.Empty;
        public HexCut()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.OpenFile.ShowDialog() == DialogResult.OK)
                OpenFileName = this.OpenFile.FileName;
            if (OpenFileName == string.Empty)
                return;
            FileInfo fi = new FileInfo(OpenFileName);
            this.Lable_FileNameText.Text = System.IO.Path.GetFileName(OpenFileName);
            this.Lable_FileSizeText.Text = fi.Length.ToString();

            this.SaveToolStripMenuItem.Enabled = true;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long start;
            long need_write_size;
            long file_size;
            byte[] tmp_byte_array;

            if (OpenFileName == string.Empty)
            {
                MessageBox.Show("请打开文件");
                return;
            }

            BinaryReader file_read_fp = new BinaryReader(new FileStream(OpenFileName,
                FileMode.Open));
            file_size = file_read_fp.BaseStream.Length;

            if (this.TextBox_StartOffset.Text.ToString() != string.Empty)
            {
                start = Convert.ToInt64(this.TextBox_StartOffset.Text.ToString(), 10);
                if (start >= file_size - 1)
                {
                    MessageBox.Show("请输入正确的offset,数值已大于文件大小");
                    file_read_fp.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入offset");
                file_read_fp.Close();
                return;
            }

            if (this.TextBox_Size.Text.ToString() != string.Empty)
            {
                need_write_size = Convert.ToInt64(this.TextBox_Size.Text.ToString(), 10);
                if (need_write_size + start > file_size)
                {
                    MessageBox.Show("可写size超过文件结尾");
                    file_read_fp.Close();
                    return;
                }
                if (need_write_size == 0)
                    need_write_size = file_size - start;
            }
            else
            {
                MessageBox.Show("请输入size,0代表一直到结尾");
                file_read_fp.Close();
                return;
            }

            if (this.SaveFile.ShowDialog() == DialogResult.OK)
                SaveFileName = this.SaveFile.FileName;
            if (SaveFileName == string.Empty)
                return;

            BinaryWriter file_write_fp = new BinaryWriter(new FileStream(SaveFileName,
                FileMode.Create));

            file_read_fp.BaseStream.Seek(start, SeekOrigin.Begin);

            while (need_write_size >= FILE_READ_SIZE)
            {
                tmp_byte_array = file_read_fp.ReadBytes(FILE_READ_SIZE);

                file_write_fp.Write(tmp_byte_array, 0, FILE_READ_SIZE);
                need_write_size -= FILE_READ_SIZE;
            }

            if (need_write_size != 0)
            {
                tmp_byte_array = file_read_fp.ReadBytes((int)need_write_size);
                file_write_fp.Write(tmp_byte_array, 0, (int)need_write_size);
            }

            file_read_fp.Close();
            file_write_fp.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void HexCut_DragDrop(object sender, DragEventArgs e)
        {
            OpenFileName = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileInfo fi = new FileInfo(OpenFileName);
            this.Lable_FileNameText.Text = System.IO.Path.GetFileName(OpenFileName);
            this.Lable_FileSizeText.Text = fi.Length.ToString();

            this.SaveToolStripMenuItem.Enabled = true;

        }

        private void HexCut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
    }
}
