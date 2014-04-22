namespace DressLikeADick
{
    partial class frmNewOutfit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowsePicNewOutfit = new System.Windows.Forms.Button();
            this.btnSaveNewOutfit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clothing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Position";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(526, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 336);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowsePicNewOutfit
            // 
            this.btnBrowsePicNewOutfit.Location = new System.Drawing.Point(526, 351);
            this.btnBrowsePicNewOutfit.Name = "btnBrowsePicNewOutfit";
            this.btnBrowsePicNewOutfit.Size = new System.Drawing.Size(201, 23);
            this.btnBrowsePicNewOutfit.TabIndex = 8;
            this.btnBrowsePicNewOutfit.Text = "Browse for a picture of the outfit";
            this.btnBrowsePicNewOutfit.UseVisualStyleBackColor = true;
            this.btnBrowsePicNewOutfit.Click += new System.EventHandler(this.btnBrowsePicNewOutfit_Click);
            // 
            // btnSaveNewOutfit
            // 
            this.btnSaveNewOutfit.Location = new System.Drawing.Point(445, 352);
            this.btnSaveNewOutfit.Name = "btnSaveNewOutfit";
            this.btnSaveNewOutfit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewOutfit.TabIndex = 9;
            this.btnSaveNewOutfit.Text = "Save";
            this.btnSaveNewOutfit.UseVisualStyleBackColor = true;
            this.btnSaveNewOutfit.Click += new System.EventHandler(this.btnSaveNewOutfit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNewOutfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 387);
            this.Controls.Add(this.btnSaveNewOutfit);
            this.Controls.Add(this.btnBrowsePicNewOutfit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNewOutfit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmNewOutfit";
            this.Load += new System.EventHandler(this.frmNewOutfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowsePicNewOutfit;
        private System.Windows.Forms.Button btnSaveNewOutfit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}