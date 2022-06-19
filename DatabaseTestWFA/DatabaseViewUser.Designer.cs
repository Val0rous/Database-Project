
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewUser));
            this.button1 = new System.Windows.Forms.Button();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.Clienti = new System.Windows.Forms.TabPage();
            this.Prenotazioni = new System.Windows.Forms.TabPage();
            this.Percorsi = new System.Windows.Forms.TabPage();
            this.Tour = new System.Windows.Forms.TabPage();
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
            this.Tour.Location = new System.Drawing.Point(4, 25);
            this.Tour.Name = "Tour";
            this.Tour.Padding = new System.Windows.Forms.Padding(3);
            this.Tour.Size = new System.Drawing.Size(768, 354);
            this.Tour.TabIndex = 3;
            this.Tour.Text = "Tour";
            this.Tour.UseVisualStyleBackColor = true;
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
            this.TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage Clienti;
        private System.Windows.Forms.TabPage Prenotazioni;
        private System.Windows.Forms.TabPage Percorsi;
        private System.Windows.Forms.TabPage Tour;
    }
}