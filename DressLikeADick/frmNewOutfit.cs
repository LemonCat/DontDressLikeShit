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
    public partial class frmNewOutfit : Form
    {
        
        public frmNewOutfit()
        {
            InitializeComponent();
        }

        private int nbLines;
        private void frmNewOutfit_Load(object sender, EventArgs e)
        {

            //Initialize 1st line. 
            
            addALine();
            

        }

        private void addALine()
        {
            //Add a line 
            nbLines += 1;

            if (nbLines>10)
            {
                MessageBox.Show("You can't have more than 10 elements. ");
            }
            else
            {
                //Draw depending on nbLines. 
                //Add eventHandler on button to addALine. 

                Button button1 = new System.Windows.Forms.Button();
                TextBox textBox1 = new System.Windows.Forms.TextBox();
                ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
                TextBox textBox2 = new System.Windows.Forms.TextBox();

                this.SuspendLayout();
                // 
                // button1
                // 
                button1.BackgroundImage = global::DressLikeADick.Properties.Resources.plus_8x;
                button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                button1.Location = new System.Drawing.Point(483, 27 * nbLines + 5 * (nbLines - 1));
                button1.Name = "button" + nbLines;
                button1.Size = new System.Drawing.Size(22, 22);
                button1.TabIndex = 0;
                button1.UseVisualStyleBackColor = true;

                button1.Click += new EventHandler(btnAddALine);

                // 
                // textBox1
                // 
                textBox1.Location = new System.Drawing.Point(12, 27 * nbLines + 5 * (nbLines - 1));
                textBox1.Name = "textBoxClo" + nbLines;
                textBox1.Size = new System.Drawing.Size(166, 22);
                textBox1.TabIndex = 1;
                // 
                // comboBox1
                // 
                comboBox1.FormattingEnabled = true;
                comboBox1.Location = new System.Drawing.Point(356, 27 * nbLines + 5 * (nbLines - 1));
                comboBox1.Name = "comboBox" + nbLines;
                comboBox1.Size = new System.Drawing.Size(121, 21);
                comboBox1.TabIndex = 2;

                // 
                // textBox2
                // 
                textBox2.Location = new System.Drawing.Point(184, 27 * nbLines + 5 * (nbLines - 1));
                textBox2.Name = "textBoxCat" + nbLines;
                textBox2.Size = new System.Drawing.Size(166, 22);
                textBox2.TabIndex = 4;
                // 
                // frmNewOutfit
                // 
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                //ClientSize = new System.Drawing.Size(755, 425);
                this.Controls.Add(textBox2);
                this.Controls.Add(comboBox1);
                this.Controls.Add(textBox1);
                this.Controls.Add(button1);
                this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Name = "frmNewOutfit";
                this.Text = "Add a new outfit";
                this.Load += new System.EventHandler(this.frmNewOutfit_Load);

                refreshAllCbo();

                this.ResumeLayout(false);
                this.PerformLayout();
            }



            

        }

        private void refreshAllCbo()
        {
            

            /* Loop through This.Controls and if is TypeOf(Cbo) then 
             * delete all item and populate up to nbLines. 
             */

            foreach (Control C in this.Controls)
            {
                if (C is ComboBox)
                {
                    ((ComboBox)C).Items.Clear();

                    int i = 0;
                    while (i<nbLines )
                    {
                        ((ComboBox)C).Items.Add(i+1);

                        //Set default value base on cbo name. 

                        if (((ComboBox)C).Name == "comboBox10")
                        {
                            ((ComboBox)C).Text ="10";
                        }else{
                            String mystr = ((ComboBox)C).Name;
                            ((ComboBox)C).Text = mystr.Substring(mystr.Length - 1);
                        }
                        
                        i++;
                    }
                }
            }

        }


        void btnAddALine(object sender, EventArgs e)
        {
            /*var button = (Button)sender;
            MessageBox.Show(button.Name);*/


            addALine();

            //addALine();
        }

        private void btnBrowsePicNewOutfit_Click(object sender, EventArgs e)
        {
            /* Filter by supported pics 
             * Store path
             * Load pic in pictureBox
            */

            openFileDialog1.ShowDialog();
        }

        private void btnSaveNewOutfit_Click(object sender, EventArgs e)
        {
            /*Save outfit : 
             *  Create new outfit in db
             *  Make a copy of the picture (resize it to the size of the pictureBox on the main form
             *  insert path in database
             *  Insert lines in db
             */


        }

    }
}
