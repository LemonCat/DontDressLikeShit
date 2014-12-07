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

namespace DressLikeADick
{
    public partial class frmNewElement : Form
    {
        private  string curLoadedImg;

        public frmNewElement()
        {
            InitializeComponent();
        }

        private void btnBrowsePicNewElem_Click(object sender, EventArgs e)
        {
            /* Filter by supported pics 
             * Store path
             * Load pic in pictureBox
            */

            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                curLoadedImg = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ;
            }


        }


        private void btnSaveNewElem_Click(object sender, EventArgs e)
        {
            clsDb my_clsDb = new clsDb();

            //Console.WriteLine(my_clsDb.getLastPieceID());

            /*Save outfit : 
             *  Create new clothing in db
             *  Make a copy of the picture (resize it to the size of the pictureBox on the main form
             *  insert path in database
             */

            if (curLoadedImg!="")
            {

                //Image.GetThumbnailImageAbort myCallback =new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Bitmap myBitmap = new Bitmap(curLoadedImg);
                Image myThumbnail = myBitmap.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                //A modifier pour récupérer le n° d'index de la base. 
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "piece\\")) Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "piece\\");
                myThumbnail.Save(AppDomain.CurrentDomain.BaseDirectory + "piece\\aaa.png", System.Drawing.Imaging.ImageFormat.Png);
                
            }

            

        }

        private void frmNewElement_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Properties.Resources.circle_x_8x );
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }



    

    }
}
