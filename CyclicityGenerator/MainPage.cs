using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyclicityGenerator
{
    public partial class MainPage : UserControl
    {
        public static CyclicityMainForm ParentForm { get; set; }
        public SingleScan s_scanpage;
        public BulkScan b_scanpage;

        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ParentForm == null)
                return;
            Panel mainpane = (ParentForm.Controls["MainPanel"] as Panel);
            mainpane.Controls.Clear();
            mainpane.Controls.Add(s_scanpage);

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            s_scanpage = new SingleScan();
            b_scanpage = new BulkScan();
        }

        private void bulkScanBtn_Click(object sender, EventArgs e)
        {
            Panel mainpane = (ParentForm.Controls["MainPanel"] as Panel);
            mainpane.Controls.Clear();
            mainpane.Controls.Add(b_scanpage);
        }
    }
}
