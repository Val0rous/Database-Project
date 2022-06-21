
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
            this.TabellaTour = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ClienteCF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TourButton = new System.Windows.Forms.Button();
            this.TourID = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.Pacchetti);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Location = new System.Drawing.Point(9, 45);
            this.TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(590, 319);
            this.TabPage.TabIndex = 9;
            this.TabPage.SelectedIndexChanged += new System.EventHandler(this.TabPage_SelectedIndexChanged);
            // 
            // Pacchetti
            // 
            this.Pacchetti.Controls.Add(this.CreaPacchettoButton);
            this.Pacchetti.Controls.Add(this.Pacchetto_Sconto);
            this.Pacchetti.Controls.Add(this.Pacchetto_ID);
            this.Pacchetti.Location = new System.Drawing.Point(4, 22);
            this.Pacchetti.Margin = new System.Windows.Forms.Padding(2);
            this.Pacchetti.Name = "Pacchetti";
            this.Pacchetti.Padding = new System.Windows.Forms.Padding(2);
            this.Pacchetti.Size = new System.Drawing.Size(582, 293);
            this.Pacchetti.TabIndex = 4;
            this.Pacchetti.Text = "Pacchetti";
            this.Pacchetti.UseVisualStyleBackColor = true;
            // 
            // CreaPacchettoButton
            // 
            this.CreaPacchettoButton.Location = new System.Drawing.Point(219, 149);
            this.CreaPacchettoButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreaPacchettoButton.Name = "CreaPacchettoButton";
            this.CreaPacchettoButton.Size = new System.Drawing.Size(134, 32);
            this.CreaPacchettoButton.TabIndex = 10;
            this.CreaPacchettoButton.Text = "Crea Pacchetto";
            this.CreaPacchettoButton.UseVisualStyleBackColor = true;
            this.CreaPacchettoButton.Click += new System.EventHandler(this.CreaPacchettoButton_Click);
            // 
            // Pacchetto_Sconto
            // 
            this.Pacchetto_Sconto.Location = new System.Drawing.Point(236, 104);
            this.Pacchetto_Sconto.Margin = new System.Windows.Forms.Padding(2);
            this.Pacchetto_Sconto.Name = "Pacchetto_Sconto";
            this.Pacchetto_Sconto.Size = new System.Drawing.Size(102, 20);
            this.Pacchetto_Sconto.TabIndex = 2;
            this.Pacchetto_Sconto.Text = "Sconto";
            this.Pacchetto_Sconto.Enter += new System.EventHandler(this.Pacchetto_Sconto_Enter);
            this.Pacchetto_Sconto.Leave += new System.EventHandler(this.Pacchetto_Sconto_Leave);
            // 
            // Pacchetto_ID
            // 
            this.Pacchetto_ID.BackColor = System.Drawing.SystemColors.Window;
            this.Pacchetto_ID.Location = new System.Drawing.Point(236, 68);
            this.Pacchetto_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Pacchetto_ID.Name = "Pacchetto_ID";
            this.Pacchetto_ID.ReadOnly = true;
            this.Pacchetto_ID.Size = new System.Drawing.Size(102, 20);
            this.Pacchetto_ID.TabIndex = 0;
            this.Pacchetto_ID.Text = "IDPacchetto";
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.TourID);
            this.Tour.Controls.Add(this.TourButton);
            this.Tour.Controls.Add(this.TabellaTour);
            this.Tour.Location = new System.Drawing.Point(4, 22);
            this.Tour.Margin = new System.Windows.Forms.Padding(2);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(2);
            this.Tour.Size = new System.Drawing.Size(582, 293);
            this.Tour.TabIndex = 3;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // TabellaTour
            // 
            this.TabellaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaTour.Location = new System.Drawing.Point(4, 5);
            this.TabellaTour.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaTour.Name = "TabellaTour";
            this.TabellaTour.ReadOnly = true;
            this.TabellaTour.RowHeadersWidth = 51;
            this.TabellaTour.RowTemplate.Height = 24;
            this.TabellaTour.Size = new System.Drawing.Size(567, 248);
            this.TabellaTour.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Location = new System.Drawing.Point(43, 10);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(29, 30);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshAll);
            // 
            // ClienteCF
            // 
            this.ClienteCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClienteCF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ClienteCF.Location = new System.Drawing.Point(247, 16);
            this.ClienteCF.Margin = new System.Windows.Forms.Padding(2);
            this.ClienteCF.Name = "ClienteCF";
            this.ClienteCF.Size = new System.Drawing.Size(233, 24);
            this.ClienteCF.TabIndex = 11;
            this.ClienteCF.Text = "Codice Fiscale";
            this.ClienteCF.Enter += new System.EventHandler(this.ClienteCF_Enter);
            this.ClienteCF.Leave += new System.EventHandler(this.ClienteCF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "CF Cliente:";
            // 
            // TourButton
            // 
            this.TourButton.Location = new System.Drawing.Point(4, 257);
            this.TourButton.Margin = new System.Windows.Forms.Padding(2);
            this.TourButton.Name = "TourButton";
            this.TourButton.Size = new System.Drawing.Size(134, 30);
            this.TourButton.TabIndex = 11;
            this.TourButton.Text = "Prenota Tour";
            this.TourButton.UseVisualStyleBackColor = true;
            this.TourButton.Click += new System.EventHandler(this.TourButton_Click);
            // 
            // TourID
            // 
            this.TourID.BackColor = System.Drawing.SystemColors.Window;
            this.TourID.Location = new System.Drawing.Point(142, 263);
            this.TourID.Margin = new System.Windows.Forms.Padding(2);
            this.TourID.Name = "TourID";
            this.TourID.Size = new System.Drawing.Size(162, 20);
            this.TourID.TabIndex = 12;
            this.TourID.Text = "ID Tour";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClienteCF);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TabPage);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseViewUser";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.DatabaseViewUser_Load);
            this.TabPage.ResumeLayout(false);
            this.Pacchetti.ResumeLayout(false);
            this.Pacchetti.PerformLayout();
            this.Tour.ResumeLayout(false);
            this.Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaTour)).EndInit();
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
    }
}