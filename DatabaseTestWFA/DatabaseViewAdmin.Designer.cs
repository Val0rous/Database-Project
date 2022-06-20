
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewAdmin));
            this.BackButton = new System.Windows.Forms.Button();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.TabellaDipendenti = new System.Windows.Forms.DataGridView();
            this.Business_Partners = new System.Windows.Forms.TabPage();
            this.TabellaBusinessPartners = new System.Windows.Forms.DataGridView();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.TabellaPercorsi = new System.Windows.Forms.DataGridView();
            this.Magazzini = new System.Windows.Forms.TabPage();
            this.TabellaMagazzini = new System.Windows.Forms.DataGridView();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.TabellaPrenotazioni = new System.Windows.Forms.DataGridView();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.TabellaClienti = new System.Windows.Forms.DataGridView();
            this.AggiungiCliente = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.CodiceFiscale = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Tour = new System.Windows.Forms.TabPage();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.gestionale_per_agenzie_relDataSet2 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2();
            this.dipendenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipendenteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2TableAdapters.dipendenteTableAdapter();
            this.gestionale_per_agenzie_relDataSet3 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3();
            this.magazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazzinoTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3TableAdapters.magazzinoTableAdapter();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Dipendenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).BeginInit();
            this.Business_Partners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBusinessPartners)).BeginInit();
            this.Percorsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).BeginInit();
            this.Magazzini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaMagazzini)).BeginInit();
            this.Prenotazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPrenotazioni)).BeginInit();
            this.Clienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).BeginInit();
            this.TabPage.SuspendLayout();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipendenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazzinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 37);
            this.BackButton.TabIndex = 7;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Dipendenti
            // 
            this.Dipendenti.Controls.Add(this.TabellaDipendenti);
            this.Dipendenti.Location = new System.Drawing.Point(4, 25);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3);
            this.Dipendenti.Size = new System.Drawing.Size(951, 495);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // TabellaDipendenti
            // 
            this.TabellaDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaDipendenti.Location = new System.Drawing.Point(6, 6);
            this.TabellaDipendenti.Name = "TabellaDipendenti";
            this.TabellaDipendenti.ReadOnly = true;
            this.TabellaDipendenti.RowHeadersWidth = 51;
            this.TabellaDipendenti.RowTemplate.Height = 24;
            this.TabellaDipendenti.Size = new System.Drawing.Size(939, 486);
            this.TabellaDipendenti.TabIndex = 0;
            // 
            // Business_Partners
            // 
            this.Business_Partners.Controls.Add(this.TabellaBusinessPartners);
            this.Business_Partners.Location = new System.Drawing.Point(4, 25);
            this.Business_Partners.Name = "Business_Partners";
            this.Business_Partners.Padding = new System.Windows.Forms.Padding(3);
            this.Business_Partners.Size = new System.Drawing.Size(951, 495);
            this.Business_Partners.TabIndex = 6;
            this.Business_Partners.Text = "Business Partners";
            this.Business_Partners.UseVisualStyleBackColor = true;
            // 
            // TabellaBusinessPartners
            // 
            this.TabellaBusinessPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBusinessPartners.Location = new System.Drawing.Point(6, 6);
            this.TabellaBusinessPartners.Name = "TabellaBusinessPartners";
            this.TabellaBusinessPartners.ReadOnly = true;
            this.TabellaBusinessPartners.RowHeadersWidth = 51;
            this.TabellaBusinessPartners.RowTemplate.Height = 24;
            this.TabellaBusinessPartners.Size = new System.Drawing.Size(939, 483);
            this.TabellaBusinessPartners.TabIndex = 0;
            this.TabellaBusinessPartners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Percorsi
            // 
            this.Percorsi.Controls.Add(this.TabellaPercorsi);
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(951, 495);
            this.Percorsi.TabIndex = 5;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            // 
            // TabellaPercorsi
            // 
            this.TabellaPercorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPercorsi.Location = new System.Drawing.Point(6, 6);
            this.TabellaPercorsi.Name = "TabellaPercorsi";
            this.TabellaPercorsi.ReadOnly = true;
            this.TabellaPercorsi.RowHeadersWidth = 51;
            this.TabellaPercorsi.RowTemplate.Height = 24;
            this.TabellaPercorsi.Size = new System.Drawing.Size(939, 486);
            this.TabellaPercorsi.TabIndex = 0;
            // 
            // Magazzini
            // 
            this.Magazzini.Controls.Add(this.TabellaMagazzini);
            this.Magazzini.Location = new System.Drawing.Point(4, 25);
            this.Magazzini.Name = "Magazzini";
            this.Magazzini.Padding = new System.Windows.Forms.Padding(3);
            this.Magazzini.Size = new System.Drawing.Size(951, 495);
            this.Magazzini.TabIndex = 2;
            this.Magazzini.Text = "Magazzini";
            this.Magazzini.UseVisualStyleBackColor = true;
            // 
            // TabellaMagazzini
            // 
            this.TabellaMagazzini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaMagazzini.Location = new System.Drawing.Point(6, 6);
            this.TabellaMagazzini.Name = "TabellaMagazzini";
            this.TabellaMagazzini.ReadOnly = true;
            this.TabellaMagazzini.RowHeadersWidth = 51;
            this.TabellaMagazzini.RowTemplate.Height = 24;
            this.TabellaMagazzini.Size = new System.Drawing.Size(939, 483);
            this.TabellaMagazzini.TabIndex = 0;
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Controls.Add(this.TabellaPrenotazioni);
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(951, 495);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // TabellaPrenotazioni
            // 
            this.TabellaPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPrenotazioni.Location = new System.Drawing.Point(6, 6);
            this.TabellaPrenotazioni.Name = "TabellaPrenotazioni";
            this.TabellaPrenotazioni.ReadOnly = true;
            this.TabellaPrenotazioni.RowHeadersWidth = 51;
            this.TabellaPrenotazioni.RowTemplate.Height = 24;
            this.TabellaPrenotazioni.Size = new System.Drawing.Size(939, 483);
            this.TabellaPrenotazioni.TabIndex = 0;
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.TabellaClienti);
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
            // TabellaClienti
            // 
            this.TabellaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaClienti.Location = new System.Drawing.Point(190, 6);
            this.TabellaClienti.Name = "TabellaClienti";
            this.TabellaClienti.ReadOnly = true;
            this.TabellaClienti.RowHeadersWidth = 51;
            this.TabellaClienti.RowTemplate.Height = 24;
            this.TabellaClienti.Size = new System.Drawing.Size(755, 483);
            this.TabellaClienti.TabIndex = 5;
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
            this.TabPage.Controls.Add(this.Magazzini);
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
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(951, 495);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // TabellaTour
            // 
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(6, 6);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(939, 486);
            this.TabellaTour.TabIndex = 0;
            // 
            // gestionale_per_agenzie_relDataSet2
            // 
            this.gestionale_per_agenzie_relDataSet2.DataSetName = "gestionale_per_agenzie_relDataSet2";
            this.gestionale_per_agenzie_relDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dipendenteBindingSource
            // 
            this.dipendenteBindingSource.DataMember = "dipendente";
            this.dipendenteBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet2;
            // 
            // dipendenteTableAdapter
            // 
            this.dipendenteTableAdapter.ClearBeforeFill = true;
            // 
            // gestionale_per_agenzie_relDataSet3
            // 
            this.gestionale_per_agenzie_relDataSet3.DataSetName = "gestionale_per_agenzie_relDataSet3";
            this.gestionale_per_agenzie_relDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazzinoBindingSource
            // 
            this.magazzinoBindingSource.DataMember = "magazzino";
            this.magazzinoBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet3;
            // 
            // magazzinoTableAdapter
            // 
            this.magazzinoTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(57, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(39, 37);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshAll);
            // 
            // DatabaseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 591);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewAdmin";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.DatabaseViewAdmin_Load);
            this.Dipendenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).EndInit();
            this.Business_Partners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBusinessPartners)).EndInit();
            this.Percorsi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).EndInit();
            this.Magazzini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaMagazzini)).EndInit();
            this.Prenotazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPrenotazioni)).EndInit();
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.Tour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipendenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazzinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage Dipendenti;
        private System.Windows.Forms.TabPage Business_Partners;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Magazzini;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.Button AggiungiCliente;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox CodiceFiscale;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.DataGridView TabellaDipendenti;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet2 gestionale_per_agenzie_relDataSet2;
        private System.Windows.Forms.BindingSource dipendenteBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet2TableAdapters.dipendenteTableAdapter dipendenteTableAdapter;
        private System.Windows.Forms.DataGridView TabellaMagazzini;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet3 gestionale_per_agenzie_relDataSet3;
        private System.Windows.Forms.BindingSource magazzinoBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet3TableAdapters.magazzinoTableAdapter magazzinoTableAdapter;
        private System.Windows.Forms.DataGridView TabellaTour;
        private System.Windows.Forms.DataGridView TabellaBusinessPartners;
        private System.Windows.Forms.DataGridView TabellaPercorsi;
        private System.Windows.Forms.DataGridView TabellaPrenotazioni;
        private System.Windows.Forms.DataGridView TabellaClienti;
        private System.Windows.Forms.Button RefreshButton;
    }
}

