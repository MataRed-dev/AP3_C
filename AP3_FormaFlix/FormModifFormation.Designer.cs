
namespace AP3_FormaFlix
{
    partial class FormModifFormation
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
            this.dtpdatepublication = new System.Windows.Forms.DateTimePicker();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCompetences = new System.Windows.Forms.ListBox();
            this.cbCompetences = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCompetences = new System.Windows.Forms.GroupBox();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCompetences.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpdatepublication
            // 
            this.dtpdatepublication.Location = new System.Drawing.Point(256, 334);
            this.dtpdatepublication.Name = "dtpdatepublication";
            this.dtpdatepublication.Size = new System.Drawing.Size(183, 20);
            this.dtpdatepublication.TabIndex = 32;
            // 
            // tbImage
            // 
            this.tbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImage.Location = new System.Drawing.Point(256, 200);
            this.tbImage.Multiline = true;
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(183, 81);
            this.tbImage.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Image";
            // 
            // lbCompetences
            // 
            this.lbCompetences.FormattingEnabled = true;
            this.lbCompetences.ItemHeight = 16;
            this.lbCompetences.Location = new System.Drawing.Point(7, 73);
            this.lbCompetences.Name = "lbCompetences";
            this.lbCompetences.Size = new System.Drawing.Size(187, 116);
            this.lbCompetences.TabIndex = 1;
            this.lbCompetences.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCompetences_MouseDoubleClick);
            // 
            // cbCompetences
            // 
            this.cbCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetences.FormattingEnabled = true;
            this.cbCompetences.Location = new System.Drawing.Point(6, 31);
            this.cbCompetences.Name = "cbCompetences";
            this.cbCompetences.Size = new System.Drawing.Size(188, 24);
            this.cbCompetences.TabIndex = 0;
            this.cbCompetences.SelectedIndexChanged += new System.EventHandler(this.cbCompetences_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date de publication";
            // 
            // gbCompetences
            // 
            this.gbCompetences.Controls.Add(this.lbCompetences);
            this.gbCompetences.Controls.Add(this.cbCompetences);
            this.gbCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompetences.Location = new System.Drawing.Point(520, 16);
            this.gbCompetences.Name = "gbCompetences";
            this.gbCompetences.Size = new System.Drawing.Size(200, 211);
            this.gbCompetences.TabIndex = 28;
            this.gbCompetences.TabStop = false;
            this.gbCompetences.Text = "Ajout des compétences";
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Location = new System.Drawing.Point(256, 293);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(45, 17);
            this.cbVisible.TabIndex = 26;
            this.cbVisible.Text = "OUI";
            this.cbVisible.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Visibilité Public";
            // 
            // tbVideo
            // 
            this.tbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideo.Location = new System.Drawing.Point(256, 160);
            this.tbVideo.Multiline = true;
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(183, 28);
            this.tbVideo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Identifiant Video";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(256, 60);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(183, 81);
            this.tbDescription.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description de la formation";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelle.Location = new System.Drawing.Point(256, 16);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(183, 22);
            this.tbLibelle.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Libellé de la formation";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(239, 393);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 41);
            this.btnModifier.TabIndex = 18;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(353, 393);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(86, 41);
            this.btnFermer.TabIndex = 17;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(545, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Pour enlever une compétence.\r\n       Double cliquer dessus.";
            // 
            // FormModifFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpdatepublication);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbCompetences);
            this.Controls.Add(this.cbVisible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormModifFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX : Modification d\'une formation";
            this.Load += new System.EventHandler(this.FormModifFormation_Load);
            this.gbCompetences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpdatepublication;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbCompetences;
        private System.Windows.Forms.ComboBox cbCompetences;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbCompetences;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label7;
    }
}