using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainWindow : Form
    {
        private MyAdb mAdb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_adb_btn_Click(object sender, EventArgs e)
        {
          mAdb =new MyAdb("");

            out_lable.Text = mAdb.startAdb();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Out_lable_Click(object sender, EventArgs e)
        {

        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            out_lable.Text=mAdb.connectToDevice(ip_input.Text);
        }
    }
}
