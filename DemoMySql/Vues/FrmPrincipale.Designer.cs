namespace DemoMySql.Vues
{
    partial class FrmPrincipale
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(13, 226);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "&Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.BtnPopulate_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(603, 226);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Location = new System.Drawing.Point(13, 13);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.Size = new System.Drawing.Size(665, 207);
            this.dgvPersonne.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPopulate);
            this.Name = "FrmPrincipale";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.Button btnSave;
    }
}

