namespace AP3_FormaFlix
{
    partial class FormListeCommentaire
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
            this.btnListeComm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListeCommValide = new System.Windows.Forms.DataGridView();
            this.dgvListeCommNonValide = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCommATraiter = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommNonValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommATraiter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListeComm
            // 
            this.btnListeComm.BackColor = System.Drawing.Color.Black;
            this.btnListeComm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListeComm.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeComm.ForeColor = System.Drawing.Color.White;
            this.btnListeComm.Location = new System.Drawing.Point(12, 12);
            this.btnListeComm.Name = "btnListeComm";
            this.btnListeComm.Size = new System.Drawing.Size(115, 67);
            this.btnListeComm.TabIndex = 28;
            this.btnListeComm.Text = "traiter  commentaires";
            this.btnListeComm.UseVisualStyleBackColor = false;
            this.btnListeComm.Click += new System.EventHandler(this.btnListeComm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(353, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 41);
            this.label8.TabIndex = 29;
            this.label8.Text = "liste des commentaires";
            // 
            // dgvListeCommValide
            // 
            this.dgvListeCommValide.AllowDrop = true;
            this.dgvListeCommValide.AllowUserToAddRows = false;
            this.dgvListeCommValide.AllowUserToDeleteRows = false;
            this.dgvListeCommValide.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeCommValide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeCommValide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCommValide.Location = new System.Drawing.Point(56, 363);
            this.dgvListeCommValide.Name = "dgvListeCommValide";
            this.dgvListeCommValide.ReadOnly = true;
            this.dgvListeCommValide.Size = new System.Drawing.Size(879, 190);
            this.dgvListeCommValide.TabIndex = 30;
            // 
            // dgvListeCommNonValide
            // 
            this.dgvListeCommNonValide.AllowDrop = true;
            this.dgvListeCommNonValide.AllowUserToAddRows = false;
            this.dgvListeCommNonValide.AllowUserToDeleteRows = false;
            this.dgvListeCommNonValide.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeCommNonValide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeCommNonValide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCommNonValide.Location = new System.Drawing.Point(56, 604);
            this.dgvListeCommNonValide.Name = "dgvListeCommNonValide";
            this.dgvListeCommNonValide.ReadOnly = true;
            this.dgvListeCommNonValide.Size = new System.Drawing.Size(879, 193);
            this.dgvListeCommNonValide.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "NON VALIDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "VALIDE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "A TRAITER";
            // 
            // dgvCommATraiter
            // 
            this.dgvCommATraiter.AllowDrop = true;
            this.dgvCommATraiter.AllowUserToAddRows = false;
            this.dgvCommATraiter.AllowUserToDeleteRows = false;
            this.dgvCommATraiter.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommATraiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommATraiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommATraiter.Location = new System.Drawing.Point(56, 137);
            this.dgvCommATraiter.Name = "dgvCommATraiter";
            this.dgvCommATraiter.ReadOnly = true;
            this.dgvCommATraiter.Size = new System.Drawing.Size(879, 190);
            this.dgvCommATraiter.TabIndex = 34;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(861, 12);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(134, 47);
            this.btnFermer.TabIndex = 36;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormListeCommentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1007, 835);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCommATraiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListeCommNonValide);
            this.Controls.Add(this.dgvListeCommValide);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListeComm);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListeCommentaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListeCommentaire";
            this.Load += new System.EventHandler(this.FormListeCommentaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommNonValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommATraiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListeComm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListeCommValide;
        private System.Windows.Forms.DataGridView dgvListeCommNonValide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCommATraiter;
        private System.Windows.Forms.Button btnFermer;
    }
}