using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Frm_Contact : Form
    {
        public Frm_Contact()
        {
            InitializeComponent();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {
          
        }

        private void Frm_Contact_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Today.ToShortDateString();
        }
    }
}
