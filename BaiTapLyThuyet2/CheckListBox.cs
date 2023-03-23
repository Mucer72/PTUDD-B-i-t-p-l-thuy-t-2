using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyet2
{
    public partial class CheckListBox : Form
    {
        public CheckListBox()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            foreach(var i in checkedListBox1.CheckedItems)
            {
                s+=i.ToString()+',';
            }    
            MessageBox.Show("Danh sách môn học: " + s);
        }
    }
}
