using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignVerifier
{
    public partial class frmDisplaySignature : Form
    {
        public frmDisplaySignature()
        {
            InitializeComponent();
        }

        private void frmDisplaySignature_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Convert the Image to BYTE Array
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        /// <summary>
        /// Calculates the number of BYTES in the Image and populates a BYTE array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBytes_Click(object sender, EventArgs e)
        {
            //Get the Image from picturebox
            Image img = picSignature.Image;
            byte[] b = imageToByteArray(img);
            MessageBox.Show ("Total no of PIXELS in Image are " + b.Length);
        }
    }
}
