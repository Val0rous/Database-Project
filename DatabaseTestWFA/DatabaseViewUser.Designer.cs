
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
            this.Clienti = new System.Windows.Forms.TabPage();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.Tour = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestionale_per_agenzie_relDataSet = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recapitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gestionale_per_agenzie_relDataSet1 = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1();
            this.prenotazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prenotazioneTableAdapter = new DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter();
            this.cFclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.TabPage.SuspendLayout();
            this.Clienti.SuspendLayout();
            this.Prenotazioni.SuspendLayout();
            this.Percorsi.SuspendLayout();
            this.Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            // TabPage
            // 
            this.TabPage.Controls.Add(this.Clienti);
            this.TabPage.Controls.Add(this.Prenotazioni);
            this.TabPage.Controls.Add(this.Percorsi);
            this.TabPage.Controls.Add(this.Tour);
            this.TabPage.Location = new System.Drawing.Point(12, 55);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(776, 383);
            this.TabPage.TabIndex = 9;
            // 
            // Clienti
            // 
            this.Clienti.Controls.Add(this.dataGridView1);
            this.Clienti.Location = new System.Drawing.Point(4, 25);
            this.Clienti.Name = "Clienti";
            this.Clienti.Padding = new System.Windows.Forms.Padding(3);
            this.Clienti.Size = new System.Drawing.Size(768, 354);
            this.Clienti.TabIndex = 0;
            this.Clienti.Text = "Clienti";
            this.Clienti.UseVisualStyleBackColor = true;
            // 
            // Prenotazioni
            // 
            this.Prenotazioni.Controls.Add(this.dataGridView2);
            this.Prenotazioni.Location = new System.Drawing.Point(4, 25);
            this.Prenotazioni.Name = "Prenotazioni";
            this.Prenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.Prenotazioni.Size = new System.Drawing.Size(768, 354);
            this.Prenotazioni.TabIndex = 1;
            this.Prenotazioni.Text = "Prenotazioni";
            this.Prenotazioni.UseVisualStyleBackColor = true;
            // 
            // Percorsi
            // 
            this.Percorsi.Controls.Add(this.dataGridView3);
            this.Percorsi.Location = new System.Drawing.Point(4, 25);
            this.Percorsi.Name = "Percorsi";
            this.Percorsi.Padding = new System.Windows.Forms.Padding(3);
            this.Percorsi.Size = new System.Drawing.Size(768, 354);
            this.Percorsi.TabIndex = 2;
            this.Percorsi.Text = "Percorsi";
            this.Percorsi.UseVisualStyleBackColor = true;
            // 
            // Tour
            // 
            this.Tour.Controls.Add(this.dataGridView4);
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(768, 354);
            this.Tour.TabIndex = 3;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.cFDataGridViewTextBoxColumn,
            this.recapitoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestionale_per_agenzie_relDataSet
            // 
            this.gestionale_per_agenzie_relDataSet.DataSetName = "gestionale_per_agenzie_relDataSet";
            this.gestionale_per_agenzie_relDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cFDataGridViewTextBoxColumn
            // 
            this.cFDataGridViewTextBoxColumn.DataPropertyName = "CF";
            this.cFDataGridViewTextBoxColumn.HeaderText = "CF";
            this.cFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFDataGridViewTextBoxColumn.Name = "cFDataGridViewTextBoxColumn";
            this.cFDataGridViewTextBoxColumn.Width = 125;
            // 
            // recapitoDataGridViewTextBoxColumn
            // 
            this.recapitoDataGridViewTextBoxColumn.DataPropertyName = "Recapito";
            this.recapitoDataGridViewTextBoxColumn.HeaderText = "Recapito";
            this.recapitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recapitoDataGridViewTextBoxColumn.Name = "recapitoDataGridViewTextBoxColumn";
            this.recapitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFclienteDataGridViewTextBoxColumn,
            this.iDtourDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.prenotazioneBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(759, 345);
            this.dataGridView2.TabIndex = 0;
            // 
            // gestionale_per_agenzie_relDataSet1
            // 
            this.gestionale_per_agenzie_relDataSet1.DataSetName = "gestionale_per_agenzie_relDataSet1";
            this.gestionale_per_agenzie_relDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prenotazioneBindingSource
            // 
            this.prenotazioneBindingSource.DataMember = "prenotazione";
            this.prenotazioneBindingSource.DataSource = this.gestionale_per_agenzie_relDataSet1;
            // 
            // prenotazioneTableAdapter
            // 
            this.prenotazioneTableAdapter.ClearBeforeFill = true;
            // 
            // cFclienteDataGridViewTextBoxColumn
            // 
            this.cFclienteDataGridViewTextBoxColumn.DataPropertyName = "CFcliente";
            this.cFclienteDataGridViewTextBoxColumn.HeaderText = "CFcliente";
            this.cFclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFclienteDataGridViewTextBoxColumn.Name = "cFclienteDataGridViewTextBoxColumn";
            this.cFclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDtourDataGridViewTextBoxColumn
            // 
            this.iDtourDataGridViewTextBoxColumn.DataPropertyName = "IDtour";
            this.iDtourDataGridViewTextBoxColumn.HeaderText = "IDtour";
            this.iDtourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDtourDataGridViewTextBoxColumn.Name = "iDtourDataGridViewTextBoxColumn";
            this.iDtourDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(756, 342);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(756, 342);
            this.dataGridView4.TabIndex = 0;
            // 
            // DatabaseViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabPage);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewUser";
            this.Text = "Agenzia di Cicloturismo";
            this.Load += new System.EventHandler(this.DatabaseViewUser_Load);
            this.TabPage.ResumeLayout(false);
            this.Clienti.ResumeLayout(false);
            this.Prenotazioni.ResumeLayout(false);
            this.Percorsi.ResumeLayout(false);
            this.Tour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionale_per_agenzie_relDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Tour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet gestionale_per_agenzie_relDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recapitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1 gestionale_per_agenzie_relDataSet1;
        private System.Windows.Forms.BindingSource prenotazioneBindingSource;
        private DatabaseTestWFA.gestionale_per_agenzie_relDataSet1TableAdapters.prenotazioneTableAdapter prenotazioneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}