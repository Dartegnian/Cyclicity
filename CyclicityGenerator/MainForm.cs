using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyclicityGenerator
{
    public partial class CyclicityMainForm : Form
    {
        
        public MainPage mainp = new MainPage();

        public CyclicityMainForm()
        {
            InitializeComponent();
            MainPage.ParentForm = this;
            BulkScan.ParentForm = this;
            SingleScan.ParentForm = this;
            GeneratorForm.ParentForm = this;
        }
        

        private void CyclicityGenerator_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(mainp);
        }
    }
}
