
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
            this.Dipendenti_CFsuperiore = new System.Windows.Forms.TextBox();
            this.Dipendenti_IDsede = new System.Windows.Forms.TextBox();
            this.Dipendenti_Stipendio = new System.Windows.Forms.TextBox();
            this.Dipendenti_CodiceDipendente = new System.Windows.Forms.TextBox();
            this.AggiungiDipendente = new System.Windows.Forms.Button();
            this.Dipendenti_Telefono = new System.Windows.Forms.TextBox();
            this.Dipendenti_CF = new System.Windows.Forms.TextBox();
            this.Dipendenti_Cognome = new System.Windows.Forms.TextBox();
            this.Dipendenti_Nome = new System.Windows.Forms.TextBox();
            this.TabellaDipendenti = new System.Windows.Forms.DataGridView();
            this.Business_Partners = new System.Windows.Forms.TabPage();
            this.BP_Tipologia = new System.Windows.Forms.TextBox();
            this.AggiungiBusinessPartner = new System.Windows.Forms.Button();
            this.BP_Telefono = new System.Windows.Forms.TextBox();
            this.BP_CostoServizio = new System.Windows.Forms.TextBox();
            this.BP_NomeSocio = new System.Windows.Forms.TextBox();
            this.BP_PIVA = new System.Windows.Forms.TextBox();
            this.TabellaBusinessPartners = new System.Windows.Forms.DataGridView();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.Percorsi_IDsede = new System.Windows.Forms.TextBox();
            this.Percorsi_LunghezzaPercorso = new System.Windows.Forms.TextBox();
            this.AggiungiPercorso = new System.Windows.Forms.Button();
            this.Percorsi_NumTappe = new System.Windows.Forms.TextBox();
            this.Percorsi_NomePercorso = new System.Windows.Forms.TextBox();
            this.Percorsi_Difficolta = new System.Windows.Forms.TextBox();
            this.Percorsi_IDpercorso = new System.Windows.Forms.TextBox();
            this.TabellaPercorsi = new System.Windows.Forms.DataGridView();
            this.Magazzini = new System.Windows.Forms.TabPage();
            this.Magazzini_IDsede = new System.Windows.Forms.TextBox();
            this.AggiungiMagazzino = new System.Windows.Forms.Button();
            this.Magazzini_IDindirizzo = new System.Windows.Forms.TextBox();
            this.Magazzini_IDmagazzino = new System.Windows.Forms.TextBox();
            this.Magazzini_CapMaxBici = new System.Windows.Forms.TextBox();
            this.Magazzini_CapMaxAccessori = new System.Windows.Forms.TextBox();
            this.TabellaMagazzini = new System.Windows.Forms.DataGridView();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.AggiungiPrenotazione = new System.Windows.Forms.Button();
            this.Prenotazioni_IDtour = new System.Windows.Forms.TextBox();
            this.Prenotazioni_CFcliente = new System.Windows.Forms.TextBox();
            this.TabellaPrenotazioni = new System.Windows.Forms.DataGridView();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.TabellaClienti = new System.Windows.Forms.DataGridView();
            this.AggiungiCliente = new System.Windows.Forms.Button();
            this.Clienti_Telefono = new System.Windows.Forms.TextBox();
            this.Clienti_CF = new System.Windows.Forms.TextBox();
            this.Clienti_Cognome = new System.Windows.Forms.TextBox();
            this.Clienti_Nome = new System.Windows.Forms.TextBox();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Tour = new System.Windows.Forms.TabPage();
            this.Tour_CFtourManager = new System.Windows.Forms.TextBox();
            this.Tour_IDsede = new System.Windows.Forms.TextBox();
            this.Tour_IDtour = new System.Windows.Forms.TextBox();
            this.Tour_Prezzo = new System.Windows.Forms.TextBox();
            this.AggiungiTour = new System.Windows.Forms.Button();
            this.Tour_DataFine = new System.Windows.Forms.TextBox();
            this.Tour_DataInizio = new System.Windows.Forms.TextBox();
            this.Tour_Nome = new System.Windows.Forms.TextBox();
            this.Tour_Destinazione = new System.Windows.Forms.TextBox();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.gestionale_per_agenzie_relDataSet2 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2();
            this.dipendenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipendenteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet2TableAdapters.dipendenteTableAdapter();
            this.gestionale_per_agenzie_relDataSet3 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3();
            this.magazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazzinoTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet3TableAdapters.magazzinoTableAdapter();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Dipendente_isGuida = new System.Windows.Forms.CheckBox();
            this.Dipendente_isTourManager = new System.Windows.Forms.CheckBox();
            this.Dipendente_isAltro = new System.Windows.Forms.CheckBox();
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
            this.Dipendenti.Controls.Add(this.Dipendente_isAltro);
            this.Dipendenti.Controls.Add(this.Dipendente_isTourManager);
            this.Dipendenti.Controls.Add(this.Dipendente_isGuida);
            this.Dipendenti.Controls.Add(this.Dipendenti_CFsuperiore);
            this.Dipendenti.Controls.Add(this.Dipendenti_IDsede);
            this.Dipendenti.Controls.Add(this.Dipendenti_Stipendio);
            this.Dipendenti.Controls.Add(this.Dipendenti_CodiceDipendente);
            this.Dipendenti.Controls.Add(this.AggiungiDipendente);
            this.Dipendenti.Controls.Add(this.Dipendenti_Telefono);
            this.Dipendenti.Controls.Add(this.Dipendenti_CF);
            this.Dipendenti.Controls.Add(this.Dipendenti_Cognome);
            this.Dipendenti.Controls.Add(this.Dipendenti_Nome);
            this.Dipendenti.Controls.Add(this.TabellaDipendenti);
            this.Dipendenti.Location = new System.Drawing.Point(4, 25);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3);
            this.Dipendenti.Size = new System.Drawing.Size(951, 495);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // Dipendenti_CFsuperiore
            // 
            this.Dipendenti_CFsuperiore.Location = new System.Drawing.Point(3, 281);
            this.Dipendenti_CFsuperiore.Name = "Dipendenti_CFsuperiore";
            this.Dipendenti_CFsuperiore.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_CFsuperiore.TabIndex = 17;
            this.Dipendenti_CFsuperiore.Text = "Cod. Fiscale del Superiore";
            this.Dipendenti_CFsuperiore.Enter += new System.EventHandler(this.Dipendenti_CFsuperiore_Enter);
            this.Dipendenti_CFsuperiore.Leave += new System.EventHandler(this.Dipendenti_CFsuperiore_Leave);
            // 
            // Dipendenti_IDsede
            // 
            this.Dipendenti_IDsede.Location = new System.Drawing.Point(3, 253);
            this.Dipendenti_IDsede.Name = "Dipendenti_IDsede";
            this.Dipendenti_IDsede.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_IDsede.TabIndex = 16;
            this.Dipendenti_IDsede.Text = "ID Sede";
            this.Dipendenti_IDsede.Enter += new System.EventHandler(this.Dipendenti_IDsede_Enter);
            this.Dipendenti_IDsede.Leave += new System.EventHandler(this.Dipendenti_IDsede_Leave);
            // 
            // Dipendenti_Stipendio
            // 
            this.Dipendenti_Stipendio.Location = new System.Drawing.Point(6, 147);
            this.Dipendenti_Stipendio.Name = "Dipendenti_Stipendio";
            this.Dipendenti_Stipendio.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_Stipendio.TabIndex = 11;
            this.Dipendenti_Stipendio.Text = "Stipendio";
            this.Dipendenti_Stipendio.Enter += new System.EventHandler(this.Dipendenti_Stipendio_Enter);
            this.Dipendenti_Stipendio.Leave += new System.EventHandler(this.Dipendenti_Stipendio_Leave);
            // 
            // Dipendenti_CodiceDipendente
            // 
            this.Dipendenti_CodiceDipendente.Location = new System.Drawing.Point(6, 119);
            this.Dipendenti_CodiceDipendente.Name = "Dipendenti_CodiceDipendente";
            this.Dipendenti_CodiceDipendente.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_CodiceDipendente.TabIndex = 10;
            this.Dipendenti_CodiceDipendente.Text = "Codice Dipendente";
            this.Dipendenti_CodiceDipendente.Enter += new System.EventHandler(this.Dipendenti_CodiceDipendente_Enter);
            this.Dipendenti_CodiceDipendente.Leave += new System.EventHandler(this.Dipendenti_CodiceDipendente_Leave);
            // 
            // AggiungiDipendente
            // 
            this.AggiungiDipendente.Location = new System.Drawing.Point(3, 309);
            this.AggiungiDipendente.Name = "AggiungiDipendente";
            this.AggiungiDipendente.Size = new System.Drawing.Size(178, 47);
            this.AggiungiDipendente.TabIndex = 9;
            this.AggiungiDipendente.Text = "Aggiungi Dipendente";
            this.AggiungiDipendente.UseVisualStyleBackColor = true;
            this.AggiungiDipendente.Click += new System.EventHandler(this.AggiungiDipendente_Click);
            // 
            // Dipendenti_Telefono
            // 
            this.Dipendenti_Telefono.Location = new System.Drawing.Point(6, 91);
            this.Dipendenti_Telefono.Name = "Dipendenti_Telefono";
            this.Dipendenti_Telefono.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_Telefono.TabIndex = 8;
            this.Dipendenti_Telefono.Text = "Numero di Telefono";
            this.Dipendenti_Telefono.Enter += new System.EventHandler(this.Dipendenti_Telefono_Enter);
            this.Dipendenti_Telefono.Leave += new System.EventHandler(this.Dipendenti_Telefono_Leave);
            // 
            // Dipendenti_CF
            // 
            this.Dipendenti_CF.Location = new System.Drawing.Point(6, 62);
            this.Dipendenti_CF.Name = "Dipendenti_CF";
            this.Dipendenti_CF.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_CF.TabIndex = 7;
            this.Dipendenti_CF.Text = "Codice Fiscale";
            this.Dipendenti_CF.Enter += new System.EventHandler(this.Dipendenti_CF_Enter);
            this.Dipendenti_CF.Leave += new System.EventHandler(this.Dipendenti_CF_Leave);
            // 
            // Dipendenti_Cognome
            // 
            this.Dipendenti_Cognome.Location = new System.Drawing.Point(6, 34);
            this.Dipendenti_Cognome.Name = "Dipendenti_Cognome";
            this.Dipendenti_Cognome.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_Cognome.TabIndex = 6;
            this.Dipendenti_Cognome.Text = "Cognome";
            this.Dipendenti_Cognome.Enter += new System.EventHandler(this.Dipendenti_Cognome_Enter);
            this.Dipendenti_Cognome.Leave += new System.EventHandler(this.Dipendenti_Cognome_Leave);
            // 
            // Dipendenti_Nome
            // 
            this.Dipendenti_Nome.Location = new System.Drawing.Point(6, 6);
            this.Dipendenti_Nome.Name = "Dipendenti_Nome";
            this.Dipendenti_Nome.Size = new System.Drawing.Size(178, 22);
            this.Dipendenti_Nome.TabIndex = 5;
            this.Dipendenti_Nome.Text = "Nome";
            this.Dipendenti_Nome.Enter += new System.EventHandler(this.Dipendenti_Nome_Enter);
            this.Dipendenti_Nome.Leave += new System.EventHandler(this.Dipendenti_Nome_Leave);
            // 
            // TabellaDipendenti
            // 
            this.TabellaDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaDipendenti.Location = new System.Drawing.Point(190, 6);
            this.TabellaDipendenti.Name = "TabellaDipendenti";
            this.TabellaDipendenti.ReadOnly = true;
            this.TabellaDipendenti.RowHeadersWidth = 51;
            this.TabellaDipendenti.RowTemplate.Height = 24;
            this.TabellaDipendenti.Size = new System.Drawing.Size(755, 486);
            this.TabellaDipendenti.TabIndex = 0;
            // 
            // Business_Partners
            // 
            this.Business_Partners.Controls.Add(this.BP_Tipologia);
            this.Business_Partners.Controls.Add(this.AggiungiBusinessPartner);
            this.Business_Partners.Controls.Add(this.BP_Telefono);
            this.Business_Partners.Controls.Add(this.BP_CostoServizio);
            this.Business_Partners.Controls.Add(this.BP_NomeSocio);
            this.Business_Partners.Controls.Add(this.BP_PIVA);
            this.Business_Partners.Controls.Add(this.TabellaBusinessPartners);
            this.Business_Partners.Location = new System.Drawing.Point(4, 25);
            this.Business_Partners.Name = "Business_Partners";
            this.Business_Partners.Padding = new System.Windows.Forms.Padding(3);
            this.Business_Partners.Size = new System.Drawing.Size(951, 495);
            this.Business_Partners.TabIndex = 6;
            this.Business_Partners.Text = "Business Partners";
            this.Business_Partners.UseVisualStyleBackColor = true;
            // 
            // BP_Tipologia
            // 
            this.BP_Tipologia.Location = new System.Drawing.Point(6, 119);
            this.BP_Tipologia.Name = "BP_Tipologia";
            this.BP_Tipologia.Size = new System.Drawing.Size(178, 22);
            this.BP_Tipologia.TabIndex = 10;
            this.BP_Tipologia.Text = "Tipologia";
            this.BP_Tipologia.Enter += new System.EventHandler(this.BP_Tipologia_Enter);
            this.BP_Tipologia.Leave += new System.EventHandler(this.BP_Tipologia_Leave);
            // 
            // AggiungiBusinessPartner
            // 
            this.AggiungiBusinessPartner.Location = new System.Drawing.Point(3, 147);
            this.AggiungiBusinessPartner.Name = "AggiungiBusinessPartner";
            this.AggiungiBusinessPartner.Size = new System.Drawing.Size(178, 50);
            this.AggiungiBusinessPartner.TabIndex = 9;
            this.AggiungiBusinessPartner.Text = "Aggiungi Business Partner";
            this.AggiungiBusinessPartner.UseVisualStyleBackColor = true;
            this.AggiungiBusinessPartner.Click += new System.EventHandler(this.AggiungiBusinessPartner_Click);
            // 
            // BP_Telefono
            // 
            this.BP_Telefono.Location = new System.Drawing.Point(6, 91);
            this.BP_Telefono.Name = "BP_Telefono";
            this.BP_Telefono.Size = new System.Drawing.Size(178, 22);
            this.BP_Telefono.TabIndex = 8;
            this.BP_Telefono.Text = "Numero di Telefono";
            this.BP_Telefono.Enter += new System.EventHandler(this.BP_Telefono_Enter);
            this.BP_Telefono.Leave += new System.EventHandler(this.BP_Telefono_Leave);
            // 
            // BP_CostoServizio
            // 
            this.BP_CostoServizio.Location = new System.Drawing.Point(6, 62);
            this.BP_CostoServizio.Name = "BP_CostoServizio";
            this.BP_CostoServizio.Size = new System.Drawing.Size(178, 22);
            this.BP_CostoServizio.TabIndex = 7;
            this.BP_CostoServizio.Text = "Costo Servizio";
            this.BP_CostoServizio.Enter += new System.EventHandler(this.BP_CostoServizio_Enter);
            this.BP_CostoServizio.Leave += new System.EventHandler(this.BP_CostoServizio_Leave);
            // 
            // BP_NomeSocio
            // 
            this.BP_NomeSocio.Location = new System.Drawing.Point(6, 34);
            this.BP_NomeSocio.Name = "BP_NomeSocio";
            this.BP_NomeSocio.Size = new System.Drawing.Size(178, 22);
            this.BP_NomeSocio.TabIndex = 6;
            this.BP_NomeSocio.Text = "Nome Socio";
            this.BP_NomeSocio.Enter += new System.EventHandler(this.BP_NomeSocio_Enter);
            this.BP_NomeSocio.Leave += new System.EventHandler(this.BP_NomeSocio_Leave);
            // 
            // BP_PIVA
            // 
            this.BP_PIVA.Location = new System.Drawing.Point(6, 6);
            this.BP_PIVA.Name = "BP_PIVA";
            this.BP_PIVA.Size = new System.Drawing.Size(178, 22);
            this.BP_PIVA.TabIndex = 5;
            this.BP_PIVA.Text = "Partita IVA";
            this.BP_PIVA.Enter += new System.EventHandler(this.BP_PIVA_Enter);
            this.BP_PIVA.Leave += new System.EventHandler(this.BP_PIVA_Leave);
            // 
            // TabellaBusinessPartners
            // 
            this.TabellaBusinessPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBusinessPartners.Location = new System.Drawing.Point(190, 6);
            this.TabellaBusinessPartners.Name = "TabellaBusinessPartners";
            this.TabellaBusinessPartners.ReadOnly = true;
            this.TabellaBusinessPartners.RowHeadersWidth = 51;
            this.TabellaBusinessPartners.RowTemplate.Height = 24;
            this.TabellaBusinessPartners.Size = new System.Drawing.Size(755, 483);
            this.TabellaBusinessPartners.TabIndex = 0;
            this.TabellaBusinessPartners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Percorsi
            // 
            this.Percorsi.Controls.Add(this.Percorsi_IDsede);
            this.Percorsi.Controls.Add(this.Percorsi_LunghezzaPercorso);
            this.Percorsi.Controls.Add(this.AggiungiPercorso);
            this.Percorsi.Controls.Add(this.Percorsi_NumTappe);
            this.Percorsi.Controls.Add(this.Percorsi_NomePercorso);
            this.Percorsi.Controls.Add(this.Percorsi_Difficolta);
            this.Percorsi.Controls.Add(this.Percorsi_IDpercorso);
            this.Percorsi.Controls.Add(this.TabellaPercorsi);
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(951, 495);
            this.Percorsi.TabIndex = 5;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            this.Percorsi.Click += new System.EventHandler(this.Percorsi_Click);
            // 
            // Percorsi_IDsede
            // 
            this.Percorsi_IDsede.Location = new System.Drawing.Point(6, 147);
            this.Percorsi_IDsede.Name = "Percorsi_IDsede";
            this.Percorsi_IDsede.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_IDsede.TabIndex = 11;
            this.Percorsi_IDsede.Text = "ID Sede";
            this.Percorsi_IDsede.Enter += new System.EventHandler(this.Percorsi_IDsede_Enter);
            this.Percorsi_IDsede.Leave += new System.EventHandler(this.Percorsi_IDsede_Leave);
            // 
            // Percorsi_LunghezzaPercorso
            // 
            this.Percorsi_LunghezzaPercorso.Location = new System.Drawing.Point(6, 119);
            this.Percorsi_LunghezzaPercorso.Name = "Percorsi_LunghezzaPercorso";
            this.Percorsi_LunghezzaPercorso.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_LunghezzaPercorso.TabIndex = 10;
            this.Percorsi_LunghezzaPercorso.Text = "Lunghezza Percorso";
            this.Percorsi_LunghezzaPercorso.Enter += new System.EventHandler(this.Percorsi_LunghezzaPercorso_Enter);
            this.Percorsi_LunghezzaPercorso.Leave += new System.EventHandler(this.Percorsi_LunghezzaPercorso_Leave);
            // 
            // AggiungiPercorso
            // 
            this.AggiungiPercorso.Location = new System.Drawing.Point(6, 175);
            this.AggiungiPercorso.Name = "AggiungiPercorso";
            this.AggiungiPercorso.Size = new System.Drawing.Size(178, 35);
            this.AggiungiPercorso.TabIndex = 9;
            this.AggiungiPercorso.Text = "Aggiungi Percorso";
            this.AggiungiPercorso.UseVisualStyleBackColor = true;
            this.AggiungiPercorso.Click += new System.EventHandler(this.AggiungiPercorso_Click);
            // 
            // Percorsi_NumTappe
            // 
            this.Percorsi_NumTappe.Location = new System.Drawing.Point(6, 91);
            this.Percorsi_NumTappe.Name = "Percorsi_NumTappe";
            this.Percorsi_NumTappe.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_NumTappe.TabIndex = 8;
            this.Percorsi_NumTappe.Text = "Numero di Tappe";
            this.Percorsi_NumTappe.Enter += new System.EventHandler(this.Percorsi_NumTappe_Enter);
            this.Percorsi_NumTappe.Leave += new System.EventHandler(this.Percorsi_NumTappe_Leave);
            // 
            // Percorsi_NomePercorso
            // 
            this.Percorsi_NomePercorso.Location = new System.Drawing.Point(6, 62);
            this.Percorsi_NomePercorso.Name = "Percorsi_NomePercorso";
            this.Percorsi_NomePercorso.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_NomePercorso.TabIndex = 7;
            this.Percorsi_NomePercorso.Text = "Nome";
            this.Percorsi_NomePercorso.Enter += new System.EventHandler(this.Percorsi_NomePercorso_Enter);
            this.Percorsi_NomePercorso.Leave += new System.EventHandler(this.Percorsi_NomePercorso_Leave);
            // 
            // Percorsi_Difficolta
            // 
            this.Percorsi_Difficolta.Location = new System.Drawing.Point(6, 34);
            this.Percorsi_Difficolta.Name = "Percorsi_Difficolta";
            this.Percorsi_Difficolta.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_Difficolta.TabIndex = 6;
            this.Percorsi_Difficolta.Text = "Difficoltà";
            this.Percorsi_Difficolta.Enter += new System.EventHandler(this.Percorsi_Difficolta_Enter);
            this.Percorsi_Difficolta.Leave += new System.EventHandler(this.Percorsi_Difficolta_Leave);
            // 
            // Percorsi_IDpercorso
            // 
            this.Percorsi_IDpercorso.Location = new System.Drawing.Point(6, 6);
            this.Percorsi_IDpercorso.Name = "Percorsi_IDpercorso";
            this.Percorsi_IDpercorso.Size = new System.Drawing.Size(178, 22);
            this.Percorsi_IDpercorso.TabIndex = 5;
            this.Percorsi_IDpercorso.Text = "ID Percorso";
            this.Percorsi_IDpercorso.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.Percorsi_IDpercorso.Enter += new System.EventHandler(this.Percorsi_IDpercorso_Enter);
            this.Percorsi_IDpercorso.Leave += new System.EventHandler(this.Percorsi_IDpercorso_Leave);
            // 
            // TabellaPercorsi
            // 
            this.TabellaPercorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPercorsi.Location = new System.Drawing.Point(190, 6);
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
            this.Magazzini.Controls.Add(this.AggiungiMagazzino);
            this.Magazzini.Controls.Add(this.Magazzini_IDindirizzo);
            this.Magazzini.Controls.Add(this.Magazzini_IDmagazzino);
            this.Magazzini.Controls.Add(this.Magazzini_CapMaxBici);
            this.Magazzini.Controls.Add(this.Magazzini_CapMaxAccessori);
            this.Magazzini.Controls.Add(this.TabellaMagazzini);
            this.Magazzini.Location = new System.Drawing.Point(4, 25);
            this.Magazzini.Name = "Magazzini";
            this.Magazzini.Padding = new System.Windows.Forms.Padding(3);
            this.Magazzini.Size = new System.Drawing.Size(951, 495);
            this.Magazzini.TabIndex = 2;
            this.Magazzini.Text = "Magazzini";
            this.Magazzini.UseVisualStyleBackColor = true;
            // 
            // Magazzini_IDsede
            // 
            this.Magazzini_IDsede.Location = new System.Drawing.Point(6, 119);
            this.Magazzini_IDsede.Name = "Magazzini_IDsede";
            this.Magazzini_IDsede.Size = new System.Drawing.Size(178, 22);
            this.Magazzini_IDsede.TabIndex = 10;
            this.Magazzini_IDsede.Text = "ID Sede";
            this.Magazzini_IDsede.Enter += new System.EventHandler(this.Magazzini_IDsede_Enter);
            this.Magazzini_IDsede.Leave += new System.EventHandler(this.Magazzini_IDsede_Leave);
            // 
            // AggiungiMagazzino
            // 
            this.AggiungiMagazzino.Location = new System.Drawing.Point(6, 147);
            this.AggiungiMagazzino.Name = "AggiungiMagazzino";
            this.AggiungiMagazzino.Size = new System.Drawing.Size(178, 44);
            this.AggiungiMagazzino.TabIndex = 9;
            this.AggiungiMagazzino.Text = "Aggiungi Magazzino";
            this.AggiungiMagazzino.UseVisualStyleBackColor = true;
            this.AggiungiMagazzino.Click += new System.EventHandler(this.AggiungiMagazzino_Click);
            // 
            // Magazzini_IDindirizzo
            // 
            this.Magazzini_IDindirizzo.Location = new System.Drawing.Point(6, 91);
            this.Magazzini_IDindirizzo.Name = "Magazzini_IDindirizzo";
            this.Magazzini_IDindirizzo.Size = new System.Drawing.Size(178, 22);
            this.Magazzini_IDindirizzo.TabIndex = 8;
            this.Magazzini_IDindirizzo.Text = "ID Indirizzo";
            this.Magazzini_IDindirizzo.Enter += new System.EventHandler(this.Magazzini_IDindirizzo_Enter);
            this.Magazzini_IDindirizzo.Leave += new System.EventHandler(this.Magazzini_IDindirizzo_Leave);
            // 
            // Magazzini_IDmagazzino
            // 
            this.Magazzini_IDmagazzino.Location = new System.Drawing.Point(6, 62);
            this.Magazzini_IDmagazzino.Name = "Magazzini_IDmagazzino";
            this.Magazzini_IDmagazzino.Size = new System.Drawing.Size(178, 22);
            this.Magazzini_IDmagazzino.TabIndex = 7;
            this.Magazzini_IDmagazzino.Text = "ID Magazzino";
            this.Magazzini_IDmagazzino.Enter += new System.EventHandler(this.Magazzini_IDmagazzino_Enter);
            this.Magazzini_IDmagazzino.Leave += new System.EventHandler(this.Magazzini_IDmagazzino_Leave);
            // 
            // Magazzini_CapMaxBici
            // 
            this.Magazzini_CapMaxBici.Location = new System.Drawing.Point(6, 34);
            this.Magazzini_CapMaxBici.Name = "Magazzini_CapMaxBici";
            this.Magazzini_CapMaxBici.Size = new System.Drawing.Size(178, 22);
            this.Magazzini_CapMaxBici.TabIndex = 6;
            this.Magazzini_CapMaxBici.Text = "Capienza Max Bici";
            this.Magazzini_CapMaxBici.Enter += new System.EventHandler(this.Magazzini_CapMaxBici_Enter);
            this.Magazzini_CapMaxBici.Leave += new System.EventHandler(this.Magazzini_CapMaxBici_Leave);
            // 
            // Magazzini_CapMaxAccessori
            // 
            this.Magazzini_CapMaxAccessori.Location = new System.Drawing.Point(6, 6);
            this.Magazzini_CapMaxAccessori.Name = "Magazzini_CapMaxAccessori";
            this.Magazzini_CapMaxAccessori.Size = new System.Drawing.Size(178, 22);
            this.Magazzini_CapMaxAccessori.TabIndex = 5;
            this.Magazzini_CapMaxAccessori.Text = "Capienza Max Accessori";
            this.Magazzini_CapMaxAccessori.Enter += new System.EventHandler(this.Magazzini_CapMaxAccessori_Enter);
            this.Magazzini_CapMaxAccessori.Leave += new System.EventHandler(this.Magazzini_CapMaxAccessori_Leave);
            // 
            // TabellaMagazzini
            // 
            this.TabellaMagazzini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaMagazzini.Location = new System.Drawing.Point(190, 6);
            this.TabellaMagazzini.Name = "TabellaMagazzini";
            this.TabellaMagazzini.ReadOnly = true;
            this.TabellaMagazzini.RowHeadersWidth = 51;
            this.TabellaMagazzini.RowTemplate.Height = 24;
            this.TabellaMagazzini.Size = new System.Drawing.Size(755, 483);
            this.TabellaMagazzini.TabIndex = 0;
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Controls.Add(this.AggiungiPrenotazione);
            this.Prenotazioni.Controls.Add(this.Prenotazioni_IDtour);
            this.Prenotazioni.Controls.Add(this.Prenotazioni_CFcliente);
            this.Prenotazioni.Controls.Add(this.TabellaPrenotazioni);
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(951, 495);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // AggiungiPrenotazione
            // 
            this.AggiungiPrenotazione.Location = new System.Drawing.Point(6, 62);
            this.AggiungiPrenotazione.Name = "AggiungiPrenotazione";
            this.AggiungiPrenotazione.Size = new System.Drawing.Size(178, 34);
            this.AggiungiPrenotazione.TabIndex = 9;
            this.AggiungiPrenotazione.Text = "Aggiungi Prenotazione";
            this.AggiungiPrenotazione.UseVisualStyleBackColor = true;
            this.AggiungiPrenotazione.Click += new System.EventHandler(this.AggiungiPrenotazione_Click);
            // 
            // Prenotazioni_IDtour
            // 
            this.Prenotazioni_IDtour.Location = new System.Drawing.Point(6, 34);
            this.Prenotazioni_IDtour.Name = "Prenotazioni_IDtour";
            this.Prenotazioni_IDtour.Size = new System.Drawing.Size(178, 22);
            this.Prenotazioni_IDtour.TabIndex = 6;
            this.Prenotazioni_IDtour.Text = "ID Tour";
            this.Prenotazioni_IDtour.Enter += new System.EventHandler(this.Prenotazioni_IDtour_Enter);
            this.Prenotazioni_IDtour.Leave += new System.EventHandler(this.Prenotazioni_IDtour_Leave);
            // 
            // Prenotazioni_CFcliente
            // 
            this.Prenotazioni_CFcliente.Location = new System.Drawing.Point(6, 6);
            this.Prenotazioni_CFcliente.Name = "Prenotazioni_CFcliente";
            this.Prenotazioni_CFcliente.Size = new System.Drawing.Size(178, 22);
            this.Prenotazioni_CFcliente.TabIndex = 5;
            this.Prenotazioni_CFcliente.Text = "Codice Fiscale Cliente";
            this.Prenotazioni_CFcliente.Enter += new System.EventHandler(this.Prenotazioni_CFcliente_Enter);
            this.Prenotazioni_CFcliente.Leave += new System.EventHandler(this.Prenotazioni_CFcliente_Leave);
            // 
            // TabellaPrenotazioni
            // 
            this.TabellaPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaPrenotazioni.Location = new System.Drawing.Point(190, 6);
            this.TabellaPrenotazioni.Name = "TabellaPrenotazioni";
            this.TabellaPrenotazioni.ReadOnly = true;
            this.TabellaPrenotazioni.RowHeadersWidth = 51;
            this.TabellaPrenotazioni.RowTemplate.Height = 24;
            this.TabellaPrenotazioni.Size = new System.Drawing.Size(755, 483);
            this.TabellaPrenotazioni.TabIndex = 0;
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
            this.AggiungiCliente.Location = new System.Drawing.Point(6, 119);
            this.AggiungiCliente.Name = "AggiungiCliente";
            this.AggiungiCliente.Size = new System.Drawing.Size(178, 39);
            this.AggiungiCliente.TabIndex = 4;
            this.AggiungiCliente.Text = "Aggiungi Cliente";
            this.AggiungiCliente.UseVisualStyleBackColor = true;
            this.AggiungiCliente.Click += new System.EventHandler(this.AggiungiCliente_Click);
            // 
            // Clienti_Telefono
            // 
            this.Clienti_Telefono.Location = new System.Drawing.Point(6, 91);
            this.Clienti_Telefono.Name = "Clienti_Telefono";
            this.Clienti_Telefono.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Telefono.TabIndex = 3;
            this.Clienti_Telefono.Text = "Numero di Telefono";
            this.Clienti_Telefono.Enter += new System.EventHandler(this.Telefono_Enter);
            this.Clienti_Telefono.Leave += new System.EventHandler(this.Telefono_Leave);
            // 
            // Clienti_CF
            // 
            this.Clienti_CF.Location = new System.Drawing.Point(6, 62);
            this.Clienti_CF.Name = "Clienti_CF";
            this.Clienti_CF.Size = new System.Drawing.Size(178, 22);
            this.Clienti_CF.TabIndex = 2;
            this.Clienti_CF.Text = "Codice Fiscale";
            this.Clienti_CF.Enter += new System.EventHandler(this.CodiceFiscale_Enter);
            this.Clienti_CF.Leave += new System.EventHandler(this.CodiceFiscale_Leave);
            // 
            // Clienti_Cognome
            // 
            this.Clienti_Cognome.Location = new System.Drawing.Point(6, 34);
            this.Clienti_Cognome.Name = "Clienti_Cognome";
            this.Clienti_Cognome.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Cognome.TabIndex = 1;
            this.Clienti_Cognome.Text = "Cognome";
            this.Clienti_Cognome.Enter += new System.EventHandler(this.Cognome_Enter);
            this.Clienti_Cognome.Leave += new System.EventHandler(this.Cognome_Leave);
            // 
            // Clienti_Nome
            // 
            this.Clienti_Nome.Location = new System.Drawing.Point(6, 6);
            this.Clienti_Nome.Name = "Clienti_Nome";
            this.Clienti_Nome.Size = new System.Drawing.Size(178, 22);
            this.Clienti_Nome.TabIndex = 0;
            this.Clienti_Nome.Text = "Nome";
            this.Clienti_Nome.Enter += new System.EventHandler(this.Nome_Enter);
            this.Clienti_Nome.Leave += new System.EventHandler(this.Nome_Leave);
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
            this.Tour.Controls.Add(this.Tour_CFtourManager);
            this.Tour.Controls.Add(this.Tour_IDsede);
            this.Tour.Controls.Add(this.Tour_IDtour);
            this.Tour.Controls.Add(this.Tour_Prezzo);
            this.Tour.Controls.Add(this.AggiungiTour);
            this.Tour.Controls.Add(this.Tour_DataFine);
            this.Tour.Controls.Add(this.Tour_DataInizio);
            this.Tour.Controls.Add(this.Tour_Nome);
            this.Tour.Controls.Add(this.Tour_Destinazione);
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(951, 495);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // Tour_CFtourManager
            // 
            this.Tour_CFtourManager.Location = new System.Drawing.Point(6, 204);
            this.Tour_CFtourManager.Name = "Tour_CFtourManager";
            this.Tour_CFtourManager.Size = new System.Drawing.Size(178, 22);
            this.Tour_CFtourManager.TabIndex = 13;
            this.Tour_CFtourManager.Text = "CF del Tour Manager";
            this.Tour_CFtourManager.Enter += new System.EventHandler(this.Tour_CFtourManager_Enter);
            this.Tour_CFtourManager.Leave += new System.EventHandler(this.Tour_CFtourManager_Leave);
            // 
            // Tour_IDsede
            // 
            this.Tour_IDsede.Location = new System.Drawing.Point(6, 175);
            this.Tour_IDsede.Name = "Tour_IDsede";
            this.Tour_IDsede.Size = new System.Drawing.Size(178, 22);
            this.Tour_IDsede.TabIndex = 12;
            this.Tour_IDsede.Text = "ID Sede";
            this.Tour_IDsede.Enter += new System.EventHandler(this.Tour_IDsede_Enter);
            this.Tour_IDsede.Leave += new System.EventHandler(this.Tour_IDsede_Leave);
            // 
            // Tour_IDtour
            // 
            this.Tour_IDtour.Location = new System.Drawing.Point(6, 147);
            this.Tour_IDtour.Name = "Tour_IDtour";
            this.Tour_IDtour.Size = new System.Drawing.Size(178, 22);
            this.Tour_IDtour.TabIndex = 11;
            this.Tour_IDtour.Text = "ID Tour";
            this.Tour_IDtour.Enter += new System.EventHandler(this.Tour_IDtour_Enter);
            this.Tour_IDtour.Leave += new System.EventHandler(this.Tour_IDtour_Leave);
            // 
            // Tour_Prezzo
            // 
            this.Tour_Prezzo.Location = new System.Drawing.Point(6, 119);
            this.Tour_Prezzo.Name = "Tour_Prezzo";
            this.Tour_Prezzo.Size = new System.Drawing.Size(178, 22);
            this.Tour_Prezzo.TabIndex = 10;
            this.Tour_Prezzo.Text = "Prezzo";
            this.Tour_Prezzo.Enter += new System.EventHandler(this.Tour_Prezzo_Enter);
            this.Tour_Prezzo.Leave += new System.EventHandler(this.Tour_Prezzo_Leave);
            // 
            // AggiungiTour
            // 
            this.AggiungiTour.Location = new System.Drawing.Point(6, 232);
            this.AggiungiTour.Name = "AggiungiTour";
            this.AggiungiTour.Size = new System.Drawing.Size(178, 35);
            this.AggiungiTour.TabIndex = 9;
            this.AggiungiTour.Text = "Aggiungi Tour";
            this.AggiungiTour.UseVisualStyleBackColor = true;
            this.AggiungiTour.Click += new System.EventHandler(this.AggiungiTour_Click);
            // 
            // Tour_DataFine
            // 
            this.Tour_DataFine.Location = new System.Drawing.Point(6, 91);
            this.Tour_DataFine.Name = "Tour_DataFine";
            this.Tour_DataFine.Size = new System.Drawing.Size(178, 22);
            this.Tour_DataFine.TabIndex = 8;
            this.Tour_DataFine.Text = "Data Fine (YYYY-MM-DD)";
            this.Tour_DataFine.Enter += new System.EventHandler(this.Tour_DataFine_Enter);
            this.Tour_DataFine.Leave += new System.EventHandler(this.Tour_DataFine_Leave);
            // 
            // Tour_DataInizio
            // 
            this.Tour_DataInizio.Location = new System.Drawing.Point(6, 62);
            this.Tour_DataInizio.Name = "Tour_DataInizio";
            this.Tour_DataInizio.Size = new System.Drawing.Size(178, 22);
            this.Tour_DataInizio.TabIndex = 7;
            this.Tour_DataInizio.Text = "Data Inizio (YYYY-MM-DD)";
            this.Tour_DataInizio.Enter += new System.EventHandler(this.Tour_DataInizio_Enter);
            this.Tour_DataInizio.Leave += new System.EventHandler(this.Tour_DataInizio_Leave);
            // 
            // Tour_Nome
            // 
            this.Tour_Nome.Location = new System.Drawing.Point(6, 34);
            this.Tour_Nome.Name = "Tour_Nome";
            this.Tour_Nome.Size = new System.Drawing.Size(178, 22);
            this.Tour_Nome.TabIndex = 6;
            this.Tour_Nome.Text = "Nome";
            this.Tour_Nome.Enter += new System.EventHandler(this.Tour_Nome_Enter);
            this.Tour_Nome.Leave += new System.EventHandler(this.Tour_Nome_Leave);
            // 
            // Tour_Destinazione
            // 
            this.Tour_Destinazione.Location = new System.Drawing.Point(6, 6);
            this.Tour_Destinazione.Name = "Tour_Destinazione";
            this.Tour_Destinazione.Size = new System.Drawing.Size(178, 22);
            this.Tour_Destinazione.TabIndex = 5;
            this.Tour_Destinazione.Text = "Destinazione";
            this.Tour_Destinazione.Enter += new System.EventHandler(this.Tour_Destinazione_Enter);
            this.Tour_Destinazione.Leave += new System.EventHandler(this.Tour_Destinazione_Leave);
            // 
            // TabellaTour
            // 
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(190, 6);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(755, 486);
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
            // Dipendente_isGuida
            // 
            this.Dipendente_isGuida.AutoSize = true;
            this.Dipendente_isGuida.Location = new System.Drawing.Point(6, 175);
            this.Dipendente_isGuida.Name = "Dipendente_isGuida";
            this.Dipendente_isGuida.Size = new System.Drawing.Size(68, 21);
            this.Dipendente_isGuida.TabIndex = 19;
            this.Dipendente_isGuida.Text = "Guida";
            this.Dipendente_isGuida.UseVisualStyleBackColor = true;
            this.Dipendente_isGuida.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Dipendente_isTourManager
            // 
            this.Dipendente_isTourManager.AutoSize = true;
            this.Dipendente_isTourManager.Location = new System.Drawing.Point(7, 203);
            this.Dipendente_isTourManager.Name = "Dipendente_isTourManager";
            this.Dipendente_isTourManager.Size = new System.Drawing.Size(116, 21);
            this.Dipendente_isTourManager.TabIndex = 20;
            this.Dipendente_isTourManager.Text = "TourManager";
            this.Dipendente_isTourManager.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isAltro
            // 
            this.Dipendente_isAltro.AutoSize = true;
            this.Dipendente_isAltro.Location = new System.Drawing.Point(7, 230);
            this.Dipendente_isAltro.Name = "Dipendente_isAltro";
            this.Dipendente_isAltro.Size = new System.Drawing.Size(59, 21);
            this.Dipendente_isAltro.TabIndex = 21;
            this.Dipendente_isAltro.Text = "Altro";
            this.Dipendente_isAltro.UseVisualStyleBackColor = true;
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
            this.Dipendenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).EndInit();
            this.Business_Partners.ResumeLayout(false);
            this.Business_Partners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBusinessPartners)).EndInit();
            this.Percorsi.ResumeLayout(false);
            this.Percorsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPercorsi)).EndInit();
            this.Magazzini.ResumeLayout(false);
            this.Magazzini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaMagazzini)).EndInit();
            this.Prenotazioni.ResumeLayout(false);
            this.Prenotazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaPrenotazioni)).EndInit();
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaClienti)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
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
        private System.Windows.Forms.TextBox Clienti_Telefono;
        private System.Windows.Forms.TextBox Clienti_CF;
        private System.Windows.Forms.TextBox Clienti_Cognome;
        private System.Windows.Forms.TextBox Clienti_Nome;
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
        private System.Windows.Forms.TextBox Dipendenti_Telefono;
        private System.Windows.Forms.TextBox Dipendenti_CF;
        private System.Windows.Forms.TextBox Dipendenti_Cognome;
        private System.Windows.Forms.TextBox Dipendenti_Nome;
        private System.Windows.Forms.Button AggiungiBusinessPartner;
        private System.Windows.Forms.TextBox BP_Telefono;
        private System.Windows.Forms.TextBox BP_CostoServizio;
        private System.Windows.Forms.TextBox BP_NomeSocio;
        private System.Windows.Forms.TextBox BP_PIVA;
        private System.Windows.Forms.TextBox Percorsi_IDsede;
        private System.Windows.Forms.TextBox Percorsi_LunghezzaPercorso;
        private System.Windows.Forms.Button AggiungiPercorso;
        private System.Windows.Forms.TextBox Percorsi_NumTappe;
        private System.Windows.Forms.TextBox Percorsi_NomePercorso;
        private System.Windows.Forms.TextBox Percorsi_Difficolta;
        private System.Windows.Forms.TextBox Percorsi_IDpercorso;
        private System.Windows.Forms.TextBox Magazzini_IDsede;
        private System.Windows.Forms.Button AggiungiMagazzino;
        private System.Windows.Forms.TextBox Magazzini_IDindirizzo;
        private System.Windows.Forms.TextBox Magazzini_IDmagazzino;
        private System.Windows.Forms.TextBox Magazzini_CapMaxBici;
        private System.Windows.Forms.TextBox Magazzini_CapMaxAccessori;
        private System.Windows.Forms.Button AggiungiPrenotazione;
        private System.Windows.Forms.TextBox Prenotazioni_IDtour;
        private System.Windows.Forms.TextBox Prenotazioni_CFcliente;
        private System.Windows.Forms.Button AggiungiTour;
        private System.Windows.Forms.TextBox Tour_DataFine;
        private System.Windows.Forms.TextBox Tour_DataInizio;
        private System.Windows.Forms.TextBox Tour_Nome;
        private System.Windows.Forms.TextBox Tour_Destinazione;
        private System.Windows.Forms.TextBox BP_Tipologia;
        private System.Windows.Forms.TextBox Dipendenti_CFsuperiore;
        private System.Windows.Forms.TextBox Dipendenti_IDsede;
        private System.Windows.Forms.TextBox Dipendenti_Stipendio;
        private System.Windows.Forms.TextBox Dipendenti_CodiceDipendente;
        private System.Windows.Forms.TextBox Tour_CFtourManager;
        private System.Windows.Forms.TextBox Tour_IDsede;
        private System.Windows.Forms.TextBox Tour_IDtour;
        private System.Windows.Forms.TextBox Tour_Prezzo;
        private System.Windows.Forms.Button AggiungiDipendente;
        private System.Windows.Forms.CheckBox Dipendente_isAltro;
        private System.Windows.Forms.CheckBox Dipendente_isTourManager;
        private System.Windows.Forms.CheckBox Dipendente_isGuida;
    }
}

