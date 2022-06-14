
namespace DatabaseTestWFA
{
    partial class Form1
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
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.Magazzino = new System.Windows.Forms.TabPage();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.Agenzie = new System.Windows.Forms.TabPage();
            this.Sedi = new System.Windows.Forms.TabPage();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.Business_Partners = new System.Windows.Forms.TabPage();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.AccessibleName = "";
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Prenotazioni);
            this.TabPage.Controls.Add(this.Magazzino);
            this.TabPage.Controls.Add(this.Agenzie);
            this.TabPage.Controls.Add(this.Sedi);
            this.TabPage.Controls.Add(this.Percorsi);
            this.TabPage.Controls.Add(this.Business_Partners);
            this.TabPage.Controls.Add(this.Dipendenti);
            this.TabPage.Location = new System.Drawing.Point(12, 12);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(959, 567);
            this.TabPage.TabIndex = 4;
            this.TabPage.Tag = "";
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(951, 538);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // Magazzino
            // 
            this.Magazzino.Location = new System.Drawing.Point(4, 25);
            this.Magazzino.Name = "Magazzino";
            this.Magazzino.Padding = new System.Windows.Forms.Padding(3);
            this.Magazzino.Size = new System.Drawing.Size(951, 538);
            this.Magazzino.TabIndex = 2;
            this.Magazzino.Text = "Magazzino";
            this.Magazzino.UseVisualStyleBackColor = true;
            // 
            // Clienti
            // 
            this.Clienti.Location = new System.Drawing.Point(4, 25);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(3);
            this.Clienti.Size = new System.Drawing.Size(951, 538);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Clienti";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // Agenzie
            // 
            this.Agenzie.Location = new System.Drawing.Point(4, 25);
            this.Agenzie.Name = "Agenzie";
            this.Agenzie.Padding = new System.Windows.Forms.Padding(3);
            this.Agenzie.Size = new System.Drawing.Size(951, 538);
            this.Agenzie.TabIndex = 3;
            this.Agenzie.Text = "Agenzie";
            this.Agenzie.UseVisualStyleBackColor = true;
            // 
            // Sedi
            // 
            this.Sedi.Location = new System.Drawing.Point(4, 25);
            this.Sedi.Name = "Sedi";
            this.Sedi.Padding = new System.Windows.Forms.Padding(3);
            this.Sedi.Size = new System.Drawing.Size(951, 538);
            this.Sedi.TabIndex = 4;
            this.Sedi.Text = "Sedi";
            this.Sedi.UseVisualStyleBackColor = true;
            // 
            // Percorsi
            // 
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(951, 538);
            this.Percorsi.TabIndex = 5;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            // 
            // Business_Partners
            // 
            this.Business_Partners.Location = new System.Drawing.Point(4, 25);
            this.Business_Partners.Name = "Business_Partners";
            this.Business_Partners.Padding = new System.Windows.Forms.Padding(3);
            this.Business_Partners.Size = new System.Drawing.Size(951, 538);
            this.Business_Partners.TabIndex = 6;
            this.Business_Partners.Text = "Business Partners";
            this.Business_Partners.UseVisualStyleBackColor = true;
            // 
            // Dipendenti
            // 
            this.Dipendenti.Location = new System.Drawing.Point(4, 25);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3);
            this.Dipendenti.Size = new System.Drawing.Size(951, 538);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 591);
            this.Controls.Add(this.TabPage);
            this.Name = "Form1";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Magazzino;
        private System.Windows.Forms.TabPage Agenzie;
        private System.Windows.Forms.TabPage Sedi;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Business_Partners;
        private System.Windows.Forms.TabPage Dipendenti;
    }
}

