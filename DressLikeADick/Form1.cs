using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Il me faut une classe d'état global des elements pas bon. */
/*Cette classe aura une collection d'elements en attribut. */


/*Une classe elements aussi. */


namespace DressLikeADick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*Gestion de l'horloge*/
            timer1.Start();

            var culture = new System.Globalization.CultureInfo("fr-FR");
            TextInfo myTI = new CultureInfo("fr-FR", false).TextInfo;

            lblDay.Text  = DateTime.Now.ToString("dd");
            lblMonth.Text = myTI.ToUpper(DateTime.Now.ToString("MMMM").Substring(0,3));
            lblDayOfWeek.Text = myTI.ToUpper(culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek).Substring(0,3));
            lblAMPM.Text = DateTime.Now.ToString(@"tt", new CultureInfo("en-US"));
            




            /*Charge un premier set*/

            /*qry db*/
            /*load*/


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hhmmss.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            /*Log +1 Yes*/

            /*Lock button*/
            btnYes.Enabled = false; 
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            /*Unlock btnYes*/
            btnYes.Enabled = true;

            /*Log +1 No*/

            /*Charge le prochain set si ts element dispo. */
        }

        private void redrawLeft(int nbRows)
        {

            SuspendLayout();

            for (int i = 0; i < nbRows ; i++)
            {
                tlpRight.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                /*Charge l'image*/

                /*Créer un bouton et l'ajouter en child. Il aura en tag l'id de l'élément représenté. */
                /*Une fonction permettant de déclarer le fait que cet élément est manquant sera bind. */

            }

            ResumeLayout();
            tlpRight.RowCount = tlpRight.RowStyles.Count;

            MessageBox.Show(string.Format("{0}", tlpRight.RowCount - 1));
        }



        private void btnDbg_Click(object sender, EventArgs e)
        {
            //ce bouton fait du fkg debug. 
            redrawLeft(6);
        }


        private void declareElemNotAvailable(int idElem)
        {
            /*Ajoute en mémoire dans la liste des elements non dispo. */
        }


        private frmNewElement myFrmNewElement;
        private void btnNewElement_Click(object sender, EventArgs e)
        {
            
            myFrmNewElement = new frmNewElement();
            myFrmNewElement.StartPosition = FormStartPosition.CenterParent;
            myFrmNewElement.ShowDialog(); //Displays as modal form. 

        }

        private frmNewOutfit myfrmNewOutfit;
        private void btnNewSet_Click(object sender, EventArgs e)
        {
            myfrmNewOutfit = new frmNewOutfit();
            myfrmNewOutfit.StartPosition = FormStartPosition.CenterParent;
            myfrmNewOutfit.ShowDialog(); //Displays as modal form. 
        }



    }
}
