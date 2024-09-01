using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bahmanButtonControl5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You Wanna Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bahmanButtonControl1_Click(object sender, EventArgs e)
        {
            string data = bahmanTextbox1.Text.Trim();
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("please Enter some Data", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qRCodeImage = qrCode.GetGraphic(10);
            pictureBox1.Image = qRCodeImage;
        }
        private int qrCodeCounter = 1;
        private void bahmanButtonControl2_Click(object sender, EventArgs e)
        {
            string data = bahmanTextbox1.Text.Trim();
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("please Enter some Data", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (pictureBox1.Image==null)
            {
                MessageBox.Show("First Generat a Qr Code", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qRCodeImage = qrCode.GetGraphic(10);
            string a = Directory.GetCurrentDirectory();
            string b = "\\QrCodeExportImage";
            string main = $@"{a}\QR Code IMage";

            if (Directory.Exists(main))
            {
                string path = $@"{a}\QR Code IMage\QR Code IMage_{qrCodeCounter}.png";
                qRCodeImage.Save(path);
                qrCodeCounter++;
                MessageBox.Show($"Qr Code Image Saved in" +
                    $"                                                {path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(main);
                string path = $@"{a}\QR Code IMage\QR Code Image_{qrCodeCounter}.png";
                qRCodeImage.Save(path);
                qrCodeCounter++;
                MessageBox.Show($"Qr Code Image Saved in" +
                    $"                                                 {path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        private void bahmanButtonControl3_Click(object sender, EventArgs e)
        {
            bahmanTextbox1.Text = "";
            pictureBox1.Image = null;
        }

        private void bahmanButtonControl4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("You Wanna Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
