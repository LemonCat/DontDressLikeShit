using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressLikeADick
{
    public partial class frmNewElement : Form
    {
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
            
            openFileDialog1.ShowDialog();
        }

        private void btnSaveNewElem_Click(object sender, EventArgs e)
        {
            /*Save outfit : 
             *  Create new clothing in db
             *  Make a copy of the picture (resize it to the size of the pictureBox on the main form
             *  insert path in database
             */

        }
    }
}
