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
        string FileName = string.Empty;
        public HexCut()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            long start;
            long size;
            byte[] sz = new byte[1024 * 1024];

            if (FileName == string.Empty)
            {
                MessageBox.Show("请打开文件");
                return;
            }
  
            FileInfo fi = new FileInfo(FileName);

            //this.label1.Text = "0x" + fi.Length.ToString("X");
            


            if (this.TextBox_StartOffset.Text.ToString() != "")
            {
                start = Convert.ToInt64(this.TextBox_StartOffset.Text.ToString(), 10);
                if (start >= fi.Length - 1)
                {
                    MessageBox.Show("请输入正确的offset,已大于文件大小");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入offset");
                return;
            }

            if (this.TextBox_Size.Text.ToString() != "")
            {
                size = Convert.ToInt64(this.TextBox_Size.Text.ToString(), 10);
                if (size + start > fi.Length)
                {
                    MessageBox.Show("可写size超过文件结尾");
                    return;
                }
                if (size == 0)
                    size = fi.Length - start;
            }
            else
            {
                MessageBox.Show("请输入size,0代表一直到结尾");
                return;
            }

            BinaryReader br = new BinaryReader(new FileStream(FileName,
                FileMode.Open));
            BinaryWriter bw = new BinaryWriter(new FileStream("mydata",
                FileMode.Create));



            br.BaseStream.Seek(start, SeekOrigin.Begin);

            while (size >= 1024 * 1024)
            {
                sz = br.ReadBytes(1024 * 1024);

                bw.Write(sz, 0, 1024 * 1024);
                size -= 1024 * 1024;
            }

            if (size != 0)
            {
                sz = br.ReadBytes((int)size);
                bw.Write(sz, 0, (int)size);
            }

            br.Close();
            bw.Close();
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Openfile.ShowDialog() == DialogResult.OK)
                //选择文件后，用openFileDialog1的FileName属性获取文件的绝对路径
                FileName = this.Openfile.FileName;
            if (FileName == string.Empty)
                return;
            //this.label1.Text = "0x" + fi.Length.ToString("X");
            FileInfo fi = new FileInfo(FileName);
            this.Lable_FileNameText.Text = System.IO.Path.GetFileName(FileName);
            this.Lable_FileSizeText.Text = fi.Length.ToString();
        }
    }
}
