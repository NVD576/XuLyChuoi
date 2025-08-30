using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyChuoi
{
    public partial class Form1 : Form
    {

        string chuoiBanDau;

        public Form1()
        {
            InitializeComponent();
            chuoiBanDau = txtS1.Text;
        }
        

        private void btChen_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Insert(int.Parse(txtViTriChen.Text),txtS2.Text);
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtS1.Text = chuoiBanDau;
        }

        private void btThaytheS2_s3_Click(object sender, EventArgs e)
        {
            txtS1.Text=txtS1.Text.Replace(txtS2.Text,txtS3.Text);
        }

        private void btDaoTu_Click(object sender, EventArgs e)
        {
                string[] s = txtS1.Text.Split(' ');
                Array.Reverse(s);
                txtS1.Text=string.Join(" ", s);

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int index = txtS1.Text.IndexOf(txtS2.Text);
            if (index != -1)
                txtS1.Text = txtS1.Text.Remove(index,txtS2.Text.Length);
        }

        private void btLaychuoicon_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtTuvitri.Text);
            int count=int.Parse(txtSokitu.Text);
            txtChuoiCon.Text = txtS1.Text.Substring(index, count);
        }

        private void btChuanHoaChuoi_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Trim();
            txtS1.Text= Regex.Replace(txtS1.Text, @"\s+", " ");
            string[] s = txtS1.Text.Split(' ');
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 0)
                {
                    s[i] = char.ToUpper(s[i][0]) + s[i].Substring(1).ToLower();
                }
            }

            txtS1.Text = string.Join(" ", s);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
