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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int itemselect=lbDSLop.SelectedItems.Count-1;
            for(int i=0;i<itemselect;i++)
            {
                lbDSBongDa.Items.Add(lbDSLop.SelectedItems[i]);
                lbDSLop.Items.RemoveAt(i);
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i =lbDSBongDa.SelectedItems.Count-1;
            while(i>=0)
            {
                lbDSBongDa.Items.RemoveAt(lbDSBongDa.SelectedIndices[i]);
                i--;
            }    
        }
    }
}
