
namespace DatabaseProject
{
    partial class DatabaseViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewUser));
            this.button1 = new System.Windows.Forms.Button();
            this.TabView = new System.Windows.Forms.TabControl();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.AggiungiCliente = new System.Windows.Forms.Button();
            this.Clienti_Telefono = new System.Windows.Forms.TextBox();
            this.Clienti_CF = new System.Windows.Forms.TextBox();
            this.Clienti_Cognome = new System.Windows.Forms.TextBox();
            this.Clienti_Nome = new System.Windows.Forms.TextBox();
            this.TabellaClienti = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recapitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionale_per_agenzie_relDataSet = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.TabellaPrenotazioni = new System.Windows.Forms.DataGridView();
            this.cFclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenotazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionale_per_agenzie_relDataSet1 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.TabellaPercorsi = new System.Windows.Forms.DataGridView();
            this.Tour = new System.Windows.Forms.TabPage();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.clienteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter();
            this.prenotazioneTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Pacchetti = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TabView.SuspendLayout();
            this.Clienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).BeginInit();
            this.Prenotazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPrenotazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).BeginInit();
            this.Percorsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).BeginInit();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).BeginInit();
            this.Pacchetti.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TabView
            // 
            this.TabView.Controls.Add(this.Clienti);
            this.TabView.Controls.Add(this.Prenotazioni);
            this.TabView.Controls.Add(this.Percorsi);
            this.TabView.Controls.Add(this.Tour);
            this.TabView.Controls.Add(this.Pacchetti);
            this.TabView.Location = new System.Drawing.Point(12, 55);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(787, 393);
            this.TabView.TabIndex = 9;
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.AggiungiCliente);
            this.Clienti.Controls.Add(this.Clienti_Telefono);
            this.Clienti.Controls.Add(this.Clienti_CF);
            this.Clienti.Controls.Add(this.Clienti_Cognome);
            this.Clienti.Controls.Add(this.Clienti_Nome);
            this.Clienti.Controls.Add(this.TabellaClienti);
            this.Clienti.Location = new System.Drawing.Point(4, 25);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(3);
            this.Clienti.Size = new System.Drawing.Size(779, 364);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Clienti";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // AggiungiCliente
            // 
            this.AggiungiCliente.Location = new System.Drawing.Point(6, 119);
            this.AggiungiCliente.Name = "AggiungiCliente";
            this.AggiungiCliente.Size = new System.Drawing.Size(178, 39);
            this.AggiungiCliente.TabIndex = 9;
            this.AggiungiCliente.Text = "Aggiungi Cliente";
            this.AggiungiCliente.UseVisualStyleBackColor = true;
            // 
            // Clienti_Telefono
            // 
            this.Clienti_Telefono.Location = new System.Drawing.Point(6, 91);
            this.Clienti_Telefono.Name = "Clienti_Telefono";
            this.Clienti_Telefono.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Telefono.TabIndex = 8;
            this.Clienti_Telefono.Text = "Numero di Telefono";
            // 
            // Clienti_CF
            // 
            this.Clienti_CF.Location = new System.Drawing.Point(6, 62);
            this.Clienti_CF.Name = "Clienti_CF";
            this.Clienti_CF.Size = new System.Drawing.Size(178, 22);
            this.Clienti_CF.TabIndex = 7;
            this.Clienti_CF.Text = "Codice Fiscale";
            // 
            // Clienti_Cognome
            // 
            this.Clienti_Cognome.Location = new System.Drawing.Point(6, 34);
            this.Clienti_Cognome.Name = "Clienti_Cognome";
            this.Clienti_Cognome.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Cognome.TabIndex = 6;
            this.Clienti_Cognome.Text = "Cognome";
            // 
            // Clienti_Nome
            // 
            this.Clienti_Nome.Location = new System.Drawing.Point(6, 6);
            this.Clienti_Nome.Name = "Clienti_Nome";
            this.Clienti_Nome.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Nome.TabIndex = 5;
            this.Clienti_Nome.Text = "Nome";
            // 
            // TabellaClienti
            // 
            this.TabellaClienti.AutoGenerateColumns = false;
            this.TabellaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.cFDataGridViewTextBoxColumn,
            this.recapitoDataGridViewTextBoxColumn});
            this.TabellaClienti.DataSource = this.clienteBindingSource;
            this.TabellaClienti.Location = new System.Drawing.Point(190, 6);
            this.TabellaClienti.Name = "TabellaClienti";
            this.TabellaClienti.ReadOnly = true;
            this.TabellaClienti.RowHeadersWidth = 51;
            this.TabellaClienti.RowTemplate.Height = 24;
            this.TabellaClienti.Size = new System.Drawing.Size(572, 342);
            this.TabellaClienti.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cognomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cFDataGridViewTextBoxColumn
            // 
            this.cFDataGridViewTextBoxColumn.DataPropertyName = "CF";
            this.cFDataGridViewTextBoxColumn.HeaderText = "CF";
            this.cFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFDataGridViewTextBoxColumn.Name = "cFDataGridViewTextBoxColumn";
            this.cFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFDataGridViewTextBoxColumn.Width = 125;
            // 
            // recapitoDataGridViewTextBoxColumn
            // 
            this.recapitoDataGridViewTextBoxColumn.DataPropertyName = "Recapito";
            this.recapitoDataGridViewTextBoxColumn.HeaderText = "Recapito";
            this.recapitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recapitoDataGridViewTextBoxColumn.Name = "recapitoDataGridViewTextBoxColumn";
            this.recapitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recapitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet;
            // 
            // gestionale_per_agenzie_relDataSet
            // 
            this.gestionale_per_agenzie_relDataSet.DataSetName = "gestionale_per_agenzie_relDataSet";
            this.gestionale_per_agenzie_relDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Controls.Add(this.TabellaPrenotazioni);
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(779, 364);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // TabellaPrenotazioni
            // 
            this.TabellaPrenotazioni.AutoGenerateColumns = false;
            this.TabellaPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPrenotazioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFclienteDataGridViewTextBoxColumn,
            this.iDtourDataGridViewTextBoxColumn});
            this.TabellaPrenotazioni.DataSource = this.prenotazioneBindingSource;
            this.TabellaPrenotazioni.Location = new System.Drawing.Point(3, 6);
            this.TabellaPrenotazioni.Name = "TabellaPrenotazioni";
            this.TabellaPrenotazioni.ReadOnly = true;
            this.TabellaPrenotazioni.RowHeadersWidth = 51;
            this.TabellaPrenotazioni.RowTemplate.Height = 24;
            this.TabellaPrenotazioni.Size = new System.Drawing.Size(759, 345);
            this.TabellaPrenotazioni.TabIndex = 0;
            // 
            // cFclienteDataGridViewTextBoxColumn
            // 
            this.cFclienteDataGridViewTextBoxColumn.DataPropertyName = "CFcliente";
            this.cFclienteDataGridViewTextBoxColumn.HeaderText = "CFcliente";
            this.cFclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFclienteDataGridViewTextBoxColumn.Name = "cFclienteDataGridViewTextBoxColumn";
            this.cFclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDtourDataGridViewTextBoxColumn
            // 
            this.iDtourDataGridViewTextBoxColumn.DataPropertyName = "IDtour";
            this.iDtourDataGridViewTextBoxColumn.HeaderText = "IDtour";
            this.iDtourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDtourDataGridViewTextBoxColumn.Name = "iDtourDataGridViewTextBoxColumn";
            this.iDtourDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDtourDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenotazioneBindingSource
            // 
            this.prenotazioneBindingSource.DataMember = "prenotazione";
            this.prenotazioneBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet1;
            // 
            // gestionale_per_agenzie_relDataSet1
            // 
            this.gestionale_per_agenzie_relDataSet1.DataSetName = "gestionale_per_agenzie_relDataSet1";
            this.gestionale_per_agenzie_relDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Percorsi
            // 
            this.Percorsi.Controls.Add(this.TabellaPercorsi);
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(779, 364);
            this.Percorsi.TabIndex = 2;
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
            this.TabellaPercorsi.Size = new System.Drawing.Size(756, 342);
            this.TabellaPercorsi.TabIndex = 0;
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(779, 364);
            this.Tour.TabIndex = 3;
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
            this.TabellaTour.Size = new System.Drawing.Size(756, 342);
            this.TabellaTour.TabIndex = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // prenotazioneTableAdapter
            // 
            this.prenotazioneTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(57, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(39, 37);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshAll);
            // 
            // Pacchetti
            // 
            this.Pacchetti.Controls.Add(this.textBox2);
            this.Pacchetti.Controls.Add(this.textBox1);
            this.Pacchetti.Location = new System.Drawing.Point(4, 25);
            this.Pacchetti.Name = "Pacchetti";
            this.Pacchetti.Padding = new System.Windows.Forms.Padding(3);
            this.Pacchetti.Size = new System.Drawing.Size(779, 364);
            this.Pacchetti.TabIndex = 4;
            this.Pacchetti.Text = "Pacchetti";
            this.Pacchetti.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // DatabaseViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TabView);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewUser";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.DatabaseViewUser_Load);
            this.TabView.ResumeLayout(false);
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).EndInit();
            this.Prenotazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPrenotazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).EndInit();
            this.Percorsi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).EndInit();
            this.Tour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
            this.Pacchetti.ResumeLayout(false);
            this.Pacchetti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.DataGridView TabellaClienti;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet gestionale_per_agenzie_relDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recapitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TabellaPrenotazioni;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1 gestionale_per_agenzie_relDataSet1;
        private System.Windows.Forms.BindingSource prenotazioneBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter prenotazioneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TabellaPercorsi;
        private System.Windows.Forms.DataGridView TabellaTour;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AggiungiCliente;
        private System.Windows.Forms.TextBox Clienti_Telefono;
        private System.Windows.Forms.TextBox Clienti_CF;
        private System.Windows.Forms.TextBox Clienti_Cognome;
        private System.Windows.Forms.TextBox Clienti_Nome;
        private System.Windows.Forms.TabPage Pacchetti;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}