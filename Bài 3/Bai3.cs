using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                string url = textBox2.Text;
                string filepath = textBox1.Text;
                WebClient webClient = new WebClient();
                Stream response = webClient.OpenRead(url);
                webClient.DownloadFile(url, filepath);
                richTextBox1.LoadFile(filepath, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Download completed!");
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập chính xác thông tin");
            }
        }
    }
}
