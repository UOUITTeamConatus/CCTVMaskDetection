using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CCTVMaskDetection
{
    public partial class Form1 : Form
    {
        public string Path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void ON_btn_Click(object sender, EventArgs e)
        {
            //CCTVMaskDetection.Properties.Resources.icon
        }

        private void path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();    //저장경로 지정
            if (fbd.ShowDialog() == DialogResult.OK)    //저장경로가 선택되면 
            {
                savePath.Text = fbd.SelectedPath;
                Path = savePath.Text + "\\";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int fullview = 0;
        private void Full_view_Click(object sender, EventArgs e)
        {
            fullview++;
            switch (fullview)
            {
                case 1:
                    screen1.Visible = true;
                    screen2.Visible = false;
                    screen3.Visible = false;
                    screen4.Visible = false;


                    break;
                case 2:
                    screen1.Visible = false;
                    screen2.Visible = true;
                    screen3.Visible = false;
                    screen4.Visible = false;


                    break;
                case 3:
                    screen1.Visible = false;
                    screen2.Visible = false;
                    screen3.Visible = true;
                    screen4.Visible = false;


                    break;
                case 4:
                    screen1.Visible = false;
                    screen2.Visible = false;
                    screen3.Visible = false;
                    screen4.Visible = true;
                    fullview = 0;


                    break;
            }



        }

        private void split_view_Click(object sender, EventArgs e)
        {
            
        }
    }
}
