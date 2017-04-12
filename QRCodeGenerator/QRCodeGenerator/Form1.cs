using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing.Imaging;

namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();

            Bitmap img = encoder.Encode(textBox1.Text + " " + textBox2.Text);

            img.Save(@"C:\Users\"+ Environment.UserName +@"\Desktop\code.jpg", ImageFormat.Jpeg);
        }
    }
}
