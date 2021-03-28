using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theswitchcontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public bool IsOn = false;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void setTo(bool s)
        {
            if (s == true)
            {
                IsOn = true;
                button1.Left = 37;
            }
            else
            {
                s = false;
                button1.Left = 2;
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsOn == false)
               { 
                IsOn = true;
               button1.Left = 37;
               }
            else 
               { 
                IsOn = false;
               button1.Left = 2;
               }
        }
    }
}
