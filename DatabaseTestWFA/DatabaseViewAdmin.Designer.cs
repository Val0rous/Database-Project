﻿
namespace DatabaseProject
{
    partial class DatabaseViewAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.Business_Partners = new System.Windows.Forms.TabPage();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.Magazzino = new System.Windows.Forms.TabPage();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.AggiungiCliente = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.CodiceFiscale = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Tour = new System.Windows.Forms.TabPage();
            this.Clienti.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Dipendenti
            // 
            this.Dipendenti.Location = new System.Drawing.Point(4, 25);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3);
            this.Dipendenti.Size = new System.Drawing.Size(951, 495);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // Business_Partners
            // 
            this.Business_Partners.Location = new System.Drawing.Point(4, 25);
            this.Business_Partners.Name = "Business_Partners";
            this.Business_Partners.Padding = new System.Windows.Forms.Padding(3);
            this.Business_Partners.Size = new System.Drawing.Size(951, 495);
            this.Business_Partners.TabIndex = 6;
            this.Business_Partners.Text = "Business Partners";
            this.Business_Partners.UseVisualStyleBackColor = true;
            // 
            // Percorsi
            // 
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(951, 495);
            this.Percorsi.TabIndex = 5;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            // 
            // Magazzino
            // 
            this.Magazzino.Location = new System.Drawing.Point(4, 25);
            this.Magazzino.Name = "Magazzino";
            this.Magazzino.Padding = new System.Windows.Forms.Padding(3);
            this.Magazzino.Size = new System.Drawing.Size(951, 495);
            this.Magazzino.TabIndex = 2;
            this.Magazzino.Text = "Magazzini";
            this.Magazzino.UseVisualStyleBackColor = true;
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(951, 495);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.AggiungiCliente);
            this.Clienti.Controls.Add(this.Telefono);
            this.Clienti.Controls.Add(this.CodiceFiscale);
            this.Clienti.Controls.Add(this.Cognome);
            this.Clienti.Controls.Add(this.Nome);
            this.Clienti.Location = new System.Drawing.Point(4, 25);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(3);
            this.Clienti.Size = new System.Drawing.Size(951, 495);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Clienti";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // AggiungiCliente
            // 
            this.AggiungiCliente.Location = new System.Drawing.Point(19, 151);
            this.AggiungiCliente.Name = "AggiungiCliente";
            this.AggiungiCliente.Size = new System.Drawing.Size(165, 23);
            this.AggiungiCliente.TabIndex = 4;
            this.AggiungiCliente.Text = "Aggiungi Cliente";
            this.AggiungiCliente.UseVisualStyleBackColor = true;
            this.AggiungiCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(19, 123);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(165, 22);
            this.Telefono.TabIndex = 3;
            this.Telefono.Text = "Numero di Telefono";
            this.Telefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // CodiceFiscale
            // 
            this.CodiceFiscale.Location = new System.Drawing.Point(19, 94);
            this.CodiceFiscale.Name = "CodiceFiscale";
            this.CodiceFiscale.Size = new System.Drawing.Size(165, 22);
            this.CodiceFiscale.TabIndex = 2;
            this.CodiceFiscale.Text = "Codice Fiscale";
            this.CodiceFiscale.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Cognome
            // 
            this.Cognome.Location = new System.Drawing.Point(19, 66);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(165, 22);
            this.Cognome.TabIndex = 1;
            this.Cognome.Text = "Cognome";
            this.Cognome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(19, 38);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(165, 22);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // TabPage
            // 
            this.TabPage.AccessibleName = "";
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Prenotazioni);
            this.TabPage.Controls.Add(this.Magazzino);
            this.TabPage.Controls.Add(this.Percorsi);
            this.TabPage.Controls.Add(this.Business_Partners);
            this.TabPage.Controls.Add(this.Dipendenti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Location = new System.Drawing.Point(12, 55);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(959, 524);
            this.TabPage.TabIndex = 4;
            this.TabPage.Tag = "";
            // 
            // Tour
            // 
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(951, 495);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // DatabaseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewAdmin";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            this.TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Dipendenti;
        private System.Windows.Forms.TabPage Business_Partners;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Magazzino;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.Button AggiungiCliente;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox CodiceFiscale;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Tour;
    }
}
