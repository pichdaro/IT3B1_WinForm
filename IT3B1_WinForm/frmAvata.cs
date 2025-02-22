using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmAvata : Form
    {
        public frmAvata()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg;*.png) | " +
                "*.jpg;*.png";
            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void frmAvata_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (MyConfig.activeUser.Avata != null)
            {
                MemoryStream ms = new MemoryStream(MyConfig.activeUser.Avata);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private byte[] PicToByte(PictureBox pbProfile)
        {
            if (pbProfile.Image != null)
            {
                byte[] photo_array;
                MemoryStream ms = new MemoryStream();
                pbProfile.Image.Save(ms, ImageFormat.Jpeg);
                photo_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_array, 0, photo_array.Length);
                return photo_array;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                byte[] avata = PicToByte(pictureBox1);
                if (User.SetAvata(MyConfig.activeUser.ID, avata))
                {
                    MessageBox.Show("Your avata has been updated!", "Avata Set",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyConfig.activeUser.Avata = avata;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to update your avata!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (User.RemoveAvata(MyConfig.activeUser.ID))
                {
                    MessageBox.Show("Your avata has been removed!", "Avata Removed",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyConfig.activeUser.Avata = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to remove your avata!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
