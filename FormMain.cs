using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinform
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "쾅!";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 헬로월드정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 모달창
            Form formAbout1 = new FormAbout();
            formAbout1.Text = "모달창(Modal)";
            formAbout1.ShowDialog();

            // 모달리스창
            Form formAbout2 = new FormAbout();
            formAbout2.Text = "모달리스창(Medeless)";
            formAbout2.Show();

        }

        private void ㅍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|CSV 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    //textBox1.Text = openFileDialog.FileName;
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                        break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소했습니다:");
                    break;
            }
        }
    }
}
