using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.cbSub.SelectedIndex = 0;
        }

        private void btnRequire_Click(object sender, EventArgs e)
        {
            Subject subject = null;
            if(cbSub.SelectedIndex == 0)
            {
                subject = new Math();
            }
            else
            {
                subject = new Literature();
            }
            Subject proxy = new Proxy(subject);
            rtbContent.Text += proxy.DoSomeWork();
        }
    }
}
