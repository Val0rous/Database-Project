
using System.Windows.Forms;

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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Tour = new System.Windows.Forms.TabPage();
            this.TourPrezzo = new System.Windows.Forms.TextBox();
            this.TourCFManager = new System.Windows.Forms.TextBox();
            this.TourDataFine = new System.Windows.Forms.TextBox();
            this.TourDataInizio = new System.Windows.Forms.TextBox();
            this.TourNome = new System.Windows.Forms.TextBox();
            this.TourDestinazione = new System.Windows.Forms.TextBox();
            this.TourID = new System.Windows.Forms.TextBox();
            this.AggiungiTour = new System.Windows.Forms.Button();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.DipendentiAgenzia = new System.Windows.Forms.Button();
            this.Dipendente_isAltro = new System.Windows.Forms.CheckBox();
            this.Dipendente_isTourManager = new System.Windows.Forms.CheckBox();
            this.Dipendente_isGuida = new System.Windows.Forms.CheckBox();
            this.Dipendenti_CFsuperiore = new System.Windows.Forms.TextBox();
            this.Dipendenti_IDsede = new System.Windows.Forms.TextBox();
            this.Dipendenti_Stipendio = new System.Windows.Forms.TextBox();
            this.Dipendenti_CodiceDipendente = new System.Windows.Forms.TextBox();
            this.Dipendenti_Telefono = new System.Windows.Forms.TextBox();
            this.Dipendenti_CF = new System.Windows.Forms.TextBox();
            this.Dipendenti_Cognome = new System.Windows.Forms.TextBox();
            this.Dipendenti_Nome = new System.Windows.Forms.TextBox();
            this.AggiungiDipendente = new System.Windows.Forms.Button();
            this.TabellaDipendenti = new System.Windows.Forms.DataGridView();
            this.Business_Partners = new System.Windows.Forms.TabPage();
            this.TabellaBusinessPartners = new System.Windows.Forms.DataGridView();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.AggiungiTappa = new System.Windows.Forms.Button();
            this.NuovaTappa_IDpercorso = new System.Windows.Forms.TextBox();
            this.NuovaTappa_IDtappa = new System.Windows.Forms.TextBox();
            this.NuovaTappa_Lunghezza = new System.Windows.Forms.TextBox();
            this.NuovaTappa_Fine = new System.Windows.Forms.TextBox();
            this.NuovaTappa_Inizio = new System.Windows.Forms.TextBox();
            this.Percorsi_IDsede = new System.Windows.Forms.TextBox();
            this.Percorsi_Lunghezza = new System.Windows.Forms.TextBox();
            this.Percorsi_NumTappe = new System.Windows.Forms.TextBox();
            this.Percorsi_Nome = new System.Windows.Forms.TextBox();
            this.Percorsi_Difficolta = new System.Windows.Forms.TextBox();
            this.Percorsi_IDpercorso = new System.Windows.Forms.TextBox();
            this.AggiungiPercorso = new System.Windows.Forms.Button();
            this.TabellaPercorsi = new System.Windows.Forms.DataGridView();
            this.Magazzini = new System.Windows.Forms.TabPage();
            this.Magazzini_IDsede = new System.Windows.Forms.TextBox();
            this.Magazzini_IDindirizzo = new System.Windows.Forms.TextBox();
            this.Magazzini_IDmagazzino = new System.Windows.Forms.TextBox();
            this.Magazzini_CapMaxBici = new System.Windows.Forms.TextBox();
            this.Magazzini_CapMaxAccessori = new System.Windows.Forms.TextBox();
            this.AggiungiMagazzino = new System.Windows.Forms.Button();
            this.TabellaMagazzini = new System.Windows.Forms.DataGridView();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.TabellaClienti = new System.Windows.Forms.DataGridView();
            this.AggiungiCliente = new System.Windows.Forms.Button();
            this.Clienti_Telefono = new System.Windows.Forms.TextBox();
            this.Clienti_CF = new System.Windows.Forms.TextBox();
            this.Clienti_Cognome = new System.Windows.Forms.TextBox();
            this.Clienti_Nome = new System.Windows.Forms.TextBox();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Servizi = new System.Windows.Forms.TabPage();
            this.Servizio_PeriodoMedioAccessori = new System.Windows.Forms.Label();
            this.Servizio_PeriodoMedioBici = new System.Windows.Forms.Label();
            this.Servizio_AccessorioTop = new System.Windows.Forms.Label();
            this.Servizio_TagliaBiciTop = new System.Windows.Forms.Label();
            this.Servizi_DataFine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Servizi_Calcola = new System.Windows.Forms.Button();
            this.Servizi_DataInizio = new System.Windows.Forms.TextBox();
            this.TabellaServizi = new System.Windows.Forms.DataGridView();
            this.ThisSedeID = new System.Windows.Forms.Label();
            this.gestionale_per_agenzie_relDataSet2 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2();
            this.dipendenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipendenteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2TableAdapters.dipendenteTableAdapter();
            this.gestionale_per_agenzie_relDataSet3 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3();
            this.magazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazzinoTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3TableAdapters.magazzinoTableAdapter();
            this.Dipendenti_StipendioMedio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).BeginInit();
            this.Dipendenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).BeginInit();
            this.Business_Partners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBusinessPartners)).BeginInit();
            this.Percorsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).BeginInit();
            this.Magazzini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaMagazzini)).BeginInit();
            this.Clienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).BeginInit();
            this.TabPage.SuspendLayout();
            this.Servizi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaServizi)).BeginInit();
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
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 37);
            this.BackButton.TabIndex = 7;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(57, 12);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(39, 37);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshAll);
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TourPrezzo);
            this.Tour.Controls.Add(this.TourCFManager);
            this.Tour.Controls.Add(this.TourDataFine);
            this.Tour.Controls.Add(this.TourDataInizio);
            this.Tour.Controls.Add(this.TourNome);
            this.Tour.Controls.Add(this.TourDestinazione);
            this.Tour.Controls.Add(this.TourID);
            this.Tour.Controls.Add(this.AggiungiTour);
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Size = new System.Drawing.Size(951, 495);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // TourPrezzo
            // 
            this.TourPrezzo.Location = new System.Drawing.Point(5, 149);
            this.TourPrezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourPrezzo.Name = "TourPrezzo";
            this.TourPrezzo.Size = new System.Drawing.Size(177, 22);
            this.TourPrezzo.TabIndex = 19;
            this.TourPrezzo.Text = "Prezzo";
            this.TourPrezzo.Enter += new System.EventHandler(this.TourPrezzo_Enter);
            this.TourPrezzo.Leave += new System.EventHandler(this.Tour_Prezzo_Leave);
            // 
            // TourCFManager
            // 
            this.TourCFManager.Location = new System.Drawing.Point(5, 180);
            this.TourCFManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourCFManager.Name = "TourCFManager";
            this.TourCFManager.Size = new System.Drawing.Size(177, 22);
            this.TourCFManager.TabIndex = 18;
            this.TourCFManager.Text = "CF del Tour Manager";
            this.TourCFManager.Enter += new System.EventHandler(this.TourCFtourManager_Enter);
            this.TourCFManager.Leave += new System.EventHandler(this.TourCFtourManager_Leave);
            // 
            // TourDataFine
            // 
            this.TourDataFine.Location = new System.Drawing.Point(5, 119);
            this.TourDataFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourDataFine.Name = "TourDataFine";
            this.TourDataFine.Size = new System.Drawing.Size(177, 22);
            this.TourDataFine.TabIndex = 16;
            this.TourDataFine.Text = "Data Fine (YYYY-MM-DD)";
            this.TourDataFine.Enter += new System.EventHandler(this.TourDataFine_Enter);
            this.TourDataFine.Leave += new System.EventHandler(this.TourDataFine_Leave);
            // 
            // TourDataInizio
            // 
            this.TourDataInizio.Location = new System.Drawing.Point(5, 91);
            this.TourDataInizio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourDataInizio.Name = "TourDataInizio";
            this.TourDataInizio.Size = new System.Drawing.Size(177, 22);
            this.TourDataInizio.TabIndex = 15;
            this.TourDataInizio.Text = "Data Inizio (YYYY-MM-DD)";
            this.TourDataInizio.Enter += new System.EventHandler(this.TourDataInizio_Enter);
            this.TourDataInizio.Leave += new System.EventHandler(this.TourDataInizio_Leave);
            // 
            // TourNome
            // 
            this.TourNome.Location = new System.Drawing.Point(5, 62);
            this.TourNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourNome.Name = "TourNome";
            this.TourNome.Size = new System.Drawing.Size(177, 22);
            this.TourNome.TabIndex = 14;
            this.TourNome.Text = "Nome";
            this.TourNome.Enter += new System.EventHandler(this.TourNome_Enter);
            this.TourNome.Leave += new System.EventHandler(this.Tour_Nome_Leave);
            // 
            // TourDestinazione
            // 
            this.TourDestinazione.Location = new System.Drawing.Point(5, 34);
            this.TourDestinazione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourDestinazione.Name = "TourDestinazione";
            this.TourDestinazione.Size = new System.Drawing.Size(177, 22);
            this.TourDestinazione.TabIndex = 13;
            this.TourDestinazione.Text = "Destinazione";
            this.TourDestinazione.Enter += new System.EventHandler(this.TourDestinazione_Enter);
            this.TourDestinazione.Leave += new System.EventHandler(this.TourDestinazione_Leave);
            // 
            // TourID
            // 
            this.TourID.Location = new System.Drawing.Point(7, 7);
            this.TourID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TourID.Name = "TourID";
            this.TourID.Size = new System.Drawing.Size(175, 22);
            this.TourID.TabIndex = 12;
            this.TourID.Text = "ID Tour";
            this.TourID.Enter += new System.EventHandler(this.Tour_ID_Enter);
            this.TourID.Leave += new System.EventHandler(this.Tour_ID_Leave);
            // 
            // AggiungiTour
            // 
            this.AggiungiTour.Location = new System.Drawing.Point(5, 209);
            this.AggiungiTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiTour.Name = "AggiungiTour";
            this.AggiungiTour.Size = new System.Drawing.Size(177, 34);
            this.AggiungiTour.TabIndex = 9;
            this.AggiungiTour.Text = "Aggiungi Tour";
            this.AggiungiTour.UseVisualStyleBackColor = true;
            this.AggiungiTour.Click += new System.EventHandler(this.AggiungiTour_Click);
            // 
            // TabellaTour
            // 
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(189, 6);
            this.TabellaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(755, 486);
            this.TabellaTour.TabIndex = 0;
            // 
            // Dipendenti
            // 
            this.Dipendenti.Controls.Add(this.label6);
            this.Dipendenti.Controls.Add(this.Dipendenti_StipendioMedio);
            this.Dipendenti.Controls.Add(this.DipendentiAgenzia);
            this.Dipendenti.Controls.Add(this.Dipendente_isAltro);
            this.Dipendenti.Controls.Add(this.Dipendente_isTourManager);
            this.Dipendenti.Controls.Add(this.Dipendente_isGuida);
            this.Dipendenti.Controls.Add(this.Dipendenti_CFsuperiore);
            this.Dipendenti.Controls.Add(this.Dipendenti_IDsede);
            this.Dipendenti.Controls.Add(this.Dipendenti_Stipendio);
            this.Dipendenti.Controls.Add(this.Dipendenti_CodiceDipendente);
            this.Dipendenti.Controls.Add(this.Dipendenti_Telefono);
            this.Dipendenti.Controls.Add(this.Dipendenti_CF);
            this.Dipendenti.Controls.Add(this.Dipendenti_Cognome);
            this.Dipendenti.Controls.Add(this.Dipendenti_Nome);
            this.Dipendenti.Controls.Add(this.AggiungiDipendente);
            this.Dipendenti.Controls.Add(this.TabellaDipendenti);
            this.Dipendenti.Location = new System.Drawing.Point(4, 25);
            this.Dipendenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti.Size = new System.Drawing.Size(951, 495);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            this.Dipendenti.Click += new System.EventHandler(this.Dipendenti_Click);
            // 
            // DipendentiAgenzia
            // 
            this.DipendentiAgenzia.Location = new System.Drawing.Point(3, 362);
            this.DipendentiAgenzia.Margin = new System.Windows.Forms.Padding(4);
            this.DipendentiAgenzia.Name = "DipendentiAgenzia";
            this.DipendentiAgenzia.Size = new System.Drawing.Size(175, 47);
            this.DipendentiAgenzia.TabIndex = 0;
            this.DipendentiAgenzia.Text = "Visualizza tutti i dipendenti dell\'agenzia";
            this.DipendentiAgenzia.Click += new System.EventHandler(this.DipendentiAgenzia_Click);
            // 
            // Dipendente_isAltro
            // 
            this.Dipendente_isAltro.AutoSize = true;
            this.Dipendente_isAltro.Location = new System.Drawing.Point(7, 230);
            this.Dipendente_isAltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendente_isAltro.Name = "Dipendente_isAltro";
            this.Dipendente_isAltro.Size = new System.Drawing.Size(59, 21);
            this.Dipendente_isAltro.TabIndex = 21;
            this.Dipendente_isAltro.Text = "Altro";
            this.Dipendente_isAltro.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isTourManager
            // 
            this.Dipendente_isTourManager.AutoSize = true;
            this.Dipendente_isTourManager.Location = new System.Drawing.Point(7, 203);
            this.Dipendente_isTourManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendente_isTourManager.Name = "Dipendente_isTourManager";
            this.Dipendente_isTourManager.Size = new System.Drawing.Size(116, 21);
            this.Dipendente_isTourManager.TabIndex = 20;
            this.Dipendente_isTourManager.Text = "TourManager";
            this.Dipendente_isTourManager.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isGuida
            // 
            this.Dipendente_isGuida.AutoSize = true;
            this.Dipendente_isGuida.Location = new System.Drawing.Point(5, 175);
            this.Dipendente_isGuida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendente_isGuida.Name = "Dipendente_isGuida";
            this.Dipendente_isGuida.Size = new System.Drawing.Size(68, 21);
            this.Dipendente_isGuida.TabIndex = 19;
            this.Dipendente_isGuida.Text = "Guida";
            this.Dipendente_isGuida.UseVisualStyleBackColor = true;
            this.Dipendente_isGuida.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Dipendenti_CFsuperiore
            // 
            this.Dipendenti_CFsuperiore.Location = new System.Drawing.Point(3, 281);
            this.Dipendenti_CFsuperiore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_CFsuperiore.Name = "Dipendenti_CFsuperiore";
            this.Dipendenti_CFsuperiore.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_CFsuperiore.TabIndex = 17;
            this.Dipendenti_CFsuperiore.Text = "Cod. Fiscale del Superiore";
            this.Dipendenti_CFsuperiore.Enter += new System.EventHandler(this.Dipendenti_CFsuperiore_Enter);
            this.Dipendenti_CFsuperiore.Leave += new System.EventHandler(this.Dipendenti_CFsuperiore_Leave);
            // 
            // Dipendenti_IDsede
            // 
            this.Dipendenti_IDsede.Location = new System.Drawing.Point(3, 254);
            this.Dipendenti_IDsede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_IDsede.Name = "Dipendenti_IDsede";
            this.Dipendenti_IDsede.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_IDsede.TabIndex = 16;
            this.Dipendenti_IDsede.Text = "ID Sede";
            this.Dipendenti_IDsede.Enter += new System.EventHandler(this.Dipendenti_IDsede_Enter);
            this.Dipendenti_IDsede.Leave += new System.EventHandler(this.Dipendenti_IDsede_Leave);
            // 
            // Dipendenti_Stipendio
            // 
            this.Dipendenti_Stipendio.Location = new System.Drawing.Point(5, 146);
            this.Dipendenti_Stipendio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_Stipendio.Name = "Dipendenti_Stipendio";
            this.Dipendenti_Stipendio.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_Stipendio.TabIndex = 11;
            this.Dipendenti_Stipendio.Text = "Stipendio";
            this.Dipendenti_Stipendio.Enter += new System.EventHandler(this.Dipendenti_Stipendio_Enter);
            this.Dipendenti_Stipendio.Leave += new System.EventHandler(this.Dipendenti_Stipendio_Leave);
            // 
            // Dipendenti_CodiceDipendente
            // 
            this.Dipendenti_CodiceDipendente.Location = new System.Drawing.Point(5, 119);
            this.Dipendenti_CodiceDipendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_CodiceDipendente.Name = "Dipendenti_CodiceDipendente";
            this.Dipendenti_CodiceDipendente.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_CodiceDipendente.TabIndex = 10;
            this.Dipendenti_CodiceDipendente.Text = "Codice Dipendente";
            this.Dipendenti_CodiceDipendente.Enter += new System.EventHandler(this.Dipendenti_CodiceDipendente_Enter);
            this.Dipendenti_CodiceDipendente.Leave += new System.EventHandler(this.Dipendenti_CodiceDipendente_Leave);
            // 
            // Dipendenti_Telefono
            // 
            this.Dipendenti_Telefono.Location = new System.Drawing.Point(5, 91);
            this.Dipendenti_Telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_Telefono.Name = "Dipendenti_Telefono";
            this.Dipendenti_Telefono.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_Telefono.TabIndex = 8;
            this.Dipendenti_Telefono.Text = "Numero di Telefono";
            this.Dipendenti_Telefono.Enter += new System.EventHandler(this.Dipendenti_Telefono_Enter);
            this.Dipendenti_Telefono.Leave += new System.EventHandler(this.Dipendenti_Telefono_Leave);
            // 
            // Dipendenti_CF
            // 
            this.Dipendenti_CF.Location = new System.Drawing.Point(5, 62);
            this.Dipendenti_CF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_CF.Name = "Dipendenti_CF";
            this.Dipendenti_CF.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_CF.TabIndex = 7;
            this.Dipendenti_CF.Text = "Codice Fiscale";
            this.Dipendenti_CF.Enter += new System.EventHandler(this.Dipendenti_CF_Enter);
            this.Dipendenti_CF.Leave += new System.EventHandler(this.Dipendenti_CF_Leave);
            // 
            // Dipendenti_Cognome
            // 
            this.Dipendenti_Cognome.Location = new System.Drawing.Point(5, 34);
            this.Dipendenti_Cognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_Cognome.Name = "Dipendenti_Cognome";
            this.Dipendenti_Cognome.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_Cognome.TabIndex = 6;
            this.Dipendenti_Cognome.Text = "Cognome";
            this.Dipendenti_Cognome.Enter += new System.EventHandler(this.Dipendenti_Cognome_Enter);
            this.Dipendenti_Cognome.Leave += new System.EventHandler(this.Dipendenti_Cognome_Leave);
            // 
            // Dipendenti_Nome
            // 
            this.Dipendenti_Nome.Location = new System.Drawing.Point(5, 6);
            this.Dipendenti_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dipendenti_Nome.Name = "Dipendenti_Nome";
            this.Dipendenti_Nome.Size = new System.Drawing.Size(177, 22);
            this.Dipendenti_Nome.TabIndex = 5;
            this.Dipendenti_Nome.Text = "Nome";
            this.Dipendenti_Nome.Enter += new System.EventHandler(this.Dipendenti_Nome_Enter);
            this.Dipendenti_Nome.Leave += new System.EventHandler(this.Dipendenti_Nome_Leave);
            // 
            // AggiungiDipendente
            // 
            this.AggiungiDipendente.Location = new System.Drawing.Point(3, 309);
            this.AggiungiDipendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiDipendente.Name = "AggiungiDipendente";
            this.AggiungiDipendente.Size = new System.Drawing.Size(179, 47);
            this.AggiungiDipendente.TabIndex = 9;
            this.AggiungiDipendente.Text = "Aggiungi Dipendente";
            this.AggiungiDipendente.UseVisualStyleBackColor = true;
            this.AggiungiDipendente.Click += new System.EventHandler(this.AggiungiDipendente_Click);
            // 
            // TabellaDipendenti
            // 
            this.TabellaDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaDipendenti.Location = new System.Drawing.Point(188, 6);
            this.TabellaDipendenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaDipendenti.Name = "TabellaDipendenti";
            this.TabellaDipendenti.ReadOnly = true;
            this.TabellaDipendenti.RowHeadersWidth = 51;
            this.TabellaDipendenti.RowTemplate.Height = 24;
            this.TabellaDipendenti.Size = new System.Drawing.Size(756, 486);
            this.TabellaDipendenti.TabIndex = 0;
            // 
            // Business_Partners
            // 
            this.Business_Partners.Controls.Add(this.TabellaBusinessPartners);
            this.Business_Partners.Location = new System.Drawing.Point(4, 25);
            this.Business_Partners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Business_Partners.Name = "Business_Partners";
            this.Business_Partners.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Business_Partners.Size = new System.Drawing.Size(951, 495);
            this.Business_Partners.TabIndex = 6;
            this.Business_Partners.Text = "Business Partners";
            this.Business_Partners.UseVisualStyleBackColor = true;
            // 
            // TabellaBusinessPartners
            // 
            this.TabellaBusinessPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBusinessPartners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabellaBusinessPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBusinessPartners.Location = new System.Drawing.Point(3, 2);
            this.TabellaBusinessPartners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaBusinessPartners.Name = "TabellaBusinessPartners";
            this.TabellaBusinessPartners.ReadOnly = true;
            this.TabellaBusinessPartners.RowHeadersWidth = 51;
            this.TabellaBusinessPartners.RowTemplate.Height = 24;
            this.TabellaBusinessPartners.Size = new System.Drawing.Size(941, 486);
            this.TabellaBusinessPartners.TabIndex = 0;
            this.TabellaBusinessPartners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Percorsi
            // 
            this.Percorsi.Controls.Add(this.AggiungiTappa);
            this.Percorsi.Controls.Add(this.NuovaTappa_IDpercorso);
            this.Percorsi.Controls.Add(this.NuovaTappa_IDtappa);
            this.Percorsi.Controls.Add(this.NuovaTappa_Lunghezza);
            this.Percorsi.Controls.Add(this.NuovaTappa_Fine);
            this.Percorsi.Controls.Add(this.NuovaTappa_Inizio);
            this.Percorsi.Controls.Add(this.Percorsi_IDsede);
            this.Percorsi.Controls.Add(this.Percorsi_Lunghezza);
            this.Percorsi.Controls.Add(this.Percorsi_NumTappe);
            this.Percorsi.Controls.Add(this.Percorsi_Nome);
            this.Percorsi.Controls.Add(this.Percorsi_Difficolta);
            this.Percorsi.Controls.Add(this.Percorsi_IDpercorso);
            this.Percorsi.Controls.Add(this.AggiungiPercorso);
            this.Percorsi.Controls.Add(this.TabellaPercorsi);
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi.Size = new System.Drawing.Size(951, 495);
            this.Percorsi.TabIndex = 5;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            this.Percorsi.Click += new System.EventHandler(this.Percorsi_Click);
            // 
            // AggiungiTappa
            // 
            this.AggiungiTappa.Location = new System.Drawing.Point(5, 356);
            this.AggiungiTappa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiTappa.Name = "AggiungiTappa";
            this.AggiungiTappa.Size = new System.Drawing.Size(179, 34);
            this.AggiungiTappa.TabIndex = 17;
            this.AggiungiTappa.Text = "Aggiungi Tappa";
            this.AggiungiTappa.UseVisualStyleBackColor = true;
            this.AggiungiTappa.Click += new System.EventHandler(this.AggiungiTappa_Click_1);
            // 
            // NuovaTappa_IDpercorso
            // 
            this.NuovaTappa_IDpercorso.Location = new System.Drawing.Point(5, 327);
            this.NuovaTappa_IDpercorso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuovaTappa_IDpercorso.Name = "NuovaTappa_IDpercorso";
            this.NuovaTappa_IDpercorso.Size = new System.Drawing.Size(179, 22);
            this.NuovaTappa_IDpercorso.TabIndex = 16;
            this.NuovaTappa_IDpercorso.Text = "ID Percorso";
            this.NuovaTappa_IDpercorso.Enter += new System.EventHandler(this.NuovaTappa_IDpercorso_Enter);
            this.NuovaTappa_IDpercorso.Leave += new System.EventHandler(this.NuovaTappa_IDpercorso_Leave);
            // 
            // NuovaTappa_IDtappa
            // 
            this.NuovaTappa_IDtappa.BackColor = System.Drawing.SystemColors.Window;
            this.NuovaTappa_IDtappa.Location = new System.Drawing.Point(5, 300);
            this.NuovaTappa_IDtappa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuovaTappa_IDtappa.Name = "NuovaTappa_IDtappa";
            this.NuovaTappa_IDtappa.ReadOnly = true;
            this.NuovaTappa_IDtappa.Size = new System.Drawing.Size(179, 22);
            this.NuovaTappa_IDtappa.TabIndex = 15;
            this.NuovaTappa_IDtappa.Text = "ID Tappa";
            // 
            // NuovaTappa_Lunghezza
            // 
            this.NuovaTappa_Lunghezza.Location = new System.Drawing.Point(5, 272);
            this.NuovaTappa_Lunghezza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuovaTappa_Lunghezza.Name = "NuovaTappa_Lunghezza";
            this.NuovaTappa_Lunghezza.Size = new System.Drawing.Size(179, 22);
            this.NuovaTappa_Lunghezza.TabIndex = 14;
            this.NuovaTappa_Lunghezza.Text = "Lunghezza Tappa";
            this.NuovaTappa_Lunghezza.Enter += new System.EventHandler(this.NuovaTappa_Lunghezza_Enter);
            this.NuovaTappa_Lunghezza.Leave += new System.EventHandler(this.NuovaTappa_Lunghezza_Leave);
            // 
            // NuovaTappa_Fine
            // 
            this.NuovaTappa_Fine.Location = new System.Drawing.Point(5, 244);
            this.NuovaTappa_Fine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuovaTappa_Fine.Name = "NuovaTappa_Fine";
            this.NuovaTappa_Fine.Size = new System.Drawing.Size(179, 22);
            this.NuovaTappa_Fine.TabIndex = 13;
            this.NuovaTappa_Fine.Text = "Fine";
            this.NuovaTappa_Fine.Enter += new System.EventHandler(this.NuovaTappa_Fine_Enter);
            this.NuovaTappa_Fine.Leave += new System.EventHandler(this.NuovaTappa_Fine_Leave);
            // 
            // NuovaTappa_Inizio
            // 
            this.NuovaTappa_Inizio.Location = new System.Drawing.Point(5, 217);
            this.NuovaTappa_Inizio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NuovaTappa_Inizio.Name = "NuovaTappa_Inizio";
            this.NuovaTappa_Inizio.Size = new System.Drawing.Size(179, 22);
            this.NuovaTappa_Inizio.TabIndex = 12;
            this.NuovaTappa_Inizio.Text = "Inizio";
            this.NuovaTappa_Inizio.Enter += new System.EventHandler(this.NuovaTappa_Inizio_Enter);
            this.NuovaTappa_Inizio.Leave += new System.EventHandler(this.NuovaTappa_Inizio_Leave);
            // 
            // Percorsi_IDsede
            // 
            this.Percorsi_IDsede.Location = new System.Drawing.Point(4, 120);
            this.Percorsi_IDsede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi_IDsede.Name = "Percorsi_IDsede";
            this.Percorsi_IDsede.Size = new System.Drawing.Size(180, 22);
            this.Percorsi_IDsede.TabIndex = 11;
            this.Percorsi_IDsede.Text = "ID Sede";
            this.Percorsi_IDsede.Enter += new System.EventHandler(this.Percorsi_IDsede_Enter);
            this.Percorsi_IDsede.Leave += new System.EventHandler(this.Percorsi_IDsede_Leave);
            // 
            // Percorsi_Lunghezza
            // 
            this.Percorsi_Lunghezza.Location = new System.Drawing.Point(5, 146);
            this.Percorsi_Lunghezza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Percorsi_Lunghezza.Name = "Percorsi_Lunghezza";
            this.Percorsi_Lunghezza.Size = new System.Drawing.Size(179, 22);
            this.Percorsi_Lunghezza.TabIndex = 10;
            this.Percorsi_Lunghezza.Text = "Lunghezza Percorso";
            this.Percorsi_Lunghezza.Enter += new System.EventHandler(this.Percorsi_LunghezzaPercorso_Enter);
            this.Percorsi_Lunghezza.Leave += new System.EventHandler(this.Percorsi_LunghezzaPercorso_Leave);
            // 
            // Percorsi_NumTappe
            // 
            this.Percorsi_NumTappe.Location = new System.Drawing.Point(5, 91);
            this.Percorsi_NumTappe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi_NumTappe.Name = "Percorsi_NumTappe";
            this.Percorsi_NumTappe.Size = new System.Drawing.Size(179, 22);
            this.Percorsi_NumTappe.TabIndex = 8;
            this.Percorsi_NumTappe.Text = "Numero di Tappe";
            this.Percorsi_NumTappe.Enter += new System.EventHandler(this.Percorsi_NumTappe_Enter);
            this.Percorsi_NumTappe.Leave += new System.EventHandler(this.Percorsi_NumTappe_Leave);
            // 
            // Percorsi_Nome
            // 
            this.Percorsi_Nome.Location = new System.Drawing.Point(4, 60);
            this.Percorsi_Nome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Percorsi_Nome.Name = "Percorsi_Nome";
            this.Percorsi_Nome.Size = new System.Drawing.Size(180, 22);
            this.Percorsi_Nome.TabIndex = 7;
            this.Percorsi_Nome.Text = "Nome";
            this.Percorsi_Nome.Enter += new System.EventHandler(this.Percorsi_NomePercorso_Enter);
            this.Percorsi_Nome.Leave += new System.EventHandler(this.Percorsi_NomePercorso_Leave);
            // 
            // Percorsi_Difficolta
            // 
            this.Percorsi_Difficolta.Location = new System.Drawing.Point(5, 34);
            this.Percorsi_Difficolta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi_Difficolta.Name = "Percorsi_Difficolta";
            this.Percorsi_Difficolta.Size = new System.Drawing.Size(179, 22);
            this.Percorsi_Difficolta.TabIndex = 6;
            this.Percorsi_Difficolta.Text = "Difficoltà";
            this.Percorsi_Difficolta.Enter += new System.EventHandler(this.Percorsi_Difficolta_Enter);
            this.Percorsi_Difficolta.Leave += new System.EventHandler(this.Percorsi_Difficolta_Leave);
            // 
            // Percorsi_IDpercorso
            // 
            this.Percorsi_IDpercorso.Location = new System.Drawing.Point(5, 6);
            this.Percorsi_IDpercorso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percorsi_IDpercorso.Name = "Percorsi_IDpercorso";
            this.Percorsi_IDpercorso.Size = new System.Drawing.Size(179, 22);
            this.Percorsi_IDpercorso.TabIndex = 5;
            this.Percorsi_IDpercorso.Text = "ID Percorso";
            this.Percorsi_IDpercorso.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.Percorsi_IDpercorso.Enter += new System.EventHandler(this.Percorsi_IDpercorso_Enter);
            this.Percorsi_IDpercorso.Leave += new System.EventHandler(this.Percorsi_IDpercorso_Leave);
            // 
            // AggiungiPercorso
            // 
            this.AggiungiPercorso.Location = new System.Drawing.Point(5, 172);
            this.AggiungiPercorso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiPercorso.Name = "AggiungiPercorso";
            this.AggiungiPercorso.Size = new System.Drawing.Size(179, 34);
            this.AggiungiPercorso.TabIndex = 9;
            this.AggiungiPercorso.Text = "Aggiungi Percorso";
            this.AggiungiPercorso.UseVisualStyleBackColor = true;
            this.AggiungiPercorso.Click += new System.EventHandler(this.AggiungiPercorso_Click);
            // 
            // TabellaPercorsi
            // 
            this.TabellaPercorsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaPercorsi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabellaPercorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPercorsi.Location = new System.Drawing.Point(189, 6);
            this.TabellaPercorsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaPercorsi.Name = "TabellaPercorsi";
            this.TabellaPercorsi.ReadOnly = true;
            this.TabellaPercorsi.RowHeadersWidth = 51;
            this.TabellaPercorsi.RowTemplate.Height = 24;
            this.TabellaPercorsi.Size = new System.Drawing.Size(755, 486);
            this.TabellaPercorsi.TabIndex = 0;
            // 
            // Magazzini
            // 
            this.Magazzini.Controls.Add(this.Magazzini_IDsede);
            this.Magazzini.Controls.Add(this.Magazzini_IDindirizzo);
            this.Magazzini.Controls.Add(this.Magazzini_IDmagazzino);
            this.Magazzini.Controls.Add(this.Magazzini_CapMaxBici);
            this.Magazzini.Controls.Add(this.Magazzini_CapMaxAccessori);
            this.Magazzini.Controls.Add(this.AggiungiMagazzino);
            this.Magazzini.Controls.Add(this.TabellaMagazzini);
            this.Magazzini.Location = new System.Drawing.Point(4, 25);
            this.Magazzini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini.Name = "Magazzini";
            this.Magazzini.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini.Size = new System.Drawing.Size(951, 495);
            this.Magazzini.TabIndex = 2;
            this.Magazzini.Text = "Magazzini";
            this.Magazzini.UseVisualStyleBackColor = true;
            // 
            // Magazzini_IDsede
            // 
            this.Magazzini_IDsede.Location = new System.Drawing.Point(5, 119);
            this.Magazzini_IDsede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini_IDsede.Name = "Magazzini_IDsede";
            this.Magazzini_IDsede.Size = new System.Drawing.Size(177, 22);
            this.Magazzini_IDsede.TabIndex = 10;
            this.Magazzini_IDsede.Text = "ID Sede";
            this.Magazzini_IDsede.Enter += new System.EventHandler(this.Magazzini_IDsede_Enter);
            this.Magazzini_IDsede.Leave += new System.EventHandler(this.Magazzini_IDsede_Leave);
            // 
            // Magazzini_IDindirizzo
            // 
            this.Magazzini_IDindirizzo.Location = new System.Drawing.Point(5, 91);
            this.Magazzini_IDindirizzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini_IDindirizzo.Name = "Magazzini_IDindirizzo";
            this.Magazzini_IDindirizzo.Size = new System.Drawing.Size(177, 22);
            this.Magazzini_IDindirizzo.TabIndex = 8;
            this.Magazzini_IDindirizzo.Text = "ID Indirizzo";
            this.Magazzini_IDindirizzo.Enter += new System.EventHandler(this.Magazzini_IDindirizzo_Enter);
            this.Magazzini_IDindirizzo.Leave += new System.EventHandler(this.Magazzini_IDindirizzo_Leave);
            // 
            // Magazzini_IDmagazzino
            // 
            this.Magazzini_IDmagazzino.Location = new System.Drawing.Point(5, 62);
            this.Magazzini_IDmagazzino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini_IDmagazzino.Name = "Magazzini_IDmagazzino";
            this.Magazzini_IDmagazzino.Size = new System.Drawing.Size(177, 22);
            this.Magazzini_IDmagazzino.TabIndex = 7;
            this.Magazzini_IDmagazzino.Text = "ID Magazzino";
            this.Magazzini_IDmagazzino.Enter += new System.EventHandler(this.Magazzini_IDmagazzino_Enter);
            this.Magazzini_IDmagazzino.Leave += new System.EventHandler(this.Magazzini_IDmagazzino_Leave);
            // 
            // Magazzini_CapMaxBici
            // 
            this.Magazzini_CapMaxBici.Location = new System.Drawing.Point(5, 34);
            this.Magazzini_CapMaxBici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini_CapMaxBici.Name = "Magazzini_CapMaxBici";
            this.Magazzini_CapMaxBici.Size = new System.Drawing.Size(177, 22);
            this.Magazzini_CapMaxBici.TabIndex = 6;
            this.Magazzini_CapMaxBici.Text = "Capienza Max Bici";
            this.Magazzini_CapMaxBici.Enter += new System.EventHandler(this.Magazzini_CapMaxBici_Enter);
            this.Magazzini_CapMaxBici.Leave += new System.EventHandler(this.Magazzini_CapMaxBici_Leave);
            // 
            // Magazzini_CapMaxAccessori
            // 
            this.Magazzini_CapMaxAccessori.Location = new System.Drawing.Point(5, 6);
            this.Magazzini_CapMaxAccessori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Magazzini_CapMaxAccessori.Name = "Magazzini_CapMaxAccessori";
            this.Magazzini_CapMaxAccessori.Size = new System.Drawing.Size(177, 22);
            this.Magazzini_CapMaxAccessori.TabIndex = 5;
            this.Magazzini_CapMaxAccessori.Text = "Capienza Max Accessori";
            this.Magazzini_CapMaxAccessori.Enter += new System.EventHandler(this.Magazzini_CapMaxAccessori_Enter);
            this.Magazzini_CapMaxAccessori.Leave += new System.EventHandler(this.Magazzini_CapMaxAccessori_Leave);
            // 
            // AggiungiMagazzino
            // 
            this.AggiungiMagazzino.Location = new System.Drawing.Point(5, 146);
            this.AggiungiMagazzino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiMagazzino.Name = "AggiungiMagazzino";
            this.AggiungiMagazzino.Size = new System.Drawing.Size(179, 44);
            this.AggiungiMagazzino.TabIndex = 9;
            this.AggiungiMagazzino.Text = "Aggiungi Magazzino";
            this.AggiungiMagazzino.UseVisualStyleBackColor = true;
            this.AggiungiMagazzino.Click += new System.EventHandler(this.AggiungiMagazzino_Click);
            // 
            // TabellaMagazzini
            // 
            this.TabellaMagazzini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaMagazzini.Location = new System.Drawing.Point(189, 6);
            this.TabellaMagazzini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaMagazzini.Name = "TabellaMagazzini";
            this.TabellaMagazzini.ReadOnly = true;
            this.TabellaMagazzini.RowHeadersWidth = 51;
            this.TabellaMagazzini.RowTemplate.Height = 24;
            this.TabellaMagazzini.Size = new System.Drawing.Size(755, 482);
            this.TabellaMagazzini.TabIndex = 0;
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.TabellaClienti);
            this.Clienti.Controls.Add(this.AggiungiCliente);
            this.Clienti.Controls.Add(this.Clienti_Telefono);
            this.Clienti.Controls.Add(this.Clienti_CF);
            this.Clienti.Controls.Add(this.Clienti_Cognome);
            this.Clienti.Controls.Add(this.Clienti_Nome);
            this.Clienti.Location = new System.Drawing.Point(4, 25);
            this.Clienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti.Size = new System.Drawing.Size(951, 495);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Clienti";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // TabellaClienti
            // 
            this.TabellaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaClienti.Location = new System.Drawing.Point(189, 6);
            this.TabellaClienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaClienti.Name = "TabellaClienti";
            this.TabellaClienti.ReadOnly = true;
            this.TabellaClienti.RowHeadersWidth = 51;
            this.TabellaClienti.RowTemplate.Height = 24;
            this.TabellaClienti.Size = new System.Drawing.Size(755, 482);
            this.TabellaClienti.TabIndex = 5;
            // 
            // AggiungiCliente
            // 
            this.AggiungiCliente.Location = new System.Drawing.Point(5, 119);
            this.AggiungiCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiCliente.Name = "AggiungiCliente";
            this.AggiungiCliente.Size = new System.Drawing.Size(179, 39);
            this.AggiungiCliente.TabIndex = 4;
            this.AggiungiCliente.Text = "Aggiungi Cliente";
            this.AggiungiCliente.UseVisualStyleBackColor = true;
            this.AggiungiCliente.Click += new System.EventHandler(this.AggiungiCliente_Click);
            // 
            // Clienti_Telefono
            // 
            this.Clienti_Telefono.Location = new System.Drawing.Point(5, 91);
            this.Clienti_Telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti_Telefono.Name = "Clienti_Telefono";
            this.Clienti_Telefono.Size = new System.Drawing.Size(177, 22);
            this.Clienti_Telefono.TabIndex = 3;
            this.Clienti_Telefono.Text = "Numero di Telefono";
            this.Clienti_Telefono.Enter += new System.EventHandler(this.Telefono_Enter);
            this.Clienti_Telefono.Leave += new System.EventHandler(this.Telefono_Leave);
            // 
            // Clienti_CF
            // 
            this.Clienti_CF.Location = new System.Drawing.Point(5, 62);
            this.Clienti_CF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti_CF.Name = "Clienti_CF";
            this.Clienti_CF.Size = new System.Drawing.Size(177, 22);
            this.Clienti_CF.TabIndex = 2;
            this.Clienti_CF.Text = "Codice Fiscale";
            this.Clienti_CF.Enter += new System.EventHandler(this.CodiceFiscale_Enter);
            this.Clienti_CF.Leave += new System.EventHandler(this.CodiceFiscale_Leave);
            // 
            // Clienti_Cognome
            // 
            this.Clienti_Cognome.Location = new System.Drawing.Point(5, 34);
            this.Clienti_Cognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti_Cognome.Name = "Clienti_Cognome";
            this.Clienti_Cognome.Size = new System.Drawing.Size(177, 22);
            this.Clienti_Cognome.TabIndex = 1;
            this.Clienti_Cognome.Text = "Cognome";
            this.Clienti_Cognome.Enter += new System.EventHandler(this.Cognome_Enter);
            this.Clienti_Cognome.Leave += new System.EventHandler(this.Cognome_Leave);
            // 
            // Clienti_Nome
            // 
            this.Clienti_Nome.Location = new System.Drawing.Point(5, 6);
            this.Clienti_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clienti_Nome.Name = "Clienti_Nome";
            this.Clienti_Nome.Size = new System.Drawing.Size(177, 22);
            this.Clienti_Nome.TabIndex = 0;
            this.Clienti_Nome.Text = "Nome";
            this.Clienti_Nome.Enter += new System.EventHandler(this.Nome_Enter);
            this.Clienti_Nome.Leave += new System.EventHandler(this.Nome_Leave);
            // 
            // TabPage
            // 
            this.TabPage.AccessibleName = "";
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Dipendenti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Controls.Add(this.Servizi);
            this.TabPage.Controls.Add(this.Magazzini);
            this.TabPage.Controls.Add(this.Percorsi);
            this.TabPage.Controls.Add(this.Business_Partners);
            this.TabPage.Location = new System.Drawing.Point(12, 55);
            this.TabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(959, 524);
            this.TabPage.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabPage.TabIndex = 4;
            this.TabPage.Tag = "";
            this.TabPage.SelectedIndexChanged += new System.EventHandler(this.TabPage_SelectedIndexChanged);
            // 
            // Servizi
            // 
            this.Servizi.Controls.Add(this.Servizio_PeriodoMedioAccessori);
            this.Servizi.Controls.Add(this.Servizio_PeriodoMedioBici);
            this.Servizi.Controls.Add(this.Servizio_AccessorioTop);
            this.Servizi.Controls.Add(this.Servizio_TagliaBiciTop);
            this.Servizi.Controls.Add(this.Servizi_DataFine);
            this.Servizi.Controls.Add(this.label4);
            this.Servizi.Controls.Add(this.label3);
            this.Servizi.Controls.Add(this.label2);
            this.Servizi.Controls.Add(this.label1);
            this.Servizi.Controls.Add(this.Servizi_Calcola);
            this.Servizi.Controls.Add(this.Servizi_DataInizio);
            this.Servizi.Controls.Add(this.TabellaServizi);
            this.Servizi.Location = new System.Drawing.Point(4, 25);
            this.Servizi.Margin = new System.Windows.Forms.Padding(4);
            this.Servizi.Name = "Servizi";
            this.Servizi.Size = new System.Drawing.Size(951, 495);
            this.Servizi.TabIndex = 9;
            this.Servizi.Text = "Servizi";
            this.Servizi.UseVisualStyleBackColor = true;
            // 
            // Servizio_PeriodoMedioAccessori
            // 
            this.Servizio_PeriodoMedioAccessori.AutoSize = true;
            this.Servizio_PeriodoMedioAccessori.Location = new System.Drawing.Point(23, 454);
            this.Servizio_PeriodoMedioAccessori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servizio_PeriodoMedioAccessori.Name = "Servizio_PeriodoMedioAccessori";
            this.Servizio_PeriodoMedioAccessori.Size = new System.Drawing.Size(14, 17);
            this.Servizio_PeriodoMedioAccessori.TabIndex = 11;
            this.Servizio_PeriodoMedioAccessori.Text = "x";
            // 
            // Servizio_PeriodoMedioBici
            // 
            this.Servizio_PeriodoMedioBici.AutoSize = true;
            this.Servizio_PeriodoMedioBici.Location = new System.Drawing.Point(23, 356);
            this.Servizio_PeriodoMedioBici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servizio_PeriodoMedioBici.Name = "Servizio_PeriodoMedioBici";
            this.Servizio_PeriodoMedioBici.Size = new System.Drawing.Size(14, 17);
            this.Servizio_PeriodoMedioBici.TabIndex = 10;
            this.Servizio_PeriodoMedioBici.Text = "x";
            // 
            // Servizio_AccessorioTop
            // 
            this.Servizio_AccessorioTop.AutoSize = true;
            this.Servizio_AccessorioTop.Location = new System.Drawing.Point(23, 262);
            this.Servizio_AccessorioTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servizio_AccessorioTop.Name = "Servizio_AccessorioTop";
            this.Servizio_AccessorioTop.Size = new System.Drawing.Size(14, 17);
            this.Servizio_AccessorioTop.TabIndex = 9;
            this.Servizio_AccessorioTop.Text = "x";
            // 
            // Servizio_TagliaBiciTop
            // 
            this.Servizio_TagliaBiciTop.AutoSize = true;
            this.Servizio_TagliaBiciTop.Location = new System.Drawing.Point(23, 172);
            this.Servizio_TagliaBiciTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Servizio_TagliaBiciTop.Name = "Servizio_TagliaBiciTop";
            this.Servizio_TagliaBiciTop.Size = new System.Drawing.Size(14, 17);
            this.Servizio_TagliaBiciTop.TabIndex = 8;
            this.Servizio_TagliaBiciTop.Text = "x";
            // 
            // Servizi_DataFine
            // 
            this.Servizi_DataFine.Location = new System.Drawing.Point(5, 36);
            this.Servizi_DataFine.Margin = new System.Windows.Forms.Padding(4);
            this.Servizi_DataFine.Name = "Servizi_DataFine";
            this.Servizi_DataFine.Size = new System.Drawing.Size(264, 22);
            this.Servizi_DataFine.TabIndex = 7;
            this.Servizi_DataFine.Text = "Data Fine (YYYY-MM-DD)";
            this.Servizi_DataFine.Enter += new System.EventHandler(this.Servizi_DataFine_Enter);
            this.Servizi_DataFine.Leave += new System.EventHandler(this.Servizi_DataFine_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periodo medio prenotazione accessori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Periodo medio prenotazione bici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accessorio più richiesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Taglia bici piu richiesta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Servizi_Calcola
            // 
            this.Servizi_Calcola.Location = new System.Drawing.Point(4, 70);
            this.Servizi_Calcola.Margin = new System.Windows.Forms.Padding(4);
            this.Servizi_Calcola.Name = "Servizi_Calcola";
            this.Servizi_Calcola.Size = new System.Drawing.Size(265, 28);
            this.Servizi_Calcola.TabIndex = 2;
            this.Servizi_Calcola.Text = "Calcola";
            this.Servizi_Calcola.UseVisualStyleBackColor = true;
            this.Servizi_Calcola.Click += new System.EventHandler(this.Servizi_Calcola_Click);
            // 
            // Servizi_DataInizio
            // 
            this.Servizi_DataInizio.Location = new System.Drawing.Point(5, 5);
            this.Servizi_DataInizio.Margin = new System.Windows.Forms.Padding(4);
            this.Servizi_DataInizio.Name = "Servizi_DataInizio";
            this.Servizi_DataInizio.Size = new System.Drawing.Size(264, 22);
            this.Servizi_DataInizio.TabIndex = 1;
            this.Servizi_DataInizio.Text = "Data Inizio (YYYY-MM-DD)";
            this.Servizi_DataInizio.Enter += new System.EventHandler(this.Servizi_DataInizio_Enter);
            this.Servizi_DataInizio.Leave += new System.EventHandler(this.Servizi_DataInizio_Leave);
            // 
            // TabellaServizi
            // 
            this.TabellaServizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaServizi.Location = new System.Drawing.Point(277, 4);
            this.TabellaServizi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabellaServizi.Name = "TabellaServizi";
            this.TabellaServizi.RowHeadersWidth = 51;
            this.TabellaServizi.RowTemplate.Height = 24;
            this.TabellaServizi.Size = new System.Drawing.Size(987, 610);
            this.TabellaServizi.TabIndex = 0;
            // 
            // ThisSedeID
            // 
            this.ThisSedeID.AutoSize = true;
            this.ThisSedeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ThisSedeID.Location = new System.Drawing.Point(116, 17);
            this.ThisSedeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThisSedeID.Name = "ThisSedeID";
            this.ThisSedeID.Size = new System.Drawing.Size(78, 25);
            this.ThisSedeID.TabIndex = 12;
            this.ThisSedeID.Text = "IDSede";
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
            // Dipendenti_StipendioMedio
            // 
            this.Dipendenti_StipendioMedio.AutoSize = true;
            this.Dipendenti_StipendioMedio.Location = new System.Drawing.Point(132, 458);
            this.Dipendenti_StipendioMedio.Name = "Dipendenti_StipendioMedio";
            this.Dipendenti_StipendioMedio.Size = new System.Drawing.Size(14, 17);
            this.Dipendenti_StipendioMedio.TabIndex = 22;
            this.Dipendenti_StipendioMedio.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stipendio medio";
            // 
            // DatabaseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 591);
            this.Controls.Add(this.ThisSedeID);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatabaseViewAdmin";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.DatabaseViewAdmin_Load);
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
            this.Dipendenti.ResumeLayout(false);
            this.Dipendenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).EndInit();
            this.Business_Partners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBusinessPartners)).EndInit();
            this.Percorsi.ResumeLayout(false);
            this.Percorsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).EndInit();
            this.Magazzini.ResumeLayout(false);
            this.Magazzini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaMagazzini)).EndInit();
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.Servizi.ResumeLayout(false);
            this.Servizi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaServizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipendenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazzinoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet2 gestionale_per_agenzie_relDataSet2;
        private System.Windows.Forms.BindingSource dipendenteBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet2TableAdapters.dipendenteTableAdapter dipendenteTableAdapter;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet3 gestionale_per_agenzie_relDataSet3;
        private System.Windows.Forms.BindingSource magazzinoBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet3TableAdapters.magazzinoTableAdapter magazzinoTableAdapter;
        private Button DipendentiAgenzia;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.Button AggiungiTour;
        private System.Windows.Forms.DataGridView TabellaTour;
        private System.Windows.Forms.TabPage Dipendenti;
        private System.Windows.Forms.CheckBox Dipendente_isAltro;
        private System.Windows.Forms.CheckBox Dipendente_isTourManager;
        private System.Windows.Forms.CheckBox Dipendente_isGuida;
        private System.Windows.Forms.TextBox Dipendenti_CFsuperiore;
        private System.Windows.Forms.TextBox Dipendenti_IDsede;
        private System.Windows.Forms.TextBox Dipendenti_Stipendio;
        private System.Windows.Forms.TextBox Dipendenti_CodiceDipendente;
        private System.Windows.Forms.TextBox Dipendenti_Telefono;
        private System.Windows.Forms.TextBox Dipendenti_CF;
        private System.Windows.Forms.TextBox Dipendenti_Cognome;
        private System.Windows.Forms.TextBox Dipendenti_Nome;
        private System.Windows.Forms.Button AggiungiDipendente;
        private System.Windows.Forms.DataGridView TabellaDipendenti;
        private System.Windows.Forms.TabPage Business_Partners;
        private System.Windows.Forms.DataGridView TabellaBusinessPartners;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TextBox Percorsi_IDsede;
        private System.Windows.Forms.TextBox Percorsi_Lunghezza;
        private System.Windows.Forms.TextBox Percorsi_NumTappe;
        private System.Windows.Forms.TextBox Percorsi_Nome;
        private System.Windows.Forms.TextBox Percorsi_Difficolta;
        private System.Windows.Forms.TextBox Percorsi_IDpercorso;
        private System.Windows.Forms.Button AggiungiPercorso;
        private System.Windows.Forms.DataGridView TabellaPercorsi;
        private System.Windows.Forms.TabPage Magazzini;
        private System.Windows.Forms.TextBox Magazzini_IDsede;
        private System.Windows.Forms.TextBox Magazzini_IDindirizzo;
        private System.Windows.Forms.TextBox Magazzini_IDmagazzino;
        private System.Windows.Forms.TextBox Magazzini_CapMaxBici;
        private System.Windows.Forms.TextBox Magazzini_CapMaxAccessori;
        private System.Windows.Forms.Button AggiungiMagazzino;
        private System.Windows.Forms.DataGridView TabellaMagazzini;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.DataGridView TabellaClienti;
        private System.Windows.Forms.Button AggiungiCliente;
        private System.Windows.Forms.TextBox Clienti_Telefono;
        private System.Windows.Forms.TextBox Clienti_CF;
        private System.Windows.Forms.TextBox Clienti_Cognome;
        private System.Windows.Forms.TextBox Clienti_Nome;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.Button AggiungiTappa;
        private System.Windows.Forms.TextBox NuovaTappa_IDpercorso;
        private System.Windows.Forms.TextBox NuovaTappa_IDtappa;
        private System.Windows.Forms.TextBox NuovaTappa_Lunghezza;
        private System.Windows.Forms.TextBox NuovaTappa_Fine;
        private System.Windows.Forms.TextBox NuovaTappa_Inizio;
        private System.Windows.Forms.TextBox BP_PIVA;
        private System.Windows.Forms.TextBox BP_NomeSocio;
        private System.Windows.Forms.TextBox BP_CostoServizio;
        private System.Windows.Forms.TextBox BP_Telefono;
        private System.Windows.Forms.TextBox BP_Tipologia;
        private System.Windows.Forms.TextBox Tour_Destinazione;
        private System.Windows.Forms.TextBox Tour_Nome;
        private System.Windows.Forms.TextBox Tour_DataInizio;
        private System.Windows.Forms.TextBox Tour_DataFine;
        private System.Windows.Forms.TextBox Tour_Prezzo;
        private System.Windows.Forms.TextBox Tour_IDtour;
        private System.Windows.Forms.TextBox Tour_IDsede;
        private System.Windows.Forms.TextBox Tour_CFtourManager;
        private System.Windows.Forms.Label ThisSedeID;
        private System.Windows.Forms.TextBox TourDataFine;
        private System.Windows.Forms.TextBox TourDataInizio;
        private System.Windows.Forms.TextBox TourNome;
        private System.Windows.Forms.TextBox TourDestinazione;
        private System.Windows.Forms.TextBox TourID;
        private System.Windows.Forms.TextBox TourCFManager;
        private System.Windows.Forms.TextBox TourPrezzo;
        private System.Windows.Forms.TabPage Servizi;
        private System.Windows.Forms.TextBox Servizi_DataFine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Servizi_Calcola;
        private System.Windows.Forms.TextBox Servizi_DataInizio;
        private System.Windows.Forms.DataGridView TabellaServizi;
        private System.Windows.Forms.Label Servizio_PeriodoMedioAccessori;
        private System.Windows.Forms.Label Servizio_PeriodoMedioBici;
        private System.Windows.Forms.Label Servizio_AccessorioTop;
        private System.Windows.Forms.Label Servizio_TagliaBiciTop;
    }
}

