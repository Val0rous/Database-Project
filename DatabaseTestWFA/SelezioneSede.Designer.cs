
namespace DatabaseProject
{
    partial class SelezioneSede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelezioneSede));
            this.label1 = new System.Windows.Forms.Label();
            this.SedeComboBox = new System.Windows.Forms.ComboBox();
            this.AgenziaComboBox = new System.Windows.Forms.ComboBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvenuto nel gestionale!\r\nSeleziona un\'agenzia e una sede per iniziare:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SedeComboBox
            // 
            this.SedeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SedeComboBox.FormattingEnabled = true;
            this.SedeComboBox.Location = new System.Drawing.Point(192, 194);
            this.SedeComboBox.Name = "SedeComboBox";
            this.SedeComboBox.Size = new System.Drawing.Size(448, 28);
            this.SedeComboBox.TabIndex = 1;
            this.SedeComboBox.Text = "-- Seleziona una sede --";
            this.SedeComboBox.SelectedIndexChanged += new System.EventHandler(this.SedeComboBox_SelectedIndexChanged);
            // 
            // AgenziaComboBox
            // 
            this.AgenziaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgenziaComboBox.FormattingEnabled = true;
            this.AgenziaComboBox.Location = new System.Drawing.Point(192, 150);
            this.AgenziaComboBox.Name = "AgenziaComboBox";
            this.AgenziaComboBox.Size = new System.Drawing.Size(448, 28);
            this.AgenziaComboBox.TabIndex = 2;
            this.AgenziaComboBox.Text = "-- Seleziona un\'agenzia --";
            this.AgenziaComboBox.SelectedIndexChanged += new System.EventHandler(this.AgenziaComboBox_SelectedIndexChanged);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Location = new System.Drawing.Point(303, 248);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(210, 50);
            this.LaunchButton.TabIndex = 3;
            this.LaunchButton.Text = "Entra nel gestionale";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 37);
            this.BackButton.TabIndex = 9;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelezioneSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.AgenziaComboBox);
            this.Controls.Add(this.SedeComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelezioneSede";
            this.Text = "Agenzia di Cicloturismo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseProgram);
            this.Load += new System.EventHandler(this.SelezioneSede_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SedeComboBox;
        private System.Windows.Forms.ComboBox AgenziaComboBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button BackButton;
    }
}