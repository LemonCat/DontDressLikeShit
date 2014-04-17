namespace DressLikeADick
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpMainPic = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.lblAMPM = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lbl_hhmmss = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.btnDbg = new System.Windows.Forms.Button();
            this.btnNewElement = new System.Windows.Forms.Button();
            this.btnDelSet = new System.Windows.Forms.Button();
            this.btnDelElement = new System.Windows.Forms.Button();
            this.btnNewSet = new System.Windows.Forms.Button();
            this.grpLeft.SuspendLayout();
            this.grpMainPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDate.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.tlpRight);
            this.grpLeft.Location = new System.Drawing.Point(13, 12);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(214, 542);
            this.grpLeft.TabIndex = 1;
            this.grpLeft.TabStop = false;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(3, 16);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 1;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.Size = new System.Drawing.Size(208, 523);
            this.tlpRight.TabIndex = 0;
            // 
            // grpMainPic
            // 
            this.grpMainPic.Controls.Add(this.btnNo);
            this.grpMainPic.Controls.Add(this.btnYes);
            this.grpMainPic.Controls.Add(this.pictureBox1);
            this.grpMainPic.Location = new System.Drawing.Point(233, 12);
            this.grpMainPic.Name = "grpMainPic";
            this.grpMainPic.Size = new System.Drawing.Size(399, 542);
            this.grpMainPic.TabIndex = 2;
            this.grpMainPic.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.Image = global::DressLikeADick.Properties.Resources.thumb_down_8x;
            this.btnNo.Location = new System.Drawing.Point(0, 464);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(76, 78);
            this.btnNo.TabIndex = 1;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.Control;
            this.btnYes.Image = global::DressLikeADick.Properties.Resources.thumb_up_8x;
            this.btnYes.Location = new System.Drawing.Point(323, 464);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(76, 78);
            this.btnYes.TabIndex = 0;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DressLikeADick.Properties.Resources.IMG_20140415_083343;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.lblAMPM);
            this.grpDate.Controls.Add(this.lblMonth);
            this.grpDate.Controls.Add(this.lblDayOfWeek);
            this.grpDate.Controls.Add(this.lblDay);
            this.grpDate.Controls.Add(this.lbl_hhmmss);
            this.grpDate.Location = new System.Drawing.Point(638, 476);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(273, 78);
            this.grpDate.TabIndex = 3;
            this.grpDate.TabStop = false;
            // 
            // lblAMPM
            // 
            this.lblAMPM.AutoSize = true;
            this.lblAMPM.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAMPM.Location = new System.Drawing.Point(244, 11);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(24, 13);
            this.lblAMPM.TabIndex = 4;
            this.lblAMPM.Text = "AM";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblMonth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMonth.Location = new System.Drawing.Point(73, 24);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(32, 17);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "AVR";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblDayOfWeek.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDayOfWeek.Location = new System.Drawing.Point(73, 41);
            this.lblDayOfWeek.Margin = new System.Windows.Forms.Padding(0);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(29, 17);
            this.lblDayOfWeek.TabIndex = 2;
            this.lblDayOfWeek.Text = "JEU";
            this.lblDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(8, 15);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(62, 50);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "99";
            // 
            // lbl_hhmmss
            // 
            this.lbl_hhmmss.AutoSize = true;
            this.lbl_hhmmss.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hhmmss.Location = new System.Drawing.Point(119, 17);
            this.lbl_hhmmss.Name = "lbl_hhmmss";
            this.lbl_hhmmss.Size = new System.Drawing.Size(158, 50);
            this.lbl_hhmmss.TabIndex = 0;
            this.lbl_hhmmss.Text = "12:12:12";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.btnDbg);
            this.grpRight.Controls.Add(this.btnNewElement);
            this.grpRight.Controls.Add(this.btnDelSet);
            this.grpRight.Controls.Add(this.btnDelElement);
            this.grpRight.Controls.Add(this.btnNewSet);
            this.grpRight.Location = new System.Drawing.Point(638, 12);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(277, 458);
            this.grpRight.TabIndex = 4;
            this.grpRight.TabStop = false;
            // 
            // btnDbg
            // 
            this.btnDbg.Image = global::DressLikeADick.Properties.Resources.cog_8x;
            this.btnDbg.Location = new System.Drawing.Point(187, 368);
            this.btnDbg.Name = "btnDbg";
            this.btnDbg.Size = new System.Drawing.Size(84, 84);
            this.btnDbg.TabIndex = 2;
            this.btnDbg.UseVisualStyleBackColor = true;
            this.btnDbg.Click += new System.EventHandler(this.btnDbg_Click);
            // 
            // btnNewElement
            // 
            this.btnNewElement.Image = global::DressLikeADick.Properties.Resources.plus_8x;
            this.btnNewElement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewElement.Location = new System.Drawing.Point(6, 82);
            this.btnNewElement.Name = "btnNewElement";
            this.btnNewElement.Size = new System.Drawing.Size(265, 65);
            this.btnNewElement.TabIndex = 3;
            this.btnNewElement.Text = "btnNewElement";
            this.btnNewElement.UseVisualStyleBackColor = true;
            // 
            // btnDelSet
            // 
            this.btnDelSet.Image = global::DressLikeADick.Properties.Resources.minus_8x;
            this.btnDelSet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelSet.Location = new System.Drawing.Point(6, 153);
            this.btnDelSet.Name = "btnDelSet";
            this.btnDelSet.Size = new System.Drawing.Size(265, 65);
            this.btnDelSet.TabIndex = 2;
            this.btnDelSet.Text = "btnDelSet";
            this.btnDelSet.UseVisualStyleBackColor = true;
            // 
            // btnDelElement
            // 
            this.btnDelElement.Image = global::DressLikeADick.Properties.Resources.minus_8x;
            this.btnDelElement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelElement.Location = new System.Drawing.Point(6, 224);
            this.btnDelElement.Name = "btnDelElement";
            this.btnDelElement.Size = new System.Drawing.Size(265, 65);
            this.btnDelElement.TabIndex = 1;
            this.btnDelElement.Text = "btnDelElement";
            this.btnDelElement.UseVisualStyleBackColor = true;
            // 
            // btnNewSet
            // 
            this.btnNewSet.Image = global::DressLikeADick.Properties.Resources.plus_8x;
            this.btnNewSet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSet.Location = new System.Drawing.Point(6, 11);
            this.btnNewSet.Name = "btnNewSet";
            this.btnNewSet.Size = new System.Drawing.Size(265, 65);
            this.btnNewSet.TabIndex = 0;
            this.btnNewSet.Text = "btnNewSet";
            this.btnNewSet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 560);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpMainPic);
            this.Controls.Add(this.grpLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpMainPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.GroupBox grpMainPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Label lbl_hhmmss;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblAMPM;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.Button btnNewElement;
        private System.Windows.Forms.Button btnDelSet;
        private System.Windows.Forms.Button btnDelElement;
        private System.Windows.Forms.Button btnNewSet;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Button btnDbg;
    }
}

