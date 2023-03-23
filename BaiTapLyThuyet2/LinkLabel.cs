using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyet2
{
    public partial class LinkLabel : Form
    {
        public LinkLabel()
        {
            InitializeComponent();
        }

        private void LinkLabel_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:2111845@dlu.edu.vn";
            this.linkLabel1.Links.Add(0,strURL.Length,strURL);
            strURL = "https://cntt.dlu.edu.vn/";
            this.linkLabel2.Links.Add(0,strURL.Length,strURL);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if(strURL.StartsWith("mailto:"))
                Process.Start(strURL+"?subject=Hello");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("https://"))
                Process.Start(strURL);
        }
    }
}
