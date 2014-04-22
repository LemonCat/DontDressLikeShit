namespace DressLikeADick
{
    partial class frmNewElement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameNewElem = new System.Windows.Forms.Label();
            this.txtNameNewElem = new System.Windows.Forms.TextBox();
            this.cboTypeNewElem = new System.Windows.Forms.ComboBox();
            this.btnBrowsePicNewElem = new System.Windows.Forms.Button();
            this.lblTypeOfCloth = new System.Windows.Forms.Label();
            this.btnSaveNewElem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameNewElem
            // 
            this.lblNameNewElem.AutoSize = true;
            this.lblNameNewElem.Location = new System.Drawing.Point(201, 9);
            this.lblNameNewElem.Name = "lblNameNewElem";
            this.lblNameNewElem.Size = new System.Drawing.Size(45, 13);
            this.lblNameNewElem.TabIndex = 0;
            this.lblNameNewElem.Text = "Name : ";
            // 
            // txtNameNewElem
            // 
            this.txtNameNewElem.Location = new System.Drawing.Point(266, 6);
            this.txtNameNewElem.Name = "txtNameNewElem";
            this.txtNameNewElem.Size = new System.Drawing.Size(166, 22);
            this.txtNameNewElem.TabIndex = 1;
            // 
            // cboTypeNewElem
            // 
            this.cboTypeNewElem.FormattingEnabled = true;
            this.cboTypeNewElem.Location = new System.Drawing.Point(266, 32);
            this.cboTypeNewElem.Name = "cboTypeNewElem";
            this.cboTypeNewElem.Size = new System.Drawing.Size(166, 21);
            this.cboTypeNewElem.TabIndex = 3;
            // 
            // btnBrowsePicNewElem
            // 
            this.btnBrowsePicNewElem.Location = new System.Drawing.Point(12, 191);
            this.btnBrowsePicNewElem.Name = "btnBrowsePicNewElem";
            this.btnBrowsePicNewElem.Size = new System.Drawing.Size(183, 23);
            this.btnBrowsePicNewElem.TabIndex = 4;
            this.btnBrowsePicNewElem.Text = "Browse for picture";
            this.btnBrowsePicNewElem.UseVisualStyleBackColor = true;
            this.btnBrowsePicNewElem.Click += new System.EventHandler(this.btnBrowsePicNewElem_Click);
            // 
            // lblTypeOfCloth
            // 
            this.lblTypeOfCloth.AutoSize = true;
            this.lblTypeOfCloth.Location = new System.Drawing.Point(201, 35);
            this.lblTypeOfCloth.Name = "lblTypeOfCloth";
            this.lblTypeOfCloth.Size = new System.Drawing.Size(62, 13);
            this.lblTypeOfCloth.TabIndex = 5;
            this.lblTypeOfCloth.Text = "Category : ";
            // 
            // btnSaveNewElem
            // 
            this.btnSaveNewElem.Location = new System.Drawing.Point(357, 191);
            this.btnSaveNewElem.Name = "btnSaveNewElem";
            this.btnSaveNewElem.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewElem.TabIndex = 6;
            this.btnSaveNewElem.Text = "Save";
            this.btnSaveNewElem.UseVisualStyleBackColor = true;
            this.btnSaveNewElem.Click += new System.EventHandler(this.btnSaveNewElem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DressLikeADick.Properties.Resources.circle_x_8x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNewElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 224);
            this.Controls.Add(this.btnSaveNewElem);
            this.Controls.Add(this.lblTypeOfCloth);
            this.Controls.Add(this.btnBrowsePicNewElem);
            this.Controls.Add(this.cboTypeNewElem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNameNewElem);
            this.Controls.Add(this.lblNameNewElem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNewElement";
            this.Text = "Add a new cloth";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameNewElem;
        private System.Windows.Forms.TextBox txtNameNewElem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboTypeNewElem;
        private System.Windows.Forms.Button btnBrowsePicNewElem;
        private System.Windows.Forms.Label lblTypeOfCloth;
        private System.Windows.Forms.Button btnSaveNewElem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}