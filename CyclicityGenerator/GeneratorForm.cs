using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;

using ZXing;
using WindowsFormsDemo;

namespace CyclicityGenerator
{
    public partial class GeneratorForm : UserControl
    {
        private Webcam wCam;
        private Timer webCamTimer;
        private readonly BarcodeReader barcodeReader;
        private readonly IList<ResultPoint> resultPoints;
        private readonly IList<Result> lastResults;
        public int myIntProperty { get; set; }

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        public static CyclicityMainForm ParentForm { get; set; }
        public MainPage mpage;

        public String GenerateText()
        {
            string FinalCode;
            int codedPoints;
            int RandomNum = GenerateRandomNo();
            codedPoints = myIntProperty*RandomNum;
            FinalCode = codedPoints + "-" + RandomNum;
            return FinalCode;
        }

        public GeneratorForm()
        {
            InitializeComponent();
        }
        public int GenerateRandomNo()
        {
            int _min = 10000;
            int _max = 99999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            mpage = new MainPage();
            RenderQrCode();

        }
        private void RenderQrCode()
        {
            string level = "L";
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(GenerateText(), eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, Color.Black, Color.White,
                            GetIconBitmap(), 15);

                        this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                        //Set the SizeMode to center the image.
                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }
        private Bitmap GetIconBitmap()
        {
            Bitmap img = null;
            return img;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            Panel mainpane = (ParentForm.Controls["MainPanel"] as Panel);
            mainpane.Controls.Clear(); 
            mainpane.Controls.Add(mpage);
        }
        
    }
}
