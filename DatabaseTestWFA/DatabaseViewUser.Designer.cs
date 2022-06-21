
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
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Pacchetti = new System.Windows.Forms.TabPage();
            this.CreaPacchettoButton = new System.Windows.Forms.Button();
            this.Pacchetto_Sconto = new System.Windows.Forms.TextBox();
            this.Pacchetto_ID = new System.Windows.Forms.TextBox();
            this.Tour = new System.Windows.Forms.TabPage();
            this.TourID = new System.Windows.Forms.TextBox();
            this.TourButton = new System.Windows.Forms.Button();
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.Clienti_StoricoServizi = new System.Windows.Forms.TabPage();
            this.Tabella_StoricoServiziCliente = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ClienteCF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prenotazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionale_per_agenzie_relDataSet1 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionale_per_agenzie_relDataSet = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet();
            this.clienteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter();
            this.prenotazioneTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter();
            this.TabPage.SuspendLayout();
            this.Pacchetti.SuspendLayout();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).BeginInit();
            this.Clienti_StoricoServizi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella_StoricoServiziCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.Pacchetti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Controls.Add(this.Clienti_StoricoServizi);
            this.TabPage.Location = new System.Drawing.Point(12, 55);
            this.TabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(787, 393);
            this.TabPage.TabIndex = 9;
            this.TabPage.SelectedIndexChanged += new System.EventHandler(this.TabPage_SelectedIndexChanged);
            // 
            // Pacchetti
            // 
            this.Pacchetti.Controls.Add(this.CreaPacchettoButton);
            this.Pacchetti.Controls.Add(this.Pacchetto_Sconto);
            this.Pacchetti.Controls.Add(this.Pacchetto_ID);
            this.Pacchetti.Location = new System.Drawing.Point(4, 25);
            this.Pacchetti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pacchetti.Name = "Pacchetti";
            this.Pacchetti.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pacchetti.Size = new System.Drawing.Size(779, 364);
            this.Pacchetti.TabIndex = 4;
            this.Pacchetti.Text = "Pacchetti";
            this.Pacchetti.UseVisualStyleBackColor = true;
            // 
            // CreaPacchettoButton
            // 
            this.CreaPacchettoButton.Location = new System.Drawing.Point(292, 183);
            this.CreaPacchettoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreaPacchettoButton.Name = "CreaPacchettoButton";
            this.CreaPacchettoButton.Size = new System.Drawing.Size(179, 39);
            this.CreaPacchettoButton.TabIndex = 10;
            this.CreaPacchettoButton.Text = "Crea Pacchetto";
            this.CreaPacchettoButton.UseVisualStyleBackColor = true;
            this.CreaPacchettoButton.Click += new System.EventHandler(this.CreaPacchettoButton_Click);
            // 
            // Pacchetto_Sconto
            // 
            this.Pacchetto_Sconto.Location = new System.Drawing.Point(315, 128);
            this.Pacchetto_Sconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pacchetto_Sconto.Name = "Pacchetto_Sconto";
            this.Pacchetto_Sconto.Size = new System.Drawing.Size(135, 22);
            this.Pacchetto_Sconto.TabIndex = 2;
            this.Pacchetto_Sconto.Text = "Sconto";
            this.Pacchetto_Sconto.Enter += new System.EventHandler(this.Pacchetto_Sconto_Enter);
            this.Pacchetto_Sconto.Leave += new System.EventHandler(this.Pacchetto_Sconto_Leave);
            // 
            // Pacchetto_ID
            // 
            this.Pacchetto_ID.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_ID.Location = new System.Drawing.Point(315, 84);
            this.Pacchetto_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pacchetto_ID.Name = "Pacchetto_ID";
            this.Pacchetto_ID.ReadOnly = true;
            this.Pacchetto_ID.Size = new System.Drawing.Size(135, 22);
            this.Pacchetto_ID.TabIndex = 0;
            this.Pacchetto_ID.Text = "IDPacchetto";
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TourID);
            this.Tour.Controls.Add(this.TourButton);
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tour.Size = new System.Drawing.Size(779, 364);
            this.Tour.TabIndex = 3;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // TourID
            // 
            this.TourID.BackColor = System.Drawing.SystemColors.Window;
            this.TourID.Location = new System.Drawing.Point(189, 324);
            this.TourID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourID.Name = "TourID";
            this.TourID.Size = new System.Drawing.Size(215, 22);
            this.TourID.TabIndex = 12;
            this.TourID.Text = "ID Tour";
            // 
            // TourButton
            // 
            this.TourButton.Location = new System.Drawing.Point(5, 316);
            this.TourButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TourButton.Name = "TourButton";
            this.TourButton.Size = new System.Drawing.Size(179, 37);
            this.TourButton.TabIndex = 11;
            this.TourButton.Text = "Prenota Tour";
            this.TourButton.UseVisualStyleBackColor = true;
            this.TourButton.Click += new System.EventHandler(this.TourButton_Click);
            // 
            // TabellaTour
            // 
            this.TabellaTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TabellaTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(5, 6);
            this.TabellaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(756, 305);
            this.TabellaTour.TabIndex = 0;
            // 
            // Clienti_StoricoServizi
            // 
            this.Clienti_StoricoServizi.Controls.Add(this.Tabella_StoricoServiziCliente);
            this.Clienti_StoricoServizi.Location = new System.Drawing.Point(4, 25);
            this.Clienti_StoricoServizi.Name = "Clienti_StoricoServizi";
            this.Clienti_StoricoServizi.Size = new System.Drawing.Size(779, 364);
            this.Clienti_StoricoServizi.TabIndex = 5;
            this.Clienti_StoricoServizi.Text = "Storico servizi";
            this.Clienti_StoricoServizi.UseVisualStyleBackColor = true;
            // 
            // Tabella_StoricoServiziCliente
            // 
            this.Tabella_StoricoServiziCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tabella_StoricoServiziCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tabella_StoricoServiziCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabella_StoricoServiziCliente.Location = new System.Drawing.Point(3, 3);
            this.Tabella_StoricoServiziCliente.Name = "Tabella_StoricoServiziCliente";
            this.Tabella_StoricoServiziCliente.RowHeadersWidth = 51;
            this.Tabella_StoricoServiziCliente.RowTemplate.Height = 24;
            this.Tabella_StoricoServiziCliente.Size = new System.Drawing.Size(773, 361);
            this.Tabella_StoricoServiziCliente.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(57, 12);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(39, 37);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshAll);
            // 
            // ClienteCF
            // 
            this.ClienteCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClienteCF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ClienteCF.Location = new System.Drawing.Point(329, 20);
            this.ClienteCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClienteCF.Name = "ClienteCF";
            this.ClienteCF.Size = new System.Drawing.Size(309, 28);
            this.ClienteCF.TabIndex = 11;
            this.ClienteCF.Text = "Codice Fiscale";
            this.ClienteCF.Enter += new System.EventHandler(this.ClienteCF_Enter);
            this.ClienteCF.Leave += new System.EventHandler(this.ClienteCF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "CF Cliente:";
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // prenotazioneTableAdapter
            // 
            this.prenotazioneTableAdapter.ClearBeforeFill = true;
            // 
            // DatabaseViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClienteCF);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TabPage);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatabaseViewUser";
            this.Text = "Agenzia di Cicloturismo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseProgram);
            this.Load += new System.EventHandler(this.DatabaseViewUser_Load);
            this.TabPage.ResumeLayout(false);
            this.Pacchetti.ResumeLayout(false);
            this.Pacchetti.PerformLayout();
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
            this.Clienti_StoricoServizi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabella_StoricoServiziCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Tour;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet gestionale_per_agenzie_relDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1 gestionale_per_agenzie_relDataSet1;
        private System.Windows.Forms.BindingSource prenotazioneBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter prenotazioneTableAdapter;
        private System.Windows.Forms.DataGridView TabellaTour;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TabPage Pacchetti;
        private System.Windows.Forms.TextBox Pacchetto_ID;
        private System.Windows.Forms.TextBox Pacchetto_Sconto;
        private System.Windows.Forms.Button CreaPacchettoButton;
        private System.Windows.Forms.TextBox ClienteCF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TourID;
        private System.Windows.Forms.Button TourButton;
        private System.Windows.Forms.TabPage Clienti_StoricoServizi;
        private System.Windows.Forms.DataGridView Tabella_StoricoServiziCliente;
    }
}