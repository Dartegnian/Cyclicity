using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDemo;

using ZXing;
using Timer = System.Windows.Forms.Timer;

namespace CyclicityGenerator
{
    public partial class BulkScan : UserControl
    {

        public static CyclicityMainForm ParentForm { get; set; }
        private Webcam wCam;
        private Timer webCamTimer;
        private readonly BarcodeReader barcodeReader;
        private readonly IList<ResultPoint> resultPoints;
        private readonly IList<Result> lastResults;
        public String QRCodeText;
        public GeneratorForm genform;
        public int TotPoints;
        public int FinPoints;
        public int ToAddPoints;
        public int TotItemsScanned;
        public MainPage mpage;


        public int calcPrice(String codeQR)
        {
            if (codeQR.Contains("L4504"))
            {
                TotPoints = 18;
                return TotPoints;
            }
            else if (codeQR.Contains("ML450"))
            {
                TotPoints = 14;
                return TotPoints;
            }
            else if (codeQR.Contains("MML45"))
            {
                TotPoints = 12;
                return TotPoints;
            }
            else if (codeQR.Contains("S4504"))
            {
                TotPoints = 4;
                return TotPoints;
            }
            else if (codeQR.Contains("SS450"))
            {
                TotPoints = 4;
                return TotPoints;
            }
            else if (codeQR.Contains("SSL45"))
            {
                TotPoints = 3;
                return TotPoints;
            }
            else
            {
                return 0;
            }
        }

        public String calcItem(String codeQR)
        {
            switch (codeQR)
            {
                case ("CC450-CC233-PL450-L4504"):
                    return "Coke-Light";
                case ("CZ451-CC233-PL450-ML450"):
                    return "Coke-Zero";
                case ("R4501-CC233-PL450-MML45"):
                    return "Royal";
                case ("S4502-CC233-CN440-S4504"):
                    return "Sprite";
                case ("MM452-CC233-PL452-L4504"):
                    return "Minute Maid";
                case ("CED40-ABI25-PL450-SS450"):
                    return "Cobra Energy-Drink";
                case ("S4503-SWSC2-PL452-ML450"):
                    return "Summit";
                case ("K4504-MN823-CN440-SS450"):
                    return "Kratos";
                case ("CS451-UC233-PL452-SSL45"):
                    return "Clear Shampoo";
                case ("K7450-CCLD0-PL450-SS450"):
                    return "Kopiko 78";
                case ("PC455-OPCL2-PL452-MML45"):
                    return "Pocari Sweat";
                case ("S4507-PC112-PL450-MML45"):
                    return "Sting";
                case ("P4509-PC112-CN440-SS450"):
                    return "Pepsi";
                case ("MD412-PC112-CN440-SS450"):
                    return "Mountain Dew";
                case ("M4508-PC112-CN440-SS450"):
                    return "Mug";
                default:
                    return "";
            }
        }

       

        private void webCamTimer_Tick(object sender, EventArgs e)
        {
            
            var bitmap = wCam.GetCurrentImage();
            if (bitmap == null)
                return;
            var reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                /*
                Stopwatch sw = new Stopwatch(); // sw cotructor
                sw.Start(); // starts the stopwatch
                for (int i = 0; i < 1000; i++)
                {
                    if (i == 999)
                        i = 0;
                    if (sw.ElapsedMilliseconds > 3000)
                        break;
                       
                }
                sw.Stop();
                */
                Thread.Sleep(3000);
                QRCodeText = calcItem(result.Text);
                ToAddPoints = calcPrice(result.Text);
                FinPoints += ToAddPoints;
                TotItemsScanned++;
                disItems.Text = TotItemsScanned.ToString();

            }
        }

        public BulkScan()
        {
            InitializeComponent();
        }

        private void bulkScanBtn_Click(object sender, EventArgs e)
        {
            if (FinPoints != 0)
            {
                if (ParentForm == null)
                {
                    return;
                }
                webCamTimer.Stop();
                webCamTimer = null;
                wCam.Dispose();
                wCam = null;

                genform.myIntProperty = FinPoints;


                Panel mainpane = (ParentForm.Controls["MainPanel"] as Panel);
                mainpane.Controls.Clear();
                mainpane.Controls.Add(genform);
            }
            else
            {
                MessageBox.Show("Please go back and scan again.\nTry to align QR code to the scanner and properly place it.", "No items scanned",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BulkScan_Load(object sender, EventArgs e)
        {
            genform = new GeneratorForm();
            mpage = new MainPage();

            if (wCam == null)
            {
                wCam = new Webcam { Container = picWebCam };

                wCam.OpenConnection();

                webCamTimer = new Timer();
                webCamTimer.Tick += webCamTimer_Tick;
                webCamTimer.Interval = 200;
                webCamTimer.Start();
            }
            else
            {
                webCamTimer.Stop();
                webCamTimer = null;
                wCam.Dispose();
                wCam = null;
            }

        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            webCamTimer.Stop();
            webCamTimer = null;
            wCam.Dispose();
            wCam = null;

            Panel mainpane = (ParentForm.Controls["MainPanel"] as Panel);
            mainpane.Controls.Clear();
            mainpane.Controls.Add(mpage);
        }
    }
}
