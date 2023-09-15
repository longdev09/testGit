using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Form1 : Form
    {
        private string tenDangNhap;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string tenDangNhap):this()
        {
            tenDangNhap = tenDangNhap;
            statusBar1.Text = "Chao mung nguoi dung : " +  tenDangNhap;
        }
    }
}
