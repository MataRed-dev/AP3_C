namespace AP3_FormaFlix
{
    partial class FormListeFormations
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFormations = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listeDesCompétencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnsuppforma = new System.Windows.Forms.Button();
            this.btnModifForma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFormations
            // 
            this.dgvFormations.AllowUserToAddRows = false;
            this.dgvFormations.AllowUserToDeleteRows = false;
            this.dgvFormations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFormations.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormations.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFormations.Location = new System.Drawing.Point(39, 48);
            this.dgvFormations.MultiSelect = false;
            this.dgvFormations.Name = "dgvFormations";
            this.dgvFormations.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFormations.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFormations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormations.Size = new System.Drawing.Size(792, 192);
            this.dgvFormations.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCompétencesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.ListeDesCompétencesToolStripMenuItem_Click);
            // 
            // listeDesCompétencesToolStripMenuItem
            // 
            this.listeDesCompétencesToolStripMenuItem.Name = "listeDesCompétencesToolStripMenuItem";
            this.listeDesCompétencesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listeDesCompétencesToolStripMenuItem.Text = "Liste des compétences";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Formations";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(450, 260);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(82, 39);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // btnsuppforma
            // 
            this.btnsuppforma.BackColor = System.Drawing.Color.Black;
            this.btnsuppforma.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppforma.ForeColor = System.Drawing.Color.White;
            this.btnsuppforma.Location = new System.Drawing.Point(312, 260);
            this.btnsuppforma.Name = "btnsuppforma";
            this.btnsuppforma.Size = new System.Drawing.Size(113, 39);
            this.btnsuppforma.TabIndex = 8;
            this.btnsuppforma.Text = "SUPPRIMER";
            this.btnsuppforma.UseVisualStyleBackColor = false;
            this.btnsuppforma.Visible = false;
            this.btnsuppforma.Click += new System.EventHandler(this.btnsuppforma_Click);
            // 
            // btnModifForma
            // 
            this.btnModifForma.BackColor = System.Drawing.Color.Black;
            this.btnModifForma.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifForma.ForeColor = System.Drawing.Color.White;
            this.btnModifForma.Location = new System.Drawing.Point(312, 260);
            this.btnModifForma.Name = "btnModifForma";
            this.btnModifForma.Size = new System.Drawing.Size(113, 39);
            this.btnModifForma.TabIndex = 9;
            this.btnModifForma.Text = "MODIFIER";
            this.btnModifForma.UseVisualStyleBackColor = false;
            this.btnModifForma.Visible = false;
            this.btnModifForma.Click += new System.EventHandler(this.btnModifForma_Click);
            // 
            // FormListeFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(883, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnsuppforma);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFormations);
            this.Controls.Add(this.btnModifForma);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListeFormations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX : Liste des Formations";
            this.Load += new System.EventHandler(this.FormListeFormations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesCompétencesToolStripMenuItem;
        private System.Windows.Forms.Button btnsuppforma;
        private System.Windows.Forms.Button btnModifForma;
    }
}