
namespace DatabaseProject
{
    partial class UserServices
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
            this.Clienti = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AggiungiNoleggioButton = new System.Windows.Forms.Button();
            this.Bici = new System.Windows.Forms.TextBox();
            this.TabellaBici = new System.Windows.Forms.DataGridView();
            this.NoleggiaBiciButton = new System.Windows.Forms.Button();
            this.Dipendenti = new System.Windows.Forms.TabPage();
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
            this.Tour = new System.Windows.Forms.TabPage();
            this.TourPrezzo = new System.Windows.Forms.TextBox();
            this.TourCFManager = new System.Windows.Forms.TextBox();
            this.TourDataFine = new System.Windows.Forms.TextBox();
            this.TourDataInizio = new System.Windows.Forms.TextBox();
            this.TourNome = new System.Windows.Forms.TextBox();
            this.TourDestinazione = new System.Windows.Forms.TextBox();
            this.Tour_ID = new System.Windows.Forms.TextBox();
            this.AggiungiTour = new System.Windows.Forms.Button();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pacchetto_Prezzo = new System.Windows.Forms.TextBox();
            this.Pacchetto_Sconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Servizio_DataFine = new System.Windows.Forms.TextBox();
            this.Servizio_DataInizio = new System.Windows.Forms.TextBox();
            this.Servizio_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AggiornaButton = new System.Windows.Forms.Button();
            this.NoleggioBiciclette_Lista = new System.Windows.Forms.ListView();
            this.TabPage.SuspendLayout();
            this.Clienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBici)).BeginInit();
            this.Dipendenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).BeginInit();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.AccessibleName = "";
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Dipendenti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPage.Location = new System.Drawing.Point(154, 52);
            this.TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage.Multiline = true;
            this.TabPage.Name = "TabPage";
            this.TabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(574, 426);
            this.TabPage.TabIndex = 5;
            this.TabPage.Tag = "";
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.NoleggioBiciclette_Lista);
            this.Clienti.Controls.Add(this.label5);
            this.Clienti.Controls.Add(this.label4);
            this.Clienti.Controls.Add(this.AggiungiNoleggioButton);
            this.Clienti.Controls.Add(this.Bici);
            this.Clienti.Controls.Add(this.TabellaBici);
            this.Clienti.Controls.Add(this.NoleggiaBiciButton);
            this.Clienti.Location = new System.Drawing.Point(4, 22);
            this.Clienti.Margin = new System.Windows.Forms.Padding(2);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(2);
            this.Clienti.Size = new System.Drawing.Size(566, 400);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Noleggio Biciclette";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleziona la bici:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lista bici noleggiate:";
            // 
            // AggiungiNoleggioButton
            // 
            this.AggiungiNoleggioButton.Location = new System.Drawing.Point(7, 66);
            this.AggiungiNoleggioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiNoleggioButton.Name = "AggiungiNoleggioButton";
            this.AggiungiNoleggioButton.Size = new System.Drawing.Size(112, 32);
            this.AggiungiNoleggioButton.TabIndex = 12;
            this.AggiungiNoleggioButton.Text = "Aggiungi al Noleggio";
            this.AggiungiNoleggioButton.UseVisualStyleBackColor = true;
            this.AggiungiNoleggioButton.Click += new System.EventHandler(this.AggiungiNoleggioButton_Click);
            // 
            // Bici
            // 
            this.Bici.BackColor = System.Drawing.SystemColors.Window;
            this.Bici.Location = new System.Drawing.Point(7, 42);
            this.Bici.Margin = new System.Windows.Forms.Padding(2);
            this.Bici.Name = "Bici";
            this.Bici.Size = new System.Drawing.Size(111, 20);
            this.Bici.TabIndex = 11;
            this.Bici.Text = "Numero di Telaio";
            // 
            // TabellaBici
            // 
            this.TabellaBici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBici.Location = new System.Drawing.Point(123, 5);
            this.TabellaBici.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBici.Name = "TabellaBici";
            this.TabellaBici.ReadOnly = true;
            this.TabellaBici.RowHeadersWidth = 51;
            this.TabellaBici.RowTemplate.Height = 24;
            this.TabellaBici.Size = new System.Drawing.Size(439, 392);
            this.TabellaBici.TabIndex = 5;
            // 
            // NoleggiaBiciButton
            // 
            this.NoleggiaBiciButton.Location = new System.Drawing.Point(7, 359);
            this.NoleggiaBiciButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoleggiaBiciButton.Name = "NoleggiaBiciButton";
            this.NoleggiaBiciButton.Size = new System.Drawing.Size(111, 32);
            this.NoleggiaBiciButton.TabIndex = 4;
            this.NoleggiaBiciButton.Text = "Noleggia Bici";
            this.NoleggiaBiciButton.UseVisualStyleBackColor = true;
            this.NoleggiaBiciButton.Click += new System.EventHandler(this.NoleggiaBiciButton_Click);
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
            this.Dipendenti.Controls.Add(this.Dipendenti_Telefono);
            this.Dipendenti.Controls.Add(this.Dipendenti_CF);
            this.Dipendenti.Controls.Add(this.Dipendenti_Cognome);
            this.Dipendenti.Controls.Add(this.Dipendenti_Nome);
            this.Dipendenti.Controls.Add(this.AggiungiDipendente);
            this.Dipendenti.Controls.Add(this.TabellaDipendenti);
            this.Dipendenti.Location = new System.Drawing.Point(4, 22);
            this.Dipendenti.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(2);
            this.Dipendenti.Size = new System.Drawing.Size(566, 400);
            this.Dipendenti.TabIndex = 7;
            this.Dipendenti.Text = "Noleggio Accessori";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isAltro
            // 
            this.Dipendente_isAltro.AutoSize = true;
            this.Dipendente_isAltro.Location = new System.Drawing.Point(5, 187);
            this.Dipendente_isAltro.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendente_isAltro.Name = "Dipendente_isAltro";
            this.Dipendente_isAltro.Size = new System.Drawing.Size(47, 17);
            this.Dipendente_isAltro.TabIndex = 21;
            this.Dipendente_isAltro.Text = "Altro";
            this.Dipendente_isAltro.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isTourManager
            // 
            this.Dipendente_isTourManager.AutoSize = true;
            this.Dipendente_isTourManager.Location = new System.Drawing.Point(5, 165);
            this.Dipendente_isTourManager.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendente_isTourManager.Name = "Dipendente_isTourManager";
            this.Dipendente_isTourManager.Size = new System.Drawing.Size(90, 17);
            this.Dipendente_isTourManager.TabIndex = 20;
            this.Dipendente_isTourManager.Text = "TourManager";
            this.Dipendente_isTourManager.UseVisualStyleBackColor = true;
            // 
            // Dipendente_isGuida
            // 
            this.Dipendente_isGuida.AutoSize = true;
            this.Dipendente_isGuida.Location = new System.Drawing.Point(4, 142);
            this.Dipendente_isGuida.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendente_isGuida.Name = "Dipendente_isGuida";
            this.Dipendente_isGuida.Size = new System.Drawing.Size(54, 17);
            this.Dipendente_isGuida.TabIndex = 19;
            this.Dipendente_isGuida.Text = "Guida";
            this.Dipendente_isGuida.UseVisualStyleBackColor = true;
            // 
            // Dipendenti_CFsuperiore
            // 
            this.Dipendenti_CFsuperiore.Location = new System.Drawing.Point(2, 228);
            this.Dipendenti_CFsuperiore.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_CFsuperiore.Name = "Dipendenti_CFsuperiore";
            this.Dipendenti_CFsuperiore.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_CFsuperiore.TabIndex = 17;
            this.Dipendenti_CFsuperiore.Text = "Cod. Fiscale del Superiore";
            // 
            // Dipendenti_IDsede
            // 
            this.Dipendenti_IDsede.Location = new System.Drawing.Point(2, 206);
            this.Dipendenti_IDsede.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_IDsede.Name = "Dipendenti_IDsede";
            this.Dipendenti_IDsede.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_IDsede.TabIndex = 16;
            this.Dipendenti_IDsede.Text = "ID Sede";
            // 
            // Dipendenti_Stipendio
            // 
            this.Dipendenti_Stipendio.Location = new System.Drawing.Point(4, 119);
            this.Dipendenti_Stipendio.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_Stipendio.Name = "Dipendenti_Stipendio";
            this.Dipendenti_Stipendio.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_Stipendio.TabIndex = 11;
            this.Dipendenti_Stipendio.Text = "Stipendio";
            // 
            // Dipendenti_CodiceDipendente
            // 
            this.Dipendenti_CodiceDipendente.Location = new System.Drawing.Point(4, 97);
            this.Dipendenti_CodiceDipendente.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_CodiceDipendente.Name = "Dipendenti_CodiceDipendente";
            this.Dipendenti_CodiceDipendente.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_CodiceDipendente.TabIndex = 10;
            this.Dipendenti_CodiceDipendente.Text = "Codice Dipendente";
            // 
            // Dipendenti_Telefono
            // 
            this.Dipendenti_Telefono.Location = new System.Drawing.Point(4, 74);
            this.Dipendenti_Telefono.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_Telefono.Name = "Dipendenti_Telefono";
            this.Dipendenti_Telefono.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_Telefono.TabIndex = 8;
            this.Dipendenti_Telefono.Text = "Numero di Telefono";
            // 
            // Dipendenti_CF
            // 
            this.Dipendenti_CF.Location = new System.Drawing.Point(4, 50);
            this.Dipendenti_CF.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_CF.Name = "Dipendenti_CF";
            this.Dipendenti_CF.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_CF.TabIndex = 7;
            this.Dipendenti_CF.Text = "Codice Fiscale";
            // 
            // Dipendenti_Cognome
            // 
            this.Dipendenti_Cognome.Location = new System.Drawing.Point(4, 28);
            this.Dipendenti_Cognome.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_Cognome.Name = "Dipendenti_Cognome";
            this.Dipendenti_Cognome.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_Cognome.TabIndex = 6;
            this.Dipendenti_Cognome.Text = "Cognome";
            // 
            // Dipendenti_Nome
            // 
            this.Dipendenti_Nome.Location = new System.Drawing.Point(4, 5);
            this.Dipendenti_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.Dipendenti_Nome.Name = "Dipendenti_Nome";
            this.Dipendenti_Nome.Size = new System.Drawing.Size(134, 20);
            this.Dipendenti_Nome.TabIndex = 5;
            this.Dipendenti_Nome.Text = "Nome";
            // 
            // AggiungiDipendente
            // 
            this.AggiungiDipendente.Location = new System.Drawing.Point(2, 251);
            this.AggiungiDipendente.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiDipendente.Name = "AggiungiDipendente";
            this.AggiungiDipendente.Size = new System.Drawing.Size(134, 38);
            this.AggiungiDipendente.TabIndex = 9;
            this.AggiungiDipendente.Text = "Aggiungi Dipendente";
            this.AggiungiDipendente.UseVisualStyleBackColor = true;
            // 
            // TabellaDipendenti
            // 
            this.TabellaDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaDipendenti.Location = new System.Drawing.Point(142, 5);
            this.TabellaDipendenti.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaDipendenti.Name = "TabellaDipendenti";
            this.TabellaDipendenti.ReadOnly = true;
            this.TabellaDipendenti.RowHeadersWidth = 51;
            this.TabellaDipendenti.RowTemplate.Height = 24;
            this.TabellaDipendenti.Size = new System.Drawing.Size(566, 395);
            this.TabellaDipendenti.TabIndex = 0;
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TourPrezzo);
            this.Tour.Controls.Add(this.TourCFManager);
            this.Tour.Controls.Add(this.TourDataFine);
            this.Tour.Controls.Add(this.TourDataInizio);
            this.Tour.Controls.Add(this.TourNome);
            this.Tour.Controls.Add(this.TourDestinazione);
            this.Tour.Controls.Add(this.Tour_ID);
            this.Tour.Controls.Add(this.AggiungiTour);
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 22);
            this.Tour.Margin = new System.Windows.Forms.Padding(2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(2);
            this.Tour.Size = new System.Drawing.Size(566, 400);
            this.Tour.TabIndex = 8;
            this.Tour.Text = "Percorsi Guidati";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // TourPrezzo
            // 
            this.TourPrezzo.Location = new System.Drawing.Point(4, 121);
            this.TourPrezzo.Margin = new System.Windows.Forms.Padding(2);
            this.TourPrezzo.Name = "TourPrezzo";
            this.TourPrezzo.Size = new System.Drawing.Size(134, 20);
            this.TourPrezzo.TabIndex = 19;
            this.TourPrezzo.Text = "Prezzo";
            // 
            // TourCFManager
            // 
            this.TourCFManager.Location = new System.Drawing.Point(4, 146);
            this.TourCFManager.Margin = new System.Windows.Forms.Padding(2);
            this.TourCFManager.Name = "TourCFManager";
            this.TourCFManager.Size = new System.Drawing.Size(134, 20);
            this.TourCFManager.TabIndex = 18;
            this.TourCFManager.Text = "Tour Manager";
            // 
            // TourDataFine
            // 
            this.TourDataFine.Location = new System.Drawing.Point(4, 97);
            this.TourDataFine.Margin = new System.Windows.Forms.Padding(2);
            this.TourDataFine.Name = "TourDataFine";
            this.TourDataFine.Size = new System.Drawing.Size(134, 20);
            this.TourDataFine.TabIndex = 16;
            this.TourDataFine.Text = "Data Fine";
            // 
            // TourDataInizio
            // 
            this.TourDataInizio.Location = new System.Drawing.Point(4, 74);
            this.TourDataInizio.Margin = new System.Windows.Forms.Padding(2);
            this.TourDataInizio.Name = "TourDataInizio";
            this.TourDataInizio.Size = new System.Drawing.Size(134, 20);
            this.TourDataInizio.TabIndex = 15;
            this.TourDataInizio.Text = "Data Inizio";
            // 
            // TourNome
            // 
            this.TourNome.Location = new System.Drawing.Point(4, 50);
            this.TourNome.Margin = new System.Windows.Forms.Padding(2);
            this.TourNome.Name = "TourNome";
            this.TourNome.Size = new System.Drawing.Size(134, 20);
            this.TourNome.TabIndex = 14;
            this.TourNome.Text = "Nome";
            // 
            // TourDestinazione
            // 
            this.TourDestinazione.Location = new System.Drawing.Point(4, 28);
            this.TourDestinazione.Margin = new System.Windows.Forms.Padding(2);
            this.TourDestinazione.Name = "TourDestinazione";
            this.TourDestinazione.Size = new System.Drawing.Size(134, 20);
            this.TourDestinazione.TabIndex = 13;
            this.TourDestinazione.Text = "Destinazione";
            // 
            // Tour_ID
            // 
            this.Tour_ID.Location = new System.Drawing.Point(4, 5);
            this.Tour_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Tour_ID.Name = "Tour_ID";
            this.Tour_ID.Size = new System.Drawing.Size(134, 20);
            this.Tour_ID.TabIndex = 12;
            this.Tour_ID.Text = "ID Tour";
            // 
            // AggiungiTour
            // 
            this.AggiungiTour.Location = new System.Drawing.Point(4, 170);
            this.AggiungiTour.Margin = new System.Windows.Forms.Padding(2);
            this.AggiungiTour.Name = "AggiungiTour";
            this.AggiungiTour.Size = new System.Drawing.Size(134, 28);
            this.AggiungiTour.TabIndex = 9;
            this.AggiungiTour.Text = "Aggiungi Tour";
            this.AggiungiTour.UseVisualStyleBackColor = true;
            // 
            // TabellaTour
            // 
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(142, 5);
            this.TabellaTour.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(566, 395);
            this.TabellaTour.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prezzo";
            // 
            // Pacchetto_Prezzo
            // 
            this.Pacchetto_Prezzo.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_Prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pacchetto_Prezzo.Location = new System.Drawing.Point(118, 16);
            this.Pacchetto_Prezzo.Name = "Pacchetto_Prezzo";
            this.Pacchetto_Prezzo.ReadOnly = true;
            this.Pacchetto_Prezzo.Size = new System.Drawing.Size(118, 24);
            this.Pacchetto_Prezzo.TabIndex = 7;
            // 
            // Pacchetto_Sconto
            // 
            this.Pacchetto_Sconto.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_Sconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Pacchetto_Sconto.Location = new System.Drawing.Point(350, 16);
            this.Pacchetto_Sconto.Name = "Pacchetto_Sconto";
            this.Pacchetto_Sconto.ReadOnly = true;
            this.Pacchetto_Sconto.Size = new System.Drawing.Size(118, 24);
            this.Pacchetto_Sconto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(288, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sconto";
            // 
            // Servizio_DataFine
            // 
            this.Servizio_DataFine.Location = new System.Drawing.Point(11, 159);
            this.Servizio_DataFine.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_DataFine.Name = "Servizio_DataFine";
            this.Servizio_DataFine.Size = new System.Drawing.Size(134, 20);
            this.Servizio_DataFine.TabIndex = 12;
            this.Servizio_DataFine.Text = "Data Fine";
            this.Servizio_DataFine.Enter += new System.EventHandler(this.Servizio_DataFine_Enter);
            this.Servizio_DataFine.Leave += new System.EventHandler(this.Servizio_DataFine_Leave);
            // 
            // Servizio_DataInizio
            // 
            this.Servizio_DataInizio.Location = new System.Drawing.Point(11, 137);
            this.Servizio_DataInizio.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_DataInizio.Name = "Servizio_DataInizio";
            this.Servizio_DataInizio.Size = new System.Drawing.Size(134, 20);
            this.Servizio_DataInizio.TabIndex = 11;
            this.Servizio_DataInizio.Text = "Data Inizio";
            this.Servizio_DataInizio.Enter += new System.EventHandler(this.Servizio_DataInizio_Enter);
            this.Servizio_DataInizio.Leave += new System.EventHandler(this.Servizio_DataInizio_Leave);
            // 
            // Servizio_ID
            // 
            this.Servizio_ID.BackColor = System.Drawing.SystemColors.Window;
            this.Servizio_ID.Location = new System.Drawing.Point(11, 102);
            this.Servizio_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Servizio_ID.Name = "Servizio_ID";
            this.Servizio_ID.ReadOnly = true;
            this.Servizio_ID.Size = new System.Drawing.Size(134, 20);
            this.Servizio_ID.TabIndex = 10;
            this.Servizio_ID.Text = "ID Servizio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(41, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Info servizio";
            // 
            // AggiornaButton
            // 
            this.AggiornaButton.Location = new System.Drawing.Point(32, 202);
            this.AggiornaButton.Margin = new System.Windows.Forms.Padding(2);
            this.AggiornaButton.Name = "AggiornaButton";
            this.AggiornaButton.Size = new System.Drawing.Size(89, 32);
            this.AggiornaButton.TabIndex = 15;
            this.AggiornaButton.Text = "Aggiorna";
            this.AggiornaButton.UseVisualStyleBackColor = true;
            this.AggiornaButton.Enter += new System.EventHandler(this.AggiornaButton_Enter);
            // 
            // NoleggioBiciclette_Lista
            // 
            this.NoleggioBiciclette_Lista.HideSelection = false;
            this.NoleggioBiciclette_Lista.Location = new System.Drawing.Point(7, 140);
            this.NoleggioBiciclette_Lista.Name = "NoleggioBiciclette_Lista";
            this.NoleggioBiciclette_Lista.Size = new System.Drawing.Size(111, 214);
            this.NoleggioBiciclette_Lista.TabIndex = 17;
            this.NoleggioBiciclette_Lista.UseCompatibleStateImageBehavior = false;
            // 
            // UserServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 480);
            this.Controls.Add(this.AggiornaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Servizio_DataFine);
            this.Controls.Add(this.Servizio_DataInizio);
            this.Controls.Add(this.Servizio_ID);
            this.Controls.Add(this.Pacchetto_Sconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pacchetto_Prezzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabPage);
            this.Name = "UserServices";
            this.Text = "UserServices";
            this.Load += new System.EventHandler(this.UserServices_Load);
            this.TabPage.ResumeLayout(false);
            this.Clienti.ResumeLayout(false);
            this.Clienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBici)).EndInit();
            this.Dipendenti.ResumeLayout(false);
            this.Dipendenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaDipendenti)).EndInit();
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.DataGridView TabellaBici;
        private System.Windows.Forms.Button NoleggiaBiciButton;
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
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.TextBox TourPrezzo;
        private System.Windows.Forms.TextBox TourCFManager;
        private System.Windows.Forms.TextBox TourDataFine;
        private System.Windows.Forms.TextBox TourDataInizio;
        private System.Windows.Forms.TextBox TourNome;
        private System.Windows.Forms.TextBox TourDestinazione;
        private System.Windows.Forms.TextBox Tour_ID;
        private System.Windows.Forms.Button AggiungiTour;
        private System.Windows.Forms.DataGridView TabellaTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pacchetto_Prezzo;
        private System.Windows.Forms.TextBox Pacchetto_Sconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Servizio_DataFine;
        private System.Windows.Forms.TextBox Servizio_DataInizio;
        private System.Windows.Forms.TextBox Servizio_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AggiungiNoleggioButton;
        private System.Windows.Forms.TextBox Bici;
        private System.Windows.Forms.Button AggiornaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView NoleggioBiciclette_Lista;
    }
}